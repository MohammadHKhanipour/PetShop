namespace PetShop.Data.Models
{
    public class Order
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool IsFinal { get; set; }
        public decimal Total { get; set; }

        public int PetId { get; set; }
        public int UserId { get; set; }

        public Bill Bill { get; set; }
        public Pet Pet { get; set; }
        public User User { get; set; }
    }
}
