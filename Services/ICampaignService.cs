using CampaignSender.Models;

namespace CampaignSender.Services
{
    public interface ICampaignService
    {
        Task<IEnumerable<Campaign>> GetAll();
        Task<Campaign> GetById(int id);
        Task<Campaign> Create(Campaign campaign);
        Task<Campaign?> Update(Campaign campaign);
        Task Delete(int id);
        Task<List<Customer>> SendCampaign(Campaign campaign);
    }
}
