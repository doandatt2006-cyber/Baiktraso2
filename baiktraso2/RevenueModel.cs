using System;

namespace baiktraso2
{
    public class RevenueModel
    {
        public string TransactionId { get; set; }
        public DateTime TransactionDate { get; set; }
        public string BranchName { get; set; }
        public string CustomerName { get; set; }
        public decimal Amount { get; set; }
    }
}