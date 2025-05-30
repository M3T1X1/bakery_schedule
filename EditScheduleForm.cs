using Bakery_Schedule.modele;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bakery_Schedule
{
    public partial class EditScheduleForm : Form
    {
        private int _idZmiany;

        public EditScheduleForm(int idZmiany)
        {
            InitializeComponent();
            _idZmiany = idZmiany;
            LoadSchedule(_idZmiany);
        }

        private void LoadSchedule(int id)
        {
            using (var db = new AppDbContext())
            {
                var zmiana = db.Zmiana.Find(id);
                if (zmiana == null)
                {
                    MessageBox.Show("Nie znaleziono zmiany o podanym ID.");
                    this.Close();
                    return;
                }

                dtpData.Value = zmiana.Data;
                dtpPoczatek.Value = DateTime.Today + zmiana.PoczatekZmiany;
                dtpKoniec.Value = DateTime.Today + zmiana.KoniecZmiany;
            }
        }

        private void EditScheduleForm_Load(object sender, EventArgs e)
        {
            // Załaduj listę pracowników do cbEmployee
            using (var db = new AppDbContext())
            {
                var employees = db.Pracownik.ToList();
                cbEmployee.DataSource = employees;
                cbEmployee.DisplayMember = "DisplayName"; 
                cbEmployee.ValueMember = "ID_pracownika";

                var zmiana = db.Zmiana.Find(_idZmiany);
                if (zmiana == null)
                {
                    MessageBox.Show("Nie znaleziono zmiany.");
                    Close();
                    return;
                }

                dtpData.Value = zmiana.Data;
                dtpPoczatek.Value = DateTime.Today + zmiana.PoczatekZmiany;
                dtpKoniec.Value = DateTime.Today + zmiana.KoniecZmiany;

                if (zmiana.PracownikID_pracownika.HasValue)
                    cbEmployee.SelectedValue = zmiana.PracownikID_pracownika.Value;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            using (var db = new AppDbContext())
            {
                var zmiana = db.Zmiana.Find(_idZmiany);
                if (zmiana == null)
                {
                    MessageBox.Show("Nie znaleziono zmiany.");
                    DialogResult = DialogResult.Cancel;
                    return;
                }

                zmiana.Data = dtpData.Value.Date;
                zmiana.PoczatekZmiany = dtpPoczatek.Value.TimeOfDay;
                zmiana.KoniecZmiany = dtpKoniec.Value.TimeOfDay;

                if (cbEmployee.SelectedItem is Pracownik selectedEmployee)
                {
                    zmiana.PracownikID_pracownika = selectedEmployee.ID_pracownika;
                    zmiana.Imie = selectedEmployee.Imie;
                    zmiana.Nazwisko = selectedEmployee.Nazwisko;
                }

                db.SaveChanges();
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }

}
