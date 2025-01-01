using POSSystem.Models.Customer_Management;
using POSSystem.Models.Item_Management;

namespace POSSystem.Generic;

public interface IUnitOfWork : IDisposable
{
    IItemRepository<Item> ItemRepository { get; }
    ICustomerRepository<Customer> CustomerRepository { get; }
    Task SaveAsync();
}