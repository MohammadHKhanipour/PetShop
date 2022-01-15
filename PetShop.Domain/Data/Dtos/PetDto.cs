namespace PetShop.Domain.Data.Dtos
{
    public class PetDto : BaseDto
    {
        public Category Category { get; set; }
        public string Breed { get; set; } = string.Empty;
        public Gender Gender { get; set; }
        public string Name { get; set; } = string.Empty;
        public int Age { get; set; }
        public string Price { get; set; } = string.Empty;
        public string City { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public DateTime DateAdded { get; set; }
        public string ImageAddress { get; set; } = string.Empty;

        public int UserId { get; set; }
    }
}
