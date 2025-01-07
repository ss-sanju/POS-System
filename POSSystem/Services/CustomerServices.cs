using POSSystem.Generic;
using POSSystem.Models.Customer_Management;

namespace POSSystem.Services;

public class CustomerServices : ICustomerServices
{
    private readonly IUnitOfWork _unitofwork;
    public CustomerServices(IUnitOfWork unitofwork)
    {
        _unitofwork = unitofwork;
    }   
    public async Task<IEnumerable<Customer>> GetAllCustomerAsync()
    {
        return await _unitofwork.CustomerRepository.GetAllAsync();
    }
    public async Task<Customer> GetCustomerByIdAsync(Guid id)
    {
        return await _unitofwork.CustomerRepository.GetByIdAsync(id);
    }
    public async Task AddCustomerAsync(Customer customer)
    {
         await _unitofwork.CustomerRepository.AddAsync(customer);
        await _unitofwork.SaveAsync();
    }
    public async Task UpdateCustomerAsync(Customer customer)
    {
        await _unitofwork.CustomerRepository.UpdateAsync(customer);
        await _unitofwork.SaveAsync();
    }
    public async Task DeleteCustomerAsync(Guid id)
    {
        await _unitofwork.CustomerRepository.DeleteAsync(id);
        await _unitofwork.SaveAsync();
    }

}
