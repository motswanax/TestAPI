using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using TestAPI.Models;

namespace TestAPI.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Bank> Banks { get; set; }
        public DbSet<Country> Countries { get; set; }
        public DbSet<Branch> Branches { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Country>()
                .Property(x => x.Id)
                .ValueGeneratedOnAdd();

            modelBuilder.Entity<Country>()
                .HasData(new Country
                {
                    Id = 1,
                    Name = "Botswana",
                    CountryCode = "BW",
                });

            modelBuilder.Entity<Bank>()
                .HasData(new Bank
                {
                    Id = 1,
                    CountryId = 1,
                    Name = "Absa Bank",
                    Address = "Plot 123 Broadhurst"
                });

            modelBuilder.Entity<Branch>()
                .HasData(new Branch
                {
                    Id = 1,
                    BankId = 1,
                    Name = "Broadhurst"
                });

            /*modelBuilder.Entity<Country>()
                .HasData(new Country
                {
                    Id = 1,
                    Name = "Botswana",
                    CountryCode = "BW",
                    Banks = new List<Bank>() { new Bank
                    {
                        Name = "Absa",
                        Address = "Plot 121 Gaborone",
                        CountryId = 1,
                        Branches = new List<Branch>() {new Branch
                        {
                            Name = "Broadhurst Branch",
                            BankId = 1,
                        } }
                    } }
                });*/

            base.OnModelCreating(modelBuilder);
        }
    }
}
