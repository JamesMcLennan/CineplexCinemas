using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineplexCinemas.Models
{
    public partial class Booking
    {
        public int BookingId { get; set; }
        public int MovieId { get; set; }
        public int SessionId { get; set; }
        public virtual Session Session { get; set; }
        public virtual Movie Movie { get; set; }
    }
}
