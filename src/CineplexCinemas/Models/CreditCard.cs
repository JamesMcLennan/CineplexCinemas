using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CineplexCinemas.Models
{
    public class CreditCard
    {
        [RegularExpression("^([0-9]{14,19})$", ErrorMessage = "Invalid card number.")]
        [Required]
        public string CardNumber { get; set; }

        [RegularExpression("^([a-zA-z]+)$", ErrorMessage = "Invalid first name.")]
        [Required]
        public string FirstName { get; set; }

        [RegularExpression("^([a-zA-z]+)$", ErrorMessage = "Invalid last name.")]
        [Required]
        public string LastName { get; set; }

        //[RegularExpression("^([0-9]{4})$")]
        //[Required]
        //public string ExpiryDate { get; set; }

        [RegularExpression("^([0-9]{2})$", ErrorMessage = "Invalid month.")]
        [Required]
        public string ExpiryMonth { get; set; }

        [RegularExpression("^([0-9]{2})$", ErrorMessage = "Invalid year.")]
        [Required]
        public string ExpiryYear { get; set; }

        [RegularExpression("^([0-9]{3})$", ErrorMessage = "Invalid CVC number.")]
        [Required]
        public string CVC { get; set; }
    }
}
