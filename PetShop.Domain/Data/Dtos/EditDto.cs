using System.ComponentModel.DataAnnotations;

namespace PetShop.Domain.Data.Dtos
{
    public class EditDto
    {
        public string Id { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        [DataType(DataType.Password)]
        public string? Password { get; set; } = string.Empty;
        [DataType(DataType.Password)]
        [Compare("Password", ErrorMessage = "The two entered passwords must be the same")]
        public string? ConfirmPassword { get; set; } = string.Empty;
    }
}
