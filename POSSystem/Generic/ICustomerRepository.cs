using POSSystem.Models.Customer_Management;

namespace POSSystem.Generic;

public interface ICustomerRepository<T> where T : class
{
    Task<IEnumerable<Customer>> GetAllAsync();
    Task<Customer?> GetByIdAsync(Guid id);
    Task AddAsync(Customer Customer);
    Task UpdateAsync(Customer Customer);
    Task DeleteAsync(Guid id);
}
