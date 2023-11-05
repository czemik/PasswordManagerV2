using Microsoft.EntityFrameworkCore;
using PassMan.Core.Models;
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
            modelBuilder.Entity<Vault>()
               .HasOne(el => el.user)
               .WithMany()
               .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
        }

        public bool registerUser(User user)
        {
            this.Users.Add(user);


            return true;
        }
    }
}
