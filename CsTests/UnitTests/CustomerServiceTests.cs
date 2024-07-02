using CampaignSender.Data.Repositories;
using CampaignSender.Models;
using CampaignSender.Models.Enums;
using CampaignSender.Services;
using Moq;

namespace CsTests.UnitTests
{
    public class CustomerServiceTests
    {
        private readonly Mock<ICustomerRepository> _mockRepository;
        private readonly ICustomerService _customerService;


        public CustomerServiceTests()
        {
            _mockRepository = new Mock<ICustomerRepository>();
            _customerService = new CustomerService(_mockRepository.Object);
        }

        [Fact]
        public async Task GetCustomerById_ShouldReturnCustomer_WhenCustomerExists()
        {
            var customer = new Customer { Id = 1, Age = 30, Gender = Gender.Male, City = "New York", Deposit = 1000, IsANewCustomer = true, CampaignReceivedToday = false };
            _mockRepository.Setup(repo => repo.GetCustomerById(1)).ReturnsAsync(customer);

            var result = await _customerService.GetCustomerById(1);

            Assert.NotNull(result);
            Assert.Equal(customer.Id, result.Id);
            Assert.Equal(customer.Age, result.Age);
        }

        [Fact]
        public async Task CreateCustomer_ShouldReturnCreatedCustomer()
        {
            var customer = new Customer { Id = 1, Age = 30, Gender = Gender.Male, City = "New York", Deposit = 1000, IsANewCustomer = true, CampaignReceivedToday = false };
            _mockRepository.Setup(repo => repo.CreateCustomer(customer)).ReturnsAsync(customer);

            var result = await _customerService.CreateCustomer(customer);

            Assert.NotNull(result);
            Assert.Equal(customer.Id, result.Id);
            Assert.Equal(customer.Age, result.Age);
        }

        [Fact]
        public async Task UpdateCustomer_ShouldReturnUpdatedCustomer()
        {
            var updatedCustomer = new Customer { Id = 1, Age = 35, Gender = Gender.Male, City = "Los Angeles", Deposit = 1500, IsANewCustomer = false, CampaignReceivedToday = true };
            _mockRepository.Setup(repo => repo.UpdateCustomer(updatedCustomer)).ReturnsAsync(updatedCustomer);

            var result = await _customerService.UpdateCustomer(updatedCustomer);

            Assert.NotNull(result);
            Assert.Equal(updatedCustomer.Id, result.Id);
            Assert.Equal(updatedCustomer.Age, result.Age);
        }

        [Fact]
        public async Task DeleteCustomer_ShouldReturnTrue_WhenCustomerDeleted()
        {
            _mockRepository.Setup(repo => repo.DeleteCustomer(1)).ReturnsAsync(true);

            var result = await _customerService.DeleteCustomer(1);

            Assert.True(result);
        }

        [Fact]
        public async Task GetAllCustomers_ShouldReturnAllCustomers()
        {
            var customers = new List<Customer>
        {
            new Customer { Id = 1, Age = 30, Gender = Gender.Male, City = "New York", Deposit = 1000, IsANewCustomer = true, CampaignReceivedToday = false },
            new Customer { Id = 2, Age = 25, Gender = Gender.Female, City = "Chicago", Deposit = 500, IsANewCustomer = false, CampaignReceivedToday = true }
        };
            _mockRepository.Setup(repo => repo.GetAllCustomers()).ReturnsAsync(customers);

            var result = await _customerService.GetAllCustomers();

            Assert.Equal(2, result.Count());
        }

        [Fact]
        public async Task GetCustomersByCriteria_ShouldReturnMatchingCustomers()
        {
            var criteria = new CustomerCriteria { AgeAbove = 20, City = "New York" };
            var customers = new List<Customer>
        {
            new Customer { Id = 1, Age = 30, Gender = Gender.Male, City = "New York", Deposit = 1000, IsANewCustomer = true, CampaignReceivedToday = false }
        };
            _mockRepository.Setup(repo => repo.GetCustomersByCriteria(criteria)).ReturnsAsync(customers);

            var result = await _customerService.GetCustomersByCriteria(criteria);

            Assert.Single(result);
            Assert.Equal(customers[0].Id, result.First().Id);
        }

        [Fact]
        public async Task RefreshDailyCampaignsReceivings_ShouldReturnTrue_WhenSuccessful()
        {
            _mockRepository.Setup(repo => repo.RefreshCampaignsReceiving()).ReturnsAsync(true);

            var result = await _customerService.RefreshDailyCampaignsReceivings();

            Assert.True(result);
        }

        [Fact]
        public async Task UpdateCustomers_ShouldReturnUpdatedCustomers()
        {
            var customers = new List<Customer>
        {
            new Customer { Id = 1, Age = 30, Gender = Gender.Male, City = "New York", Deposit = 1000, IsANewCustomer = true, CampaignReceivedToday = false },
            new Customer { Id = 2, Age = 25, Gender = Gender.Female, City = "Chicago", Deposit = 500, IsANewCustomer = false, CampaignReceivedToday = true }
        };
            var updatedCustomers = new List<Customer?>
        {
            new Customer { Id = 1, Age = 31, Gender = Gender.Male, City = "New York", Deposit = 1100, IsANewCustomer = true, CampaignReceivedToday = false },
            new Customer { Id = 2, Age = 26, Gender = Gender.Female, City = "Chicago", Deposit = 550, IsANewCustomer = false, CampaignReceivedToday = true }
        };
            _mockRepository.Setup(repo => repo.UpdateCustomers(customers)).ReturnsAsync(updatedCustomers);

            var result = await _customerService.UpdateCustomers(customers);

            Assert.Equal(2, result.Count);
            Assert.Equal(updatedCustomers[0].Age, result[0].Age);
            Assert.Equal(updatedCustomers[1].Age, result[1].Age);
        }
    }
}
