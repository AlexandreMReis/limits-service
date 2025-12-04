using Limits.Service.Core.Enums;

namespace Limits.Service.API.Models
{
    public class Transaction
    {
        public long Id { get; set; }
        public int CustomerId { get; set; }
        public TransactionTypeEnum TypeId { get; set; }
        public decimal Value { get; set; }
        public DateTime? CreatedAt { get; set; }
        public string CreatedBy { get; set; }
    }
}
