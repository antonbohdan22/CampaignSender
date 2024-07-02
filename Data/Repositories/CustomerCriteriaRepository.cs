using CampaignSender.Models;
using Microsoft.EntityFrameworkCore;

namespace CampaignSender.Data.Repositories
{
    public class CustomerCriteriaRepository : ICustomerCriteriaRepository
    {
        private readonly AppDbContext _context;

        public CustomerCriteriaRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<CustomerCriteria> Create(CustomerCriteria criteria)
        {
            _context.CustomerCriterias.Add(criteria);
            await _context.SaveChangesAsync();
            return criteria;
        }

        public async Task Delete(int id)
        {
            var criteria = await _context.CustomerCriterias.FindAsync(id);
            if (criteria != null)
            {
                _context.CustomerCriterias.Remove(criteria);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<IEnumerable<CustomerCriteria>> GetAll()
        {
            return await _context.CustomerCriterias.ToListAsync();
        }

        public async Task<CustomerCriteria> GetById(int id)
        {
            return await _context.CustomerCriterias.FindAsync(id);
        }

        public async Task<CustomerCriteria?> Update(CustomerCriteria criteria)
        {
            var entity = await _context.CustomerCriterias.FindAsync(criteria.Id);
            if (entity == null) return null;

            entity.AgeAbove = criteria.AgeAbove;
            entity.AgeBelow = criteria.AgeBelow;
            entity.Gender = criteria.Gender;
            entity.City = criteria.City;
            entity.DepositAbove = criteria.DepositAbove;
            entity.DepositBelow = criteria.DepositBelow;
            entity.IsANewCustomer = criteria.IsANewCustomer;

            await _context.SaveChangesAsync();
            return entity;
        }
    }
}
