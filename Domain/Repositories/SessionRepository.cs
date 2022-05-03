using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories;

public class SessionRepository : ARepository<Session>{
    public SessionRepository(AuroraDbContext context) : base(context){
    }
    
    public async Task<Session?> ReadSessionGraphAsync(int id) => await _set
        .Include(s => s.User)
        .Include(s => s.Convoy)
        .ThenInclude(c => c.FrontTruck)
        .ThenInclude(t => t.Addon)
        .ThenInclude(a => a.Slots)
        .ThenInclude(s => s.Cargo)
        .ThenInclude(c => c.Keywords)
        .Include(s => s.Convoy)
        .ThenInclude(c => c.FrontTruck)
        .ThenInclude(t => t.Wagons)
        .ThenInclude(w => w.Addon)
        .ThenInclude(a => a.Slots)
        .ThenInclude(s => s.Cargo)
        .ThenInclude(c => c.Keywords)
        .Include(s => s.Convoy)
        .ThenInclude(c => c.BackTruck)
        .ThenInclude(t => t.Addon)
        .ThenInclude(a => a.Slots)
        .ThenInclude(s => s.Cargo)
        .ThenInclude(c => c.Keywords)
        .Include(s => s.Convoy)
        .ThenInclude(c => c.BackTruck)
        .ThenInclude(t => t.Wagons)
        .ThenInclude(w => w.Addon)
        .ThenInclude(a => a.Slots)
        .ThenInclude(s => s.Cargo)
        .ThenInclude(c => c.Keywords)
        .Include(s => s.Convoy)
        .ThenInclude(c => c.FrontTruck)
        .ThenInclude(a => a.Slots)
        .ThenInclude(s => s.Cargo)
        .ThenInclude(c => c.Keywords)
        .Include(s => s.Convoy)
        .ThenInclude(c => c.BackTruck)
        .ThenInclude(a => a.Slots)
        .ThenInclude(s => s.Cargo)
        .ThenInclude(c => c.Keywords)
        .AsSplitQuery()
        .SingleOrDefaultAsync(s => s.Id == id);
}