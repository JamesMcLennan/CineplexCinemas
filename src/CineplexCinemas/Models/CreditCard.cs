using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CineplexCinemas.Models
{
    public class CreditCard
    {
        [Display(Name = "Card Number")]
        public string cardNumber { get; set; }

        [Display(Name = "First Name")]
        public string firstName { get; set; }

        [Display(Name = "Last Name")]
        public string lastName { get; set; }

        [Display(Name = "Expiry Date")]
        public string expiryDate { get; set; }

        [Display(Name = "CVC")]
        public string CVC { get; set; }
    }
}
