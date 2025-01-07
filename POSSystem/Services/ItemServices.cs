using POSSystem.Generic;
using POSSystem.Models.Item_Management;

namespace POSSystem.Services;

public class ItemServices : IItemServices
{
    private readonly IUnitOfWork _unitofwork;
    public ItemServices(IUnitOfWork unitofwork)
    {
        _unitofwork = unitofwork;
    }   
    public async Task<IEnumerable<Item>> GetAllItemAsync()
    {
        return await _unitofwork.ItemRepository.GetAllAsync();
    }
    public async Task<Item> GetItemByIdAsync(Guid id)
    {
        return await _unitofwork.ItemRepository.GetByIdAsync(id);
    }
    public async Task AddItemAsync(Item Item)
    {
         await _unitofwork.ItemRepository.AddAsync(Item);
        await _unitofwork.SaveAsync();
    }
    public async Task UpdateItemAsync(Item Item)
    {
        await _unitofwork.ItemRepository.UpdateAsync(Item);
        await _unitofwork.SaveAsync();
    }
    public async Task DeleteItemAsync(Guid id)
    {
        await _unitofwork.ItemRepository.DeleteAsync(id);
        await _unitofwork.SaveAsync();
    }

}
