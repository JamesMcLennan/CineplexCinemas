using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineplexCinemas.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public CineplexMovie SessionDetails { get; set; }
    }
}
