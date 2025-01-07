using POSSystem.Models.Customer_Management;
using POSSystem.Models.Item_Management;

namespace POSSystem.Generic;

public interface IUnitOfWork : IDisposable
{
    IRepository<Customer> CustomerRepository { get; }
    IRepository<Item> ItemRepository { get; }
    IRepository<Vendor> VendorRepository { get; }
    Task SaveAsync();
}
