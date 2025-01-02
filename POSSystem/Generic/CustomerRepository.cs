using Microsoft.EntityFrameworkCore;
using POSSystem.Data;
using POSSystem.Generic;
using POSSystem.Models.Item_Management;

namespace POSSystem.Generic;

public class CustomerRepository<T> : ICustomerRepository<T> where T : class
{
    private readonly ApplicationDbContext _context;
    private readonly DbSet<T> _dbSet;

    public CustomerRepository(ApplicationDbContext context)
    {
        _context = context;
        _dbSet = _context.Set<T>();
    }

    public async Task<IEnumerable<T>> GetAllAsync()
    {
        return await _dbSet.ToListAsync();
    }

    public async Task<T> GetByIdAsync(Guid id)
    {
        return await _dbSet.FindAsync(id);
    }

    public async Task AddAsync(T entity)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            await _dbSet.AddAsync(entity);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    public async Task UpdateAsync(T entity)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            _dbSet.Update(entity);
            await _context.SaveChangesAsync();
            await transaction.CommitAsync();
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }

    public async Task DeleteAsync(Guid id)
    {
        using var transaction = await _context.Database.BeginTransactionAsync();
        try
        {
            var entity = await _dbSet.FindAsync(id);
            if (entity != null)
            {
                _dbSet.Remove(entity);
                await _context.SaveChangesAsync();
                await transaction.CommitAsync();
            }
        }
        catch
        {
            await transaction.RollbackAsync();
            throw;
        }
    }
}

