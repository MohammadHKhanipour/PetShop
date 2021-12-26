namespace PetShop.Data.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }
        public string Email { get; set; }
        public string City { get; set; }
        public string Address { get; set; }

        public Wallet Wallet { get; set; }
        public List<Order> Orders { get; set; }
        public List<Pet> Pets { get; set; }
    }
}
