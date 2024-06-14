using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Web;
using WCF_service_application.Models;

namespace WCF_service_application.Data
{
    public class WCFDbContext : DbContext
    {
        public DbSet<UserModel> UserModel { get; set; } = null;

        public WCFDbContext()
        {
            try
            {
                Database.EnsureCreated();
            }
            catch
            {

            }
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=db2;Username=postgres;Password=1111");
        }
    }
}