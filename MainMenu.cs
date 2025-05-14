namespace Bakery_Schedule
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
            labelClock.Text = DateTime.Now.ToLongTimeString();
            timerClock.Start(); 
        }
        private void buttonSchedule_Click(object sender, EventArgs e)
        {
            ScheduleForm scheduleForm = new ScheduleForm();
            scheduleForm.Show();
        }

        private void buttonEmployees_Click(object sender, EventArgs e)
        {
            EmployeeForm employeeForm = new EmployeeForm();
            employeeForm.Show();
        }
        private void timerClock_Tick(object sender, EventArgs e)
        {
            labelClock.Text = DateTime.Now.ToLongTimeString();
        }
    }
}
