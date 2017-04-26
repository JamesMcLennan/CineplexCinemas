using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CineplexCinemas.Models
{
    public class CreditCard
    {
        //[RegularExpression("^([0-9]{14,19})$")]
        [Required(ErrorMessage = "Invalid number.")]
        public string CardNumber { get; set; }

        [RegularExpression("^([a-zA-z]+)$")]
        [Required(ErrorMessage = "Invalid first name.")]
        public string FirstName { get; set; }

        [RegularExpression("^([a-zA-z]+)$")]
        [Required(ErrorMessage = "Invalid last name.")]
        public string LastName { get; set; }

        [Required(ErrorMessage = "Invalid expiry date.")]
        public string ExpiryDate { get; set; }

        [RegularExpression("^([0-9]{3})$")]
        [Required(ErrorMessage = "Invalid CVC number.")]
        public string CVC { get; set; }
    }
}
