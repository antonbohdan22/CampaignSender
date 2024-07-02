using CampaignSender.Models;
using Microsoft.EntityFrameworkCore;

namespace CampaignSender.Data.Repositories
{
    public class CampaignRepository : ICampaignRepository
    {
        private readonly AppDbContext _context;

        public CampaignRepository(AppDbContext context)
        {
            _context = context;
        }

        public async Task<IEnumerable<Campaign>> GetAll()
        {
            return await _context.Campaigns.ToListAsync();
        }

        public async Task<Campaign> GetById(int id)
        {
            return await _context.Campaigns.FindAsync(id);
        }

        public async Task<Campaign> Create(Campaign campaign)
        {
            _context.Campaigns.Add(campaign);
            await _context.SaveChangesAsync();
            return campaign;
        }

        public async Task<Campaign?> Update(Campaign campaign)
        {
            var entity = await _context.Campaigns.FindAsync(campaign.Id);
            if (entity == null) return null;

            entity.Template = campaign.Template;
            entity.CustomerCriteria = campaign.CustomerCriteria;
            entity.SendingTime = campaign.SendingTime;
            entity.Priority = campaign.Priority;

            await _context.SaveChangesAsync();
            return entity;
        }

        public async Task Delete(int id)
        {
            var campaign = await _context.Campaigns.FindAsync(id);
            if (campaign != null)
            {
                _context.Campaigns.Remove(campaign);
                await _context.SaveChangesAsync();
            }
        }
    }
}
