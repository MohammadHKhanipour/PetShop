namespace PetShop.Domain.Data.Models
{
    public class User : BaseModel
    {
        public User()
        {
            Pets = new List<Pet>();
        }

        public string FirstName { get; set; } = string.Empty;
        public string LastName { get; set; } = string.Empty;
        public int Age { get; set; }
        public string PhoneNumber { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Street { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;

        public List<Pet> Pets { get; set; }
    }
}
