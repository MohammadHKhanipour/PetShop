namespace PetShop.Data.Dtos
{
    public class PetDto : BaseDto
    {
        public Category Category { get; set; }
        public string Breed { get; set; }
        public string Name { get; set; }
        public int Age { get; set; }
        public string Description { get; set; }

        public int UserId { get; set; }
    }
}
