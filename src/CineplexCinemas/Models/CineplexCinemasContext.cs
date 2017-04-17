using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Cineplex.Models;

namespace CineplexCinemas.Models
{
    public class CineplexCinemasContext : DbContext
    {
        public CineplexCinemasContext (DbContextOptions<CineplexCinemasContext> options)
            : base(options)
        {
        }
        public DbSet<Enquiry> Enquiry { get; set; }
        public DbSet<Movie> Movie { get; set; }
        public DbSet<CineplexMovie> CineplexMovie { get; set; }
        public DbSet<CineplexSite> CineplexSite { get; set; }
        public DbSet<MovieComingSoon> MovieComingSoon { get; set; }
    }
}
