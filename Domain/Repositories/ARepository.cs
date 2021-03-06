using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;
using Model.Configuration;

namespace Domain.Repositories;

public class ARepository<TEntity> : IRepository<TEntity> where TEntity : class
{
    private readonly AuroraDbContext _context;
    protected readonly DbSet<TEntity> _set;

    public ARepository(AuroraDbContext context)
    {
        _context = context;
        _set = _context.Set<TEntity>();
    }

    public async Task<TEntity?> ReadAsync(int id)
    {
        return await _set.FindAsync(id);
    }

    public async Task<List<TEntity>> ReadAsync(Expression<Func<TEntity, bool>> filter)
    {
        return await _set.Where(filter).ToListAsync();
    }

    public async Task<List<TEntity>> ReadAllAsync()
    {
        return await _set.ToListAsync();
    }

    public async Task<List<TEntity>> ReadAsync(int start, int count)
    {
        return await _set.Skip(start).Take(count).ToListAsync();
    }

    public async Task<TEntity> CreateAsync(TEntity entity)
    {
        _context.ChangeTracker.Clear();
        _set.Add(entity);
        await _context.SaveChangesAsync();
        return entity;
    }

    public async Task UpdateAsync(TEntity entity)
    {
        _context.ChangeTracker.Clear();
        _set.Update(entity);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(TEntity entity)
    {
        _set.Remove(entity);
        await _context.SaveChangesAsync();
    }
}