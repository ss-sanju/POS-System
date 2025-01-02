using POSSystem.Models.Customer_Management;
using POSSystem.Models.Item_Management;

namespace POSSystem.Generic;

public interface ICustomerRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();  // This is now generic
    Task<T?> GetByIdAsync(Guid id);
    Task AddAsync(T item);
    Task UpdateAsync(T item);
    Task DeleteAsync(Guid id);
}

