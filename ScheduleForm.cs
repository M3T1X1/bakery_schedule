using Bakery_Schedule.modele;
using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Microsoft.EntityFrameworkCore;

namespace Bakery_Schedule
{
    public partial class ScheduleForm : Form
    {
        private int pageSize = 2;
        private int totalRecords = 0;
        private int maxSliderValue = 1;
        private List<Zmiana> allChanges = new();
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


            LoadSchedule();



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
                allChanges = db.Zmiana
                 .Where(z => true) // dowolny warunek jeśli potrzebujesz filtrować
                 .ToList() // pobierz do pamięci, od teraz LINQ działa w C#
                 .OrderBy(z => z.Data)
                 .ThenBy(z => z.PoczatekZmiany)
                 .ToList();

                totalRecords = allChanges.Count;
                maxSliderValue = Math.Max(1, totalRecords - pageSize + 1);
                trackBarScroll.Maximum = maxSliderValue;
                trackBarScroll.Value = 1;

                DisplayRecords(0);
            }
        }
        private void TrackBarScroll_Scroll(object sender, EventArgs e)
        {
            int startIndex = trackBarScroll.Value - 1;
            DisplayRecords(startIndex);
        }
        private void DisplayRecords(int startIndex)
        {
            dgvSchedule.Rows.Clear();

            var selected = allChanges
                .Skip(startIndex)
                .Take(pageSize)
                .ToList();

            foreach (var zmiana in selected)
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
        private void btnAddShift_Click(object sender, EventArgs e)
        {
            if (cbEmployee.SelectedItem is Pracownik selectedEmployee)
            {
                using (var db = new AppDbContext())
                {
                    try
                    {
                        var pracownik = db.Pracownik.Find(selectedEmployee.ID_pracownika);
                        if (pracownik == null)
                        {
                            MessageBox.Show("Wybrany pracownik nie istnieje w bazie.");
                            return;
                        }

                        DateTime selectedDate = dtpDate.Value.Date;
                        TimeSpan selectedStart = dtpStart.Value.TimeOfDay;
                        TimeSpan selectedEnd = dtpEnd.Value.TimeOfDay;

                        if (selectedStart >= selectedEnd)
                        {
                            MessageBox.Show("Godzina początku zmiany musi być wcześniejsza niż koniec zmiany.");
                            return;
                        }

                        // Sprawdzenie konfliktu z innymi zmianami pracownika tego dnia
                        var dzienneZmiany = db.Zmiana
                          .Where(z => z.ID_pracownika == pracownik.ID_pracownika && z.Data == selectedDate)
                          .ToList(); // Przenosimy dane do pamięci, by móc użyć TimeSpan

                        bool conflictExists = dzienneZmiany.Any(z =>
                            selectedStart < z.KoniecZmiany &&
                            z.PoczatekZmiany < selectedEnd
                                                );

                        if (conflictExists)
                        {
                            MessageBox.Show("Pracownik ma już inną zmianę, która pokrywa się z podanymi godzinami!", "Konflikt zmian", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        var zmiana = new modele.Zmiana
                        {
                            Data = selectedDate,
                            PoczatekZmiany = selectedStart,
                            KoniecZmiany = selectedEnd,
                            ID_pracownika = pracownik.ID_pracownika,
                            Imie = pracownik.Imie,
                            Nazwisko = pracownik.Nazwisko
                        };

                        db.Zmiana.Add(zmiana);
                        int result = db.SaveChanges();

                        if (result > 0)
                        {
                            MessageBox.Show("Zmiana dodana do bazy!");
                        }
                        else
                        {
                            MessageBox.Show("Nie dodano żadnego rekordu.");
                        }

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
                    catch (Exception ex)
                    {
                        MessageBox.Show("Błąd podczas zapisu: " + ex.Message);
                    }
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