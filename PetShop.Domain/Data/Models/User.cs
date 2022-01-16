using Microsoft.AspNetCore.Identity;

namespace PetShop.Domain.Data.Models
{
    public class User : IdentityUser
    {
        public bool IsActive { get; set; }
        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;

        public List<Pet>? Pets { get; set; }
    }
}
