using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CineplexCinemas.Models
{
    public class Booking
    {
        [RegularExpression("^([a-zA-z,.-]+)$")Required(ErrorMessage = "Invalid Name")]
        public string firstName { get; set; }
        [RegularExpression("^([a-zA-z,.-]+)$")Required(ErrorMessage = "Invalid Name")]
        public string lastName { get; set; }
        [RegularExpression("^([a-zA-z0-9 ,.-]+)$")Required(ErrorMessage = "Invalid Address")]
        public string address { get; set; }
        [RegularExpression("^([a-z0-9_.-]+[@]{1}[a-z0-9]{1,15}[.]{1}[a-z]{2,3}[.]{0,1}[a-z]{0,3})$")Required(ErrorMessage = "Invalid Email")]
        public string email { get; set; }
        [RegularExpression("^(([+]?)([0-9]{3,4})([- ]?)([0-9]{3,4})([- ]?)([0-9]{3,4}))$")Required(ErrorMessage = "Invalid Phone")]
        public string phoneNo { get; set; }
    }
}
