using Bakery_Schedule.Data;
using Microsoft.EntityFrameworkCore;

namespace Bakery_Schedule
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            var options = new DbContextOptionsBuilder<AppDbContext>()
                .UseSqlite("Data Source=C:\\Users\\dusza\\Desktop\\bakery_schedule\\baza\\baza.db") // lub inna baza
                .Options;

            using var context = new AppDbContext();
            SeedData.Initialize(context);


            ApplicationConfiguration.Initialize();
            Application.Run(new ScheduleForm());
        }
    }
}
