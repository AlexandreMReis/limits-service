using Limits.Service.API.Models;

namespace Limits.Service.DAL.Interfaces
{
    public interface ILimitsRepository
    {
        public IEnumerable<Limit> GetLimitsForCustomer(int customerId);
    }
}
