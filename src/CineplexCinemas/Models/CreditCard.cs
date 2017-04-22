using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace CineplexCinemas.Models
{
    public class CreditCard
    {
        [RegularExpression("^([a-zA-z,.-]+)$")Required(ErrorMessage = "Invalid Name")]
        public string CardHolder { get; set; }

        [RegularExpression("^([a-zA-z,.-]+)$")Required(ErrorMessage = "Invalid Name")]
        public string CardNumber { get; set; }

        [RegularExpression("^([a-zA-z,.-]+)$")Required(ErrorMessage = "Invalid Name")]
        public string CVC { get; set; }

        [RegularExpression("^([a-zA-z,.-]+)$")Required(ErrorMessage = "Invalid Name")]
        public string ExpiryDate { get; set; }






    }
}
