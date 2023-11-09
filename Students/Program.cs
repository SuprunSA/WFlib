using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Students.BL;
using Students.BL.Configuration;
using Students.BL.Repo;
using Students.BL.Services;

namespace Students
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();

            ServiceCollection services = new();
            services.ConfigureServices();

            using var scope = services.BuildServiceProvider();
            {
                Application.Run(scope.GetRequiredService<Form1>());
            }
        }

        private static void ConfigureServices(this ServiceCollection services)
        {
            services.AddSingleton<StudentsRepo>();
            services.AddSingleton<StudentService>();
            services.AddSingleton<Form1>();
            services.AddDbContext<StudentDBContext>(options => options.UseSqlServer(new ConnectionStringConfig().ConnectionString));
        }
    }
}