namespace PetShop.Data.Models
{
    public class Wallet : BaseModel
    {
        public decimal Balance { get; set; }

        public int UserId { get; set; }

        public User User { get; set; }
    }
}
