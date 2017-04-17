using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cineplex.Models
{
    public partial class CineplexSite
    {
        public CineplexSite()
        {
            CineplexMovie = new HashSet<CineplexMovie>();
        }

        [Key]
        public int CineplexId { get; set; }
        public string Location { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }

        public virtual ICollection<CineplexMovie> CineplexMovie { get; set; }
    }
}
