using System;
using System.Linq;
using System.Windows.Forms;
using Bakery_Schedule.modele;
using Microsoft.EntityFrameworkCore;



namespace Bakery_Schedule
{
    public partial class AddEmployeeForm : Form
    {
        public AddEmployeeForm()
        {
            InitializeComponent();

            CbStanowisko_SelectedIndexChanged(null, null);
            cbStanowisko.SelectedIndexChanged += CbStanowisko_SelectedIndexChanged;

            LoadStanowiska();
            LoadAdresy();
            LoadProdukty();
        
        }

        private void CbStanowisko_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbStanowisko.SelectedItem == null)
            {
                cbProdukt.Enabled = false;
                return;
            }

            // Pobierz nazwê stanowiska z aktualnie wybranego elementu
            var stanowisko = cbStanowisko.SelectedItem as Stanowisko;
            if (stanowisko == null)
            {
                cbProdukt.Enabled = false;
                return;
            }

            // SprawdŸ czy nazwa stanowiska to "piekarz" lub "cukiernik" (ignoruj¹c wielkoœæ liter)
            var nazwa = stanowisko.NazwaStanowiska?.ToLower();

            if (nazwa == "piekarz" || nazwa == "cukiernik")
            {
                cbProdukt.Enabled = true;
            }
            else
            {
                cbProdukt.Enabled = false;
                
            }
        }

        private void LoadProdukty()
        {
            using (var context = new AppDbContext())
            {
                var produkty = context.Produkt
                    .Select(p => new { p.ID_produktu, p.Nazwa })
                    .ToList();

                cbProdukt.DataSource = produkty;
                cbProdukt.DisplayMember = "Nazwa";
                cbProdukt.ValueMember = "ID_produktu";
            }
        }

        private void LoadStanowiska()
        {
            using (var context = new AppDbContext())
            {
                var stanowiska = context.Stanowisko.ToList();
                cbStanowisko.DataSource = stanowiska;
                cbStanowisko.DisplayMember = "NazwaStanowiska";
                cbStanowisko.ValueMember = "ID_stanowiska";
            }
        }

        private void LoadAdresy()
        {
            using (var context = new AppDbContext())
            {
                var adresy = context.Adres.ToList();
                cbAdres.DataSource = adresy;
                cbAdres.DisplayMember = "PelnyAdres"; 
                cbAdres.ValueMember = "ID_adresu";
            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbImie.Text) ||
                string.IsNullOrWhiteSpace(tbNazwisko.Text) ||
                string.IsNullOrWhiteSpace(tbTelefon.Text) ||
                cbRodzajUmowy.SelectedItem == null ||
                !int.TryParse(tbLataDoswiadczenia.Text, out int lata) ||
                cbStanowisko.SelectedItem == null ||
                cbAdres.SelectedItem == null)
            {
                MessageBox.Show("Uzupe³nij poprawnie wszystkie pola.");
                return;
            }

            using (var context = new AppDbContext())
            {
                var stanowiskoId = (int)cbStanowisko.SelectedValue;

                var pracownik = new Pracownik
                {
                    Imie = tbImie.Text,
                    Nazwisko = tbNazwisko.Text,
                    Telefon = tbTelefon.Text,
                    RodzajUmowy = cbRodzajUmowy.SelectedItem.ToString(),
                    LataDoswiadczenia = lata,
                    ID_stanowiska = stanowiskoId,
                    ID_adresu = (int)cbAdres.SelectedValue
                };

                context.Pracownik.Add(pracownik);

                
                var stanowisko = context.Stanowisko.Find(stanowiskoId);
                if (stanowisko != null)
                {
                    var nazwa = stanowisko.NazwaStanowiska?.ToLower();
                    if ((nazwa == "piekarz" || nazwa == "cukiernik") && cbProdukt.SelectedIndex != -1)
                    {
                        int produktId = (int)cbProdukt.SelectedValue;
                        stanowisko.ID_produktu = produktId;
                        context.Entry(stanowisko).State = EntityState.Modified;
                    }
                }

                context.SaveChanges();
            }

            MessageBox.Show("Pracownik zosta³ dodany.");
            this.Close();
        }

    }
}
