using POSSystem.Data;
using POSSystem.Models.Customer_Management;
using POSSystem.Models.Item_Management;

namespace POSSystem.Generic;
public class UnitofWork:IUnitOfWork
{
    private readonly ApplicationDbContext _context;
    public UnitofWork(ApplicationDbContext context)
    {
        _context = context;
        CustomerRepository =new Repository<Customer>(_context);
        ItemRepository = new Repository<Item>(_context);
    }
    public IRepository<Customer> CustomerRepository { get; set; }
    public IRepository<Item> ItemRepository { get; set; }
    public async Task SaveAsync()
    {
        await _context.SaveChangesAsync();
    }
    public void Dispose()
    {
        _context.Dispose();
    }
}
