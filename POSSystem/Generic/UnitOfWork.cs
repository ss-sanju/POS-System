using POSSystem.Data;
using POSSystem.Models.Customer_Management;
using POSSystem.Models.Item_Management;

namespace POSSystem.Generic;

public class UnitOfWork : IUnitOfWork
{
    private readonly ApplicationDbContext _context;


    public UnitOfWork(ApplicationDbContext context)
    {
        _context = context;
        ItemRepository = new ItemRepository<Item>(_context);
        CustomerRepository = new CustomerRepository<Customer>(_context);
    }

    public IItemRepository<Item> ItemRepository { get; private set; }
    public ICustomerRepository<Customer> CustomerRepository {  get; private set; }
    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }

    public void Dispose()
    {
        _context.Dispose();
    }
}
