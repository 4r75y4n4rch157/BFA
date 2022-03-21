using System.ComponentModel.DataAnnotations;

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
