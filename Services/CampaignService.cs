using CampaignSender.Data.Repositories;
using CampaignSender.Models;

namespace CampaignSender.Services
{
    public class CampaignService : ICampaignService
    {
        private readonly ICampaignRepository _campRepo;
        private readonly ICustomerCriteriaRepository _ccRepo;
        private readonly ICustomerService _customerService;
        private readonly ICampaignWriter _writer;

        public CampaignService(ICampaignRepository campRepo, ICustomerCriteriaRepository ccRepo, ICustomerService customerService, ICampaignWriter writer)
        {
            _campRepo = campRepo;
            _ccRepo = ccRepo;
            _customerService = customerService;
            _writer = writer;
        }

        public Task<Campaign> Create(Campaign campaign)
        {
            return _campRepo.Create(campaign);
        }

        public Task Delete(int id)
        {
            return _campRepo.Delete(id);
        }

        public Task<IEnumerable<Campaign>> GetAll()
        {
            return _campRepo.GetAll();
        }

        public Task<Campaign> GetById(int id)
        {
            return _campRepo.GetById(id);
        }

        public Task<Campaign?> Update(Campaign campaign)
        {
            return _campRepo.Update(campaign);
        }

        public async Task<List<Customer>> SendCampaign(Campaign campaign)
        {
            var allCC = await _ccRepo.GetAll();

            var criteria = allCC.FirstOrDefault(cc => cc.CampaignId == campaign.Id);

            if (criteria != null)
            {
                campaign.CustomerCriteria = criteria;
            }

            var customers = await _customerService.GetCustomersByCriteria(campaign.CustomerCriteria);

            _writer.WriteCampaignDetailsToFile(campaign);

            foreach (var customer in customers.Where(c => !c.CampaignReceivedToday))
                customer.CampaignReceivedToday = true;

            return await _customerService.UpdateCustomers((List<Customer>)customers);
        }
    }
}
