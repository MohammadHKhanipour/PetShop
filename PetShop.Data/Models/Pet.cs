namespace PetShop.Data.Models
{
    public class Pet : BaseModel
    {
        public Category Category { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Price { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public DateOnly DateAdded { get; set; }
        public string ImageAddress { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
