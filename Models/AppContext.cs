using a101_backend.Models.DataBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace a101_backend.Models
{
    public class AppContext : DbContext
    {
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Company> Company { get; set; }
        public virtual DbSet<PartnerInfo> PartnerInfo { get; set; }
        public virtual DbSet<City> City { get; set; }
        public virtual DbSet<Document> Document { get; set; }
        public virtual DbSet<CompanyStatus> CompanyStatuse { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // DESKTOP-4ELF06P
            // TVK49
            IConfigurationRoot configuration = new ConfigurationBuilder()
            .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
            .AddJsonFile("appsettings.json")
            .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("prod_db"));
        }
    }
}
