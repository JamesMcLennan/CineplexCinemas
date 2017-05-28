using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
//add
using Microsoft.EntityFrameworkCore;
using CineplexApi.Models;

namespace CineplexApi.Data
{
    public class CineplexDatabaseContext : DbContext
    {
        public DbSet<Enquiry> Enquiries { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("data source=(localdb)\\mssqllocaldb;initial catalog = cineplexdatabase;integrated security = true");
            //optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["CineplexDatabase"].ConnectionString);
        }
    }
}
