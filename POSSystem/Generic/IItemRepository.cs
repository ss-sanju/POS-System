using POSSystem.Models.Item_Management;

namespace POSSystem.Generic;

public interface IItemRepository<T> where T : class
{
    Task<IEnumerable<T>> GetAllAsync();
    Task<T?> GetByIdAsync(Guid id);
    Task AddAsync(Item item);
    Task UpdateAsync(Item item);
    Task DeleteAsync(Guid id);
}
