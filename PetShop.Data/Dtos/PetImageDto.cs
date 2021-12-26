namespace PetShop.Data.Dtos
{
    public class PetImageDto : BaseDto
    {
        public int Num { get; set; }
        public bool IsCover { get; set; }
        public string ImageLink { get; set; }

        public int PetId { get; set; }
    }
}
