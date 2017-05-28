using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineplexCinemas.Models
{
    public partial class Booking
    {
        public Booking()
        { }
        public Booking(int cineplxId, int movieId, int sessionId)
        {
            this.cineplxId = cineplxId;
            this.movieId = movieId;
            this.sessionId = sessionId;
        }

        public int BookingId { get; set; }
        public int numberOfAdults { get; set; }
        public int numberOfConc { get; set; }
        public string customerName { get; set; }
        public int sessionId { get; set; }
        public int movieId { get; set; }
        public int cineplxId { get; set; }
    }
}
