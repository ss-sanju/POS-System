using POSSystem.Models.Item_Management;

namespace POSSystem.Services
{
    public interface IItemServices
    {
        Task<IEnumerable<Item>> GetAllItemAsync();
        Task<Item> GetItemByIdAsync(Guid id);
        Task AddItemAsync(Item Item);
        Task UpdateItemAsync(Item Item);
        Task DeleteItemAsync(Guid id);
    }
}
