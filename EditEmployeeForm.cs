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
            cbStanowisko.SelectedIndexChanged += CbStanowisko_SelectedIndexChanged;
            tbLataDoswiadczenia.KeyPress += txtYearsOfExperience_KeyPress;
            tbLataDoswiadczenia.Validating += txtYearsOfExperience_Validating;
            tbTelefon.KeyPress += txtPhoneNumber_KeyPress;
        }

        private void EditEmployeeForm_Load(object sender, EventArgs e)
        {
            using var context = new AppDbContext();

            
            cbStanowisko.DataSource = context.Stanowisko.ToList();
            cbStanowisko.DisplayMember = "NazwaStanowiska";
            cbStanowisko.ValueMember = "ID_stanowiska";

            cbProduct.DataSource = context.Produkt.ToList();
            cbProduct.DisplayMember = "Nazwa";
            cbProduct.ValueMember = "ID_produktu";

            cbAdres.DataSource = context.Adres.ToList();
            cbAdres.DisplayMember = "PelnyAdres";
            cbAdres.ValueMember = "ID_adresu";

            var emp = context.Pracownik
                .Include(p => p.Stanowisko)
                .Include(p => p.Adres)
                .FirstOrDefault(p => p.ID_pracownika == employeeId);

            if (emp != null)
            {
                tbImie.Text = emp.Imie;
                tbNazwisko.Text = emp.Nazwisko;
                tbTelefon.Text = emp.Telefon;
                cbRodzajUmowy.Text = emp.RodzajUmowy;
                tbLataDoswiadczenia.Text = emp.LataDoswiadczenia.ToString();

                cbStanowisko.SelectedValue = emp.ID_stanowiska ?? -1;
                cbAdres.SelectedValue = emp.ID_adresu;

                if (emp.ID_produktu.HasValue && cbProduct.Items.Count > 0)
                {
                    cbProduct.SelectedValue = emp.ID_produktu.Value;
                }
                else
                {
                    cbProduct.SelectedIndex = -1; 
                }

                // Ustawienie stanu cbProduct w zależności od stanowiska
                CbStanowisko_SelectedIndexChanged(null, null);
            }
        }

        private void CbStanowisko_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStanowisko.SelectedItem is not Stanowisko stanowisko)
            {
                cbProduct.Enabled = false;
                return;
            }

            var nazwa = stanowisko.NazwaStanowiska?.ToLower();
            cbProduct.Enabled = nazwa == "piekarz" || nazwa == "cukiernik";
        }

        private void txtYearsOfExperience_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txtYearsOfExperience_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if(int.TryParse(tbLataDoswiadczenia.Text, out int value))
            {
                if(value > 45)
                {
                    MessageBox.Show("Lata doświadczenia nie mogą być większe niż 45.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    e.Cancel = true;
                }
            }
            else if(!string.IsNullOrEmpty(tbLataDoswiadczenia.Text))
            {
                MessageBox.Show("Proszę wpisać poprawną liczbę.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Cancel = true;
            }
        }

        private void txtPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            if(!char.IsControl(e.KeyChar) && tbTelefon.Text.Length >= 9)
                e.Handled = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(tbImie.Text) ||
                string.IsNullOrWhiteSpace(tbNazwisko.Text) ||
                string.IsNullOrWhiteSpace(tbTelefon.Text) ||
                cbRodzajUmowy.SelectedItem == null ||
                !int.TryParse(tbLataDoswiadczenia.Text, out int lata) ||
                cbStanowisko.SelectedItem == null ||
                cbAdres.SelectedItem == null ||
                tbImie.Text.Any(char.IsDigit) ||
                tbNazwisko.Text.Any(char.IsDigit) ||
                tbTelefon.Text.Length != 9 ||
                !tbTelefon.Text.All(char.IsDigit))
            {
                MessageBox.Show("Uzupełnij poprawnie wszystkie pola.");
                return;
            }

            using var context = new AppDbContext();
            var emp = context.Pracownik.Find(employeeId);

            if(emp != null)
            {
                emp.Imie = tbImie.Text;
                emp.Nazwisko = tbNazwisko.Text;
                emp.Telefon = tbTelefon.Text;
                emp.RodzajUmowy = cbRodzajUmowy.Text;
                emp.ID_stanowiska = (int?)cbStanowisko.SelectedValue;
                emp.ID_adresu = (int?)cbAdres.SelectedValue;
                emp.LataDoswiadczenia = lata;

                // Produkt przypisujemy tylko dla piekarza/cukiernik
                var stanowisko = context.Stanowisko.Find(emp.ID_stanowiska);
                if(stanowisko != null)
                {
                    var nazwa = stanowisko.NazwaStanowiska?.ToLower();
                    if ((nazwa == "piekarz" || nazwa == "cukiernik") && cbProduct.SelectedIndex != -1)
                        emp.ID_produktu = (int?)cbProduct.SelectedValue;
                    else
                        emp.ID_produktu = null;
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
}
