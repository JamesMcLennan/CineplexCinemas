using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Cineplex.Models
{
    public partial class Enquiry
    {
        [Key]
        public int EnquiryId { get; set; }
        public string Email { get; set; }
        public string Message { get; set; }
    }
}
