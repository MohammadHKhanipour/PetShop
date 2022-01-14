namespace PetShop.Domain.Data.Models
{
    public class Pet : BaseModel
    {
        public Pet()
        {
            User = new User();
        }

        public Category Category { get; set; }
        public string Breed { get; set; } = string.Empty;
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Price { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateOnly DateAdded { get; set; }
        public string ImageAddress { get; set; } = string.Empty;

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
