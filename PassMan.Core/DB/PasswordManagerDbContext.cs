using Microsoft.EntityFrameworkCore;
using PassMan.Core.Models;
using System.Diagnostics;
using System.Reflection.Metadata;

namespace PassMan.Core.DB
{
    public class PasswordManagerDbContext: DbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Vault> Vault { get; set; }

        public PasswordManagerDbContext() : base() { }

        public PasswordManagerDbContext(DbContextOptions options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public bool registerUser(User user)
        {
            this.Users.Add(user);
            this.SaveChanges();

            return true;
        }

        public bool loginUser(string username, string password)
        {
            var user = this.Users.ToList<User>().Find(x => x.Username == username);
            if (user != null && Encrypter.Decrypt(user.Email, user.Password) == password)
            {
                User.LoggedInUser = user;
                return true;
            }
            return false;
        }

        public bool addVault(Vault vault)
        {
            this.Vault.Add(vault);
            this.SaveChanges();
            return true;
        }

        public bool deleteVault(Vault vault)
        {
            var item = this.Vault.Find(vault.Id);
            this.Vault.Remove(item);
            this.SaveChanges();
            return true;
        }
    }
}
