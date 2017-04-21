using System;
using System.Collections.Generic;

namespace CineplexCinemas.Models
{
    public partial class CineplexMovie
    {
        public int CineplexId { get; set; }
        public int MovieId { get; set; }

        public virtual Cineplex Cineplex { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
