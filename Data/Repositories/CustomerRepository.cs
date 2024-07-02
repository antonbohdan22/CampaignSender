using CampaignSender.Models;
using Microsoft.EntityFrameworkCore;

namespace CampaignSender.Data.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly AppDbContext _context;

        public CustomerRepository(AppDbContext context)
        {
            _context = context;
        }
        public async Task<Customer?> GetCustomerById(int id)
        {
            return await _context.Customers.FindAsync(id);
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<Customer?> UpdateCustomer(Customer updatedCustomer)
        {
            var customer = await _context.Customers.FindAsync(updatedCustomer.Id);
            if (customer == null) return null;

            customer.Age = updatedCustomer.Age;
            customer.Gender = updatedCustomer.Gender;
            customer.City = updatedCustomer.City;
            customer.Deposit = updatedCustomer.Deposit;
            customer.IsANewCustomer = updatedCustomer.IsANewCustomer;

            await _context.SaveChangesAsync();
            return customer;
        }

        public async Task<List<Customer?>> UpdateCustomers(List<Customer> customers)
        {
            _context.Customers.UpdateRange(customers);
                           
            await _context.SaveChangesAsync();
            return customers;
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            var customer = await _context.Customers.FindAsync(id);
            if (customer == null) return false;

            _context.Customers.Remove(customer);
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _context.Customers.ToListAsync();
        }

        public async Task<IEnumerable<Customer>> GetCustomersByCriteria(CustomerCriteria criteria)
        {
            var customers = await (from c in _context.Customers
                             where
                             c.Age > criteria.AgeAbove || c.Age < criteria.AgeBelow ||
                             c.Gender == criteria.Gender ||
                             c.City == criteria.City ||
                             c.Deposit > criteria.DepositAbove || c.Deposit < criteria.DepositBelow ||
                             c.IsANewCustomer == criteria.IsANewCustomer
                             select c).ToListAsync();

            if(customers == null) return Enumerable.Empty<Customer>();

            return customers;
        }

        public async Task<bool> RefreshCampaignsReceiving()
        {
            foreach (var customer in _context.Customers)
            {
                customer.CampaignReceivedToday = false;
            }

            return await _context.SaveChangesAsync() > 0;
        }
    }
}
