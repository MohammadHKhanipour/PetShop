using System.ComponentModel.DataAnnotations;

namespace PetShop.Domain.Data.Dtos
{
    public class SignUpDto
    {
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        [Required]
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        [Required(ErrorMessage = "Must be completed")]
        [DataType(DataType.Password)]
        public string Password { get; set; } = string.Empty;
        [Required(ErrorMessage = "Must be completed")]
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The two entered passwords must be the same")]
        public string ConfirmPassword { get; set; } = string.Empty;
    }
}
