using Bakery_Schedule.modele;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bakery_Schedule
{
    public partial class ScheduleForm : Form
    {
        public ScheduleForm()
        {
            InitializeComponent();
        }
        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            // Ustaw kolumny DataGridView
            dgvSchedule.Columns.Clear();
            dgvSchedule.Columns.Add("ID_zmiany", "ID Zmiany");
            dgvSchedule.Columns.Add("Data", "Data");
            dgvSchedule.Columns.Add("PoczatekZmiany", "Początek zmiany");
            dgvSchedule.Columns.Add("KoniecZmiany", "Koniec zmiany");
            dgvSchedule.Columns.Add("Imie", "Imię");
            dgvSchedule.Columns.Add("Nazwisko", "Nazwisko");
            dgvSchedule.Columns.Add("id_pracownika", "ID Pracownika");

            // Załaduj pracowników do combo boxa
            using (var db = new AppDbContext())
            {
                var employees = db.Pracownik.ToList();
                cbEmployee.DataSource = employees;
                cbEmployee.DisplayMember = "DisplayName"; // zakładam, że masz to w klasie Pracownik
                cbEmployee.ValueMember = "ID_pracownika";
            }

            // Załaduj zmiany z bazy do dgvSchedule
            using (var db = new AppDbContext())
            {
                // Załaduj wszystkie zmiany, możesz dołączyć pracownika, jeśli chcesz:
                var changes = db.Zmiana.ToList();

                dgvSchedule.Rows.Clear();

                foreach (var zmiana in changes)
                {
                    dgvSchedule.Rows.Add(
                        zmiana.ID_zmiany,
                        zmiana.Data.ToShortDateString(),
                        zmiana.PoczatekZmiany.ToString(@"hh\:mm"),
                        zmiana.KoniecZmiany.ToString(@"hh\:mm"),
                        zmiana.Imie,
                        zmiana.Nazwisko,
                        zmiana.ID_pracownika
                    );
                }
            }
        }

        public void LoadSchedule()
        {
            using (var db = new AppDbContext())
            {
                var changes = db.Zmiana.ToList();

                dgvSchedule.Rows.Clear();

                foreach (var zmiana in changes)
                {
                    dgvSchedule.Rows.Add(
                        zmiana.ID_zmiany,
                        zmiana.Data.ToShortDateString(),
                        zmiana.PoczatekZmiany.ToString(@"hh\:mm"),
                        zmiana.KoniecZmiany.ToString(@"hh\:mm"),
                        zmiana.Imie,
                        zmiana.Nazwisko,
                        zmiana.ID_pracownika
                    );
                }
            }
        }
        private void btnAddShift_Click(object sender, EventArgs e)
        {
            if (cbEmployee.SelectedItem is Pracownik selectedEmployee)
            {
                using (var db = new AppDbContext())
                {
                    // Znajdź pracownika w bazie po ID (jeśli masz ID w cbEmployee)
                    var pracownik = db.Pracownik.Find(selectedEmployee.ID_pracownika);
                    if (pracownik == null)
                    {
                        MessageBox.Show("Wybrany pracownik nie istnieje w bazie.");
                        return;
                    }

                    var zmiana = new modele.Zmiana
                    {
                        Data = dtpDate.Value.Date,
                        PoczatekZmiany = dtpStart.Value.TimeOfDay,
                        KoniecZmiany = dtpEnd.Value.TimeOfDay,
                        ID_pracownika = pracownik.ID_pracownika,
                        Imie = pracownik.Imie,
                        Nazwisko = pracownik.Nazwisko,
                        Pracownik = pracownik
                    };

                    db.Zmiana.Add(zmiana);
                    db.SaveChanges();

                    // Dodaj do DataGridView nowy wiersz z danymi zmiany (wraz z ID_zmiany z bazy)
                    dgvSchedule.Rows.Add(
                        zmiana.ID_zmiany,
                        zmiana.Data.ToShortDateString(),
                        zmiana.PoczatekZmiany.ToString(@"hh\:mm"),
                        zmiana.KoniecZmiany.ToString(@"hh\:mm"),
                        zmiana.Imie,
                        zmiana.Nazwisko,
                        zmiana.ID_pracownika
                    );
                }
            }
            else
            {
                MessageBox.Show("Wybierz pracownika.");
            }
        }
        private void btnEditShift_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz zmianę do edycji.");
                return;
            }

            var selectedRow = dgvSchedule.SelectedRows[0];
            if (!int.TryParse(selectedRow.Cells["ID_zmiany"].Value?.ToString(), out int idZmiany))
            {
                MessageBox.Show("Nieprawidłowy ID zmiany.");
                return;
            }

            using (var editForm = new EditScheduleForm(idZmiany))
            {
                var result = editForm.ShowDialog();
                if (result == DialogResult.OK)
                {
                    LoadSchedule(); // metoda do załadowania danych do dgvSchedule, którą możesz wywołać ponownie
                }
            }
        }

        private void btnDeleteShift_Click(object sender, EventArgs e)
        {
            if (dgvSchedule.SelectedRows.Count == 0)
            {
                MessageBox.Show("Wybierz wiersz do usunięcia.");
                return;
            }

            var selectedRow = dgvSchedule.SelectedRows[0];

            if (!int.TryParse(selectedRow.Cells["ID_zmiany"].Value?.ToString(), out int idZmiany))
            {
                MessageBox.Show("Nieprawidłowy ID zmiany.");
                return;
            }

            var confirmResult = MessageBox.Show("Czy na pewno chcesz usunąć tę zmianę?",
                                                "Potwierdzenie usunięcia",
                                                MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                using (var db = new AppDbContext())
                {
                    var zmiana = db.Zmiana.Find(idZmiany);
                    if (zmiana == null)
                    {
                        MessageBox.Show("Zmiana nie znaleziona w bazie.");
                        return;
                    }

                    db.Zmiana.Remove(zmiana);
                    db.SaveChanges();
                }

                // Usuń wiersz z DataGridView
                dgvSchedule.Rows.Remove(selectedRow);

                MessageBox.Show("Zmiana została usunięta.");
            }
        }

        private void btnGoEmployee_Click(object sender, EventArgs e) // Obsługa kliknięcia guzika
        {
            EmployeeForm employeeForm = new EmployeeForm(); // Załóżmy, że masz taki formularz
            employeeForm.Show(); // Otwórz EmployeeForm
        }

   
    }
}