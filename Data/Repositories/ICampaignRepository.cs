using CampaignSender.Models;

namespace CampaignSender.Data.Repositories
{
    public interface ICampaignRepository
    {
        Task<IEnumerable<Campaign>> GetAll();
        Task<Campaign> GetById(int id);
        Task<Campaign> Create(Campaign campaign);
        Task<Campaign?> Update(Campaign campaign);
        Task Delete(int id);
    }
}
