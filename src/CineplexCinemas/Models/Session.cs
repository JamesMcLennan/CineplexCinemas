using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CineplexCinemas.Models
{
    public partial class Session
    {
        public int SessionId { get; set; }
        public DateTime SessionDate { get; set; }
        public DateTime SessionTime { get; set; }
        public int SeatsAvailable { get; set; }
        public int SeatsTotal { get; set; }
        public Movie film { get; set; }
    }
}
