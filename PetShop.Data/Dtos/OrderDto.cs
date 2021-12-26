namespace PetShop.Data.Dtos
{
    public class OrderDto : BaseDto
    {
        public DateTime Date { get; set; }
        public bool IsFinal { get; set; }
        public decimal Total { get; set; }

        public int PetId { get; set; }
        public int UserId { get; set; }
    }
}
