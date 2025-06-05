using System;
using System.Linq;
using System.Windows.Forms;
using Bakery_Schedule.modele;
using Microsoft.EntityFrameworkCore;
namespace Bakery_Schedule
{
    public partial class EditEmployeeForm : Form
    {
        private int employeeId;

        public EditEmployeeForm(int id)
        {
            InitializeComponent();
            employeeId = id;
            this.Load += EditEmployeeForm_Load;
            
            txtYearsOfExperience.KeyPress += txtYearsOfExperience_KeyPress;
            txtYearsOfExperience.Validating += txtYearsOfExperience_Validating;
          
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                
                cbPosition.DataSource = context.Stanowisko.ToList();
                cbPosition.DisplayMember = "NazwaStanowiska";
                cbPosition.ValueMember = "ID_stanowiska";

                cbProduct.DataSource = context.Produkt.ToList();
                cbProduct.DisplayMember = "Nazwa";
                cbProduct.ValueMember = "ID_produktu";

                cbAddress.DataSource = context.Adres.ToList();
                cbAddress.DisplayMember = "PelnyAdres";
                cbAddress.ValueMember = "ID_adresu";
           
                var emp = context.Pracownik
                .Include(p => p.Stanowisko)
                .Include(p => p.Adres)
                .FirstOrDefault(p => p.ID_pracownika == employeeId);
                if (emp != null)
                {
                    txtFirstName.Text = emp.Imie;
                    txtLastName.Text = emp.Nazwisko;
                    txtPhoneNumber.Text = emp.Telefon;
                    txtContractType.Text = emp.RodzajUmowy;

                    if (!int.TryParse(txtYearsOfExperience.Text, out int lataDosw) || lataDosw < 0)
                    {
                        return;
                    }

                    emp.LataDoswiadczenia = lataDosw;

                    cbPosition.SelectedValue = emp.ID_stanowiska ?? -1;
                    cbAddress.SelectedValue = emp.ID_adresu;
                    if (emp.Stanowisko?.ID_produktu != null)
                    {
                        cbProduct.SelectedValue = emp.Stanowisko.ID_produktu.Value;
                    }
                }
            }
        }

        private void txtYearsOfExperience_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Tylko cyfry i Backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtYearsOfExperience_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (int.TryParse(txtYearsOfExperience.Text, out int value))
            {
                if (value > 45)
                {
                    MessageBox.Show("Lata doświadczenia nie mogą być większe niż 45.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            else if (!string.IsNullOrEmpty(txtYearsOfExperience.Text))
            {
                MessageBox.Show("Proszę wpisać poprawną liczbę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                var emp = context.Pracownik
                    .Include(p => p.Stanowisko)
                    .Include(p => p.Adres)
                    .FirstOrDefault(p => p.ID_pracownika == employeeId);

                if (emp != null)
                {
                    emp.Imie = txtFirstName.Text;
                    emp.Nazwisko = txtLastName.Text;
                    emp.Telefon = txtPhoneNumber.Text;
                    emp.RodzajUmowy = txtContractType.Text;
                   
                    emp.ID_stanowiska = (int?)cbPosition.SelectedValue;
                    emp.ID_adresu = (int?)cbAddress.SelectedValue;


                    if (!int.TryParse(txtYearsOfExperience.Text, out int lataDosw) || lataDosw < 0)
                    {
                        MessageBox.Show("Lata doświadczenia muszą być liczbą nieujemną (0–45)");
                        return;
                    }
                    emp.LataDoswiadczenia = lataDosw;

                    // Modyfikujemy produkt przypisany do stanowiska, jeśli to piekarz/cukiernik
                    var stanowisko = context.Stanowisko.Find(emp.ID_stanowiska);
                    if (stanowisko != null)
                    {
                        var nazwa = stanowisko.NazwaStanowiska?.ToLower();
                        if ((nazwa == "piekarz" || nazwa == "cukiernik") && cbProduct.SelectedIndex != -1)
                        {
                            int produktId = (int)cbProduct.SelectedValue;
                            stanowisko.ID_produktu = produktId;
                            context.Entry(stanowisko).State = EntityState.Modified;
                        }
                    }

                    context.SaveChanges();
                    MessageBox.Show("Zapisano zmiany.");
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Nie znaleziono pracownika.");
                }

            }
            

        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            // Limit 9 cyfr
            var textBox = sender as TextBox;
            if (!char.IsControl(e.KeyChar) && textBox.Text.Length >= 9)
            {
                e.Handled = true;
            }
        }

    }
}