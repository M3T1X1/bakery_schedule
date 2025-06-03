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
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            using (var context = new AppDbContext())
            {
                // Załaduj stanowiska
                cbPosition.DataSource = context.Stanowisko.ToList();
                cbPosition.DisplayMember = "NazwaStanowiska";
                cbPosition.ValueMember = "ID_stanowiska";

                // Załaduj produkty (opcjonalnie, jeśli chcesz mieć w formularzu)
                cbProduct.DataSource = context.Produkt.ToList();
                cbProduct.DisplayMember = "Nazwa";
                cbProduct.ValueMember = "ID_produktu";

                // Załaduj listę ID adresów
                cbAddress.DataSource = context.Adres.ToList();
                cbAddress.DisplayMember = "PelnyAdres";
                cbAddress.ValueMember = "ID_adresu";
                // Załaduj dane pracownika
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
                    nudYearsOfExperience.Value = emp.LataDoswiadczenia;

                    cbPosition.SelectedValue = emp.ID_stanowiska ?? -1;
                    cbAddress.SelectedValue = emp.ID_adresu;
                    // Jeśli chcesz ustawić produkt (np. powiązany ze stanowiskiem):
                    if (emp.Stanowisko?.ID_produktu != null)
                    {
                        cbProduct.SelectedValue = emp.Stanowisko.ID_produktu.Value;
                    }
                }
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
                    emp.LataDoswiadczenia = (int)nudYearsOfExperience.Value;
                    emp.ID_stanowiska = (int?)cbPosition.SelectedValue;
                    emp.ID_adresu = (int?)cbAddress.SelectedValue;

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