namespace PetShop.Data.Dtos
{
    public class WalletDto : BaseDto
    {
        public decimal Balance { get; set; }

        public int UserId { get; set; }
    }
}
