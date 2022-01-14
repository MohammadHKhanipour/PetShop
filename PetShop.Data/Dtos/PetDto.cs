namespace PetShop.Data.Dtos
{
    public class PetDto : BaseDto
    {
        public Category Category { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Price { get; set; }
        public string City { get; set; }
        public string Description { get; set; }
        public DateOnly DateAdded { get; set; }

        public int UserId { get; set; }
    }
}
