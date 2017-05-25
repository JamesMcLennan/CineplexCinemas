using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineplexCinemas.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int numberOfAdults { get; set; }
        public int numberOfConc { get; set; }
        public string customerName { get; set; }
        public CineplexMovie SessionDetails { get; set; }
    }
}
