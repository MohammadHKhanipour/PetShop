namespace PetShop.Data.Dtos
{
    public class BillDto : BaseDto
    {
        public string Total { get; set; }
        public DateTime IssueDate { get; set; }
        public PaymentState PaymentState { get; set; }
        public string PaymentNumber { get; set; }

        public int OrderId { get; set; }
    }
}
