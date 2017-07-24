using System.ComponentModel.DataAnnotations;

namespace ShittyFakeSpaceX.ViewModels
{
    public class RegisterViewModel
    {
        [Required]
        [EmailAddress]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [StringLength(100, ErrorMessage = "The {0} must be at least {2} at {1} character long", MinimumLength = 3)]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Required]
        [Compare("Password", ErrorMessage = "Doesn't match")]
        [DataType(DataType.Password)]
        public string PasswordConfirm { get; set; }

        public Country Country { get; set; }
    }

    public enum Country
    {
        Canada,
        Italy,
        USA,
        Ukraine,
        Spain,
        Russia,
        Germany,
        RestOftheWorld
    }
}
