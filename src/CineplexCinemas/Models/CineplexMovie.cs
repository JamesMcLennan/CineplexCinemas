using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cineplex.Models
{
    public partial class CineplexMovie
    {
        [Key]
        public int CineplexId { get; set; }
        public int MovieId { get; set; }

        public virtual CineplexSite CineplexCinema { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
