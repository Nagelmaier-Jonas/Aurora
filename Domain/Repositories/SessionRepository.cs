using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Conventions;
using Model.Configuration;
using Model.Entities;
using MudBlazor.Extensions;

namespace Domain.Repositories;

public class SessionRepository : ARepository<Session>{
    public SessionRepository(AuroraDbContext context) : base(context){
    }
    
    public async Task<Session?> ReadSessionGraphAsync(int id) => await _set
        .Include(s => s.User)
        .Include(s => s.Convoy)
        .ThenInclude(c => c.FrontTruck)
        .ThenInclude(t => t.Addon)
        .Include(s => s.Convoy)
        .ThenInclude(c => c.FrontTruck)
        .ThenInclude(t => t.Wagons)
        .ThenInclude(w => w.Addon)
        .Include(s => s.Convoy)
        .ThenInclude(c => c.BackTruck)
        .ThenInclude(t => t.Addon)
        .Include(s => s.Convoy)
        .ThenInclude(c => c.BackTruck)
        .ThenInclude(t => t.Wagons)
        .ThenInclude(w => w.Addon)
        .SingleOrDefaultAsync(s => s.Id == id);
}