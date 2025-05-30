using System;
using System.Windows.Forms;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Bakery_Schedule.modele;

namespace Bakery_Schedule
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployeeData();
        }

        private void LoadEmployeeData()
        {
            using (var context = new AppDbContext())
            {
                // Najpierw pobieramy dane z bazy (materializacja wyników)
                var pracownicy = context.Pracownik
                    .Include(p => p.Stanowisko)
                        .ThenInclude(s => s.Produkt)
                        .Include(p => p.Adres)
                    .ToList(); // ToList tutaj wymusza pobranie danych do pamięci

                // Następnie projektujemy na listę Employee
                var employees = pracownicy.Select(p => new Employee
                {
                    Id = p.ID_pracownika,
                    FirstName = p.Imie,
                    LastName = p.Nazwisko,
                    PhoneNumber = p.Telefon,
                    ContractType = p.RodzajUmowy,
                    YearsOfExperience = p.LataDoswiadczenia,
                    Position = p.Stanowisko?.NazwaStanowiska,
                    Department = p.Stanowisko?.Produkt?.Nazwa,
                    AddressId = p.ID_adresu
                }).ToList();

                dataGridView1.DataSource = employees;
                dataGridView1.Columns["Id"].HeaderText = "ID";
                dataGridView1.Columns["FirstName"].HeaderText = "Imię";
                dataGridView1.Columns["LastName"].HeaderText = "Nazwisko";
                dataGridView1.Columns["PhoneNumber"].HeaderText = "Telefon";
                dataGridView1.Columns["ContractType"].HeaderText = "Rodzaj umowy";
                dataGridView1.Columns["YearsOfExperience"].HeaderText = "Lata doświadczenia";
                dataGridView1.Columns["Position"].HeaderText = "Stanowisko";
                dataGridView1.Columns["Department"].HeaderText = "Produkt";
                dataGridView1.Columns["AddressId"].HeaderText = "ID Adresu";

                if (dataGridView1.Columns.Contains("DisplayInfo"))
                {
                    dataGridView1.Columns["DisplayInfo"].Visible = false;
                }
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var addForm = new AddEmployeeForm();

            // Gdy zamkniesz formularz, odśwież dane w tabeli
            addForm.FormClosed += (s, args) => LoadEmployeeData();

            addForm.ShowDialog(); // Otwiera okno modalnie
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Wybierz pracownika do edycji.");
                return;
            }

            var selectedEmployee = (Employee)dataGridView1.CurrentRow.DataBoundItem;
            var editForm = new EditEmployeeForm(selectedEmployee.Id);

            editForm.FormClosed += (s, args) => LoadEmployeeData();
            editForm.ShowDialog();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow == null)
            {
                MessageBox.Show("Wybierz pracownika do usunięcia.");
                return;
            }

            var selectedEmployee = (Employee)dataGridView1.CurrentRow.DataBoundItem;

            var result = MessageBox.Show(
                $"Czy na pewno chcesz usunąć pracownika {selectedEmployee.FirstName} {selectedEmployee.LastName}?",
                "Potwierdzenie usunięcia",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                using (var context = new AppDbContext())
                {
                    var pracownik = context.Pracownik
                        .Include(p => p.Zmiany)
                        .FirstOrDefault(p => p.ID_pracownika == selectedEmployee.Id);

                    if (pracownik != null)
                    {
                        if (pracownik.Zmiany.Any())
                        {
                            context.Zmiana.RemoveRange(pracownik.Zmiany);
                        }

                        context.Pracownik.Remove(pracownik);
                        context.SaveChanges();
                        LoadEmployeeData();
                        MessageBox.Show("Usunięto pracownika wraz z powiązanymi zmianami.");
                    }
                    else
                    {
                        MessageBox.Show("Nie znaleziono pracownika w bazie.");
                    }
                }
            }
            else
            {
                // Użytkownik kliknął "Nie", nic się nie dzieje
            }
        }


    }
}
