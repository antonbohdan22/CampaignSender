using CampaignSender.Models;

namespace CampaignSender.Data.Repositories
{
    public interface ICustomerRepository
    {
        Task<Customer?> GetCustomerById(int id);
        Task<Customer> CreateCustomer(Customer customer);
        Task<Customer?> UpdateCustomer(Customer updatedCustomer);
        Task<List<Customer?>> UpdateCustomers(List<Customer> customers);
        Task<bool> DeleteCustomer(int id);
        Task<IEnumerable<Customer>> GetAllCustomers();
        Task<IEnumerable<Customer>> GetCustomersByCriteria(CustomerCriteria criteria);
        Task<bool> RefreshCampaignsReceiving();
    }
}
