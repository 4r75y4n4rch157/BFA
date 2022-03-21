using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ContactUS.ViewModel
{
    public class ContactViewModel
    {
        [Required]
        public string First_Name { get; set; }
        [Required]
        public string Last_Name{ get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Message { get; set; }
    }
}
