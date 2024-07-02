using CampaignSender.Models;

namespace CampaignSender.Data.Repositories
{
    public interface ICustomerCriteriaRepository
    {
        Task<IEnumerable<CustomerCriteria>> GetAll();
        Task<CustomerCriteria> GetById(int id);
        Task<CustomerCriteria> Create(CustomerCriteria criteria);
        Task<CustomerCriteria?> Update(CustomerCriteria campaign);
        Task Delete(int id);
    }
}
