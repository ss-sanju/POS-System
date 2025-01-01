using POSSystem.Generic;
using POSSystem.Models.Customer_Management;

namespace POSSystem.Services
{
    public class CustomerServices : ICustomerServices
    {
        private readonly IUnitOfWork _unitOfWork;
        public CustomerServices(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
        {
            return await _unitOfWork.CustomerRepository.GetAllAsync();
        }

        public async Task<Customer> GetCustomerByIdAsync(Guid id)
        {
            return await _unitOfWork.CustomerRepository.GetByIdAsync(id);
        }
        public async Task AddCustomerAsync(Customer Customer)
        {
            await _unitOfWork.CustomerRepository.AddAsync(Customer);
            await _unitOfWork.SaveAsync();
        }
        public async Task UpdateCustomerAsync(Customer Customer)
        {
            await _unitOfWork.CustomerRepository.UpdateAsync(Customer);
            await _unitOfWork.SaveAsync();
        }     

        public async Task DeleteCustomerAsync(Guid id)
        {
            await _unitOfWork.CustomerRepository.DeleteAsync(id);
            await _unitOfWork.SaveAsync();
        }
    }
}
