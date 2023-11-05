using Microsoft.EntityFrameworkCore;
using System.Configuration;
using System.Diagnostics;
using PassMan.Core.Utils;
using PassMan.Core.DB;
using PassMan.Core.Models;
using Mobiles.Desktop.Views;

namespace PassMan.Desktop
{
    internal static class Program
    {
        internal static User ?loggedInUser;

        internal static string GetConnectionName() => ConfigurationManager.AppSettings["Connection"]
                ?? throw new KeyNotFoundException($"Application setting 'Connection' not found.");

        internal static string GetConnectionString(string? connection = null) => ConfigurationManager.ConnectionStrings[connection ?? GetConnectionName()].ConnectionString
                ?? throw new KeyNotFoundException($"Connection string '{connection}' not found.");

        internal static PasswordManagerDbContext GetDbContext()
        {
            string connectionStringConfig = PathUtils.ResolveVirtual(GetConnectionString());
            string connectionString = $"Data Source={connectionStringConfig};";
            var optionsBuilder = new DbContextOptionsBuilder<PasswordManagerDbContext>().UseSqlite(connectionString);
            return new PasswordManagerDbContext(optionsBuilder.Options);
        }

        internal static void InitDb()
        {
            string appConnectionConfig = GetConnectionName();

            string connectionStringConfig = GetConnectionString(appConnectionConfig);
            connectionStringConfig = PathUtils.ResolveVirtual(connectionStringConfig);
            string? dirname = Directory.GetParent(connectionStringConfig)?.FullName;
            if (dirname != null && !Directory.Exists(dirname))
            {
                Directory.CreateDirectory(dirname);
            }

            using var context = Program.GetDbContext();
            bool created = context.Database.EnsureCreated();
            Debug.WriteLine(created ? "Initialized database." : "Database already created.");
        }

        [STAThread]
        static void Main()
        {
            InitDb();
            ApplicationConfiguration.Initialize();
            Application.Run(new MainForm());
        }
    }
}