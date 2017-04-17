﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cineplex.Models
{
    public partial class Movie
    {
        public Movie()
        {
            CineplexMovie = new HashSet<CineplexMovie>();
        }

        [Key]
        public int MovieId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }

        public virtual ICollection<CineplexMovie> CineplexMovie { get; set; }
    }
}
