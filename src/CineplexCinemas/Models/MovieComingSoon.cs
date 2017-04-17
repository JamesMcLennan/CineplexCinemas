using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cineplex.Models
{
    public partial class MovieComingSoon
    {
        [Key]
        public int MovieComingSoonId { get; set; }
        public string Title { get; set; }
        public string ShortDescription { get; set; }
        public string LongDescription { get; set; }
        public string ImageUrl { get; set; }
    }
}
