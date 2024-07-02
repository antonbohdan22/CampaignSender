using CampaignSender.Data.Repositories;
using CampaignSender.Models;

namespace CampaignSender.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _repo;

        public CustomerService(ICustomerRepository repo)
        {
            _repo = repo;
        }

        public async Task<Customer?> GetCustomerById(int id)
        {
            return await _repo.GetCustomerById(id);
        }

        public async Task<Customer> CreateCustomer(Customer customer)
        {
            return await _repo.CreateCustomer(customer);
        }

        public async Task<Customer?> UpdateCustomer(Customer updatedCustomer)
        {
            return await _repo.UpdateCustomer(updatedCustomer);
        }

        public async Task<List<Customer?>> UpdateCustomers(List<Customer> customers)
        {
            return await _repo.UpdateCustomers(customers);
        }

        public async Task<bool> DeleteCustomer(int id)
        {
            return await _repo.DeleteCustomer(id);
        }

        public async Task<IEnumerable<Customer>> GetAllCustomers()
        {
            return await _repo.GetAllCustomers();
        }

        public async Task<IEnumerable<Customer>> GetCustomersByCriteria(CustomerCriteria criteria)
        {
            return await _repo.GetCustomersByCriteria(criteria);
        }

        public async Task<bool> RefreshDailyCampaignsReceivings()
        {
            return await _repo.RefreshCampaignsReceiving();
        }
    }
}
