using System.ComponentModel.DataAnnotations;

namespace HCILabForm.Models
{
    public class LoginVM
    {
        [Required]
        [EmailAddress]
        public string username { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string password { get; set; }
    }
    public class RegisterVM
    {
        [Required]
        [EmailAddress]
        public string username { get; set; }


        [Required]
        [StringLength(30, ErrorMessage = "Password must be at least 8 characters long.", MinimumLength = 8)]
        public string password { get; set; }

        [Required]
        [Compare(nameof(password), ErrorMessage = "Password Mismatch")]
        public string repeatPassword { get; set; }

        [Required]
        public string firstname { get; set; }
        [Required]
        public string lastname { get; set; }
    }
}
