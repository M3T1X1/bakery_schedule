using Bakery_Schedule.Data;
using Microsoft.EntityFrameworkCore;

namespace Bakery_Schedule
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            //var options = new DbContextOptionsBuilder<AppDbContext>()
                //.UseSqlite("Data Source=C:\\Users\\kd300\\source\\repos\\M3T1X1\\bakery_schedule\\baza\\baza.db")
                //.UseSqlite("Data Source=baza\\baza.db")
                //.Options;

            using var context = new AppDbContext();
            SeedData.Initialize(context);


            ApplicationConfiguration.Initialize();
            Application.Run(new ScheduleForm());
        }
    }
}
