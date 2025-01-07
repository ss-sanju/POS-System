using POSSystem.Models.Customer_Management;

namespace POSSystem.Services
{
    public interface ICustomerServices
    {
        Task<IEnumerable<Customer>> GetAllCustomerAsync();
        Task<Customer> GetCustomerByIdAsync(Guid id);
        Task AddCustomerAsync(Customer Customer);
        Task UpdateCustomerAsync(Customer Customer);
        Task DeleteCustomerAsync(Guid id);
    }
}
