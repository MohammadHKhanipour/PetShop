﻿namespace PetShop.Data.Models
{
    public class Bill : BaseModel
    {
        public string Total { get; set; }
        public DateTime IssueDate { get; set; }
        public PaymentState PaymentState { get; set; }
        public string PaymentNumber { get; set; }

        public int OrderId { get; set; }

        public Order Order { get; set; }
    }
}
