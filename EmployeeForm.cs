using System;
using System.Windows.Forms;

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
            dataGridView1.DataSource = GetEmployees();
        }

        private object GetEmployees()
        {
            return new[]
            {
                new { Id = 0, Name = "Jan Kowalski"},
                new { Id = 1, Name = "Anna Nowak"}
            };
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Dodaj pracownika!");
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Edytuj wybranego pracownika!");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Usuń wybranego pracownika!");
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Zapisz zmiany!");
        }
    }
}
