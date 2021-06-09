using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TRHKG.Models.ViewModels
{
    public class ContactUsViewModel
    {
        [Required]
        public string FirstName { get; set; }
        [Required]
        public string SecondName { get; set; }
        [Required]
        public string Country { get; set; }
        [Required]
        public string Subject { get; set; }
    }
}
