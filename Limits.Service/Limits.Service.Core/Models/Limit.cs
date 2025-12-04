using Limits.Service.Core.Enums;

namespace Limits.Service.API.Models
{
    public class Limit
    {
        public long Id { get; set; }
        public int CustomerId { get; set; }
        public LimitTypeEnum LimitType { get; set; }
        public TimePeriodEnum TimePeriod { get; set; }
        public DateTime CreatedAt { get; set; }
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime? UpdatedAt { get; set; }
        public string UpdatedBy { get; set; } = string.Empty;
    }
}
