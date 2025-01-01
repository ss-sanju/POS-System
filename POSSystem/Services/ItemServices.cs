using POSSystem.Generic;
using POSSystem.Models.Item_Management;

namespace POSSystem.Services
{
    public class ItemServices : IItemServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public ItemServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Item>> GetAllItemsAsync()
        {
            return await _unitOfWork.ItemRepository.GetAllAsync();
        }

        public async Task<Item> GetItemByIdAsync(Guid id)
        {
            return await _unitOfWork.ItemRepository.GetByIdAsync(id);
        }
        public async Task AddItemAsync(Item Item)
        {
            await _unitOfWork.ItemRepository.AddAsync(Item);
            await _unitOfWork.SaveAsync();
        }
        public async Task UpdateItemAsync(Item Item)
        {
            await _unitOfWork.ItemRepository.UpdateAsync(Item);
            await _unitOfWork.SaveAsync();
        }     

        public async Task DeleteItemAsync(Guid id)
        {
            await _unitOfWork.ItemRepository.DeleteAsync(id);
            await _unitOfWork.SaveAsync();
        }
    }
}
