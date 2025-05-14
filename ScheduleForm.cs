using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Bakery_Schedule
{
    public partial class ScheduleForm : Form
    {
        private List<string> employees = new List<string> { "Jan Kowalski", "Anna Nowak", "Piotr Malinowski" };

        public ScheduleForm()
        {
            InitializeComponent();
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            cbEmployee.DataSource = employees;
            dgvSchedule.Columns.Add("Employee", "Pracownik");
            dgvSchedule.Columns.Add("Date", "Data");
            dgvSchedule.Columns.Add("Start", "Początek zmiany");
            dgvSchedule.Columns.Add("End", "Koniec zmiany");
        }

        private void btnAddShift_Click(object sender, EventArgs e)
        {
            string employee = cbEmployee.SelectedItem.ToString();
            string date = dtpDate.Value.ToShortDateString();
            string start = dtpStart.Value.ToShortTimeString();
            string end = dtpEnd.Value.ToShortTimeString();

            dgvSchedule.Rows.Add(employee, date, start, end);
        }
    }
}
