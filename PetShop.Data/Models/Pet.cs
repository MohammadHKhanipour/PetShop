using PetShop.Data.Enums;

namespace PetShop.Data.Models
{
    public class Pet
    {
        public int Id { get; set; }
        public Category Category { get; set; }
        public string breed { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }

        public List<PetImage> PetImages { get; set; }
        public User User { get; set; }
        public Order Order { get; set; }
    }
}
