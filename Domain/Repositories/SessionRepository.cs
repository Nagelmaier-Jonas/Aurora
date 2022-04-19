using Microsoft.EntityFrameworkCore;
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
        .ThenInclude(c => c.Wagons)
        .Include(c => c.Convoy.BackTruck)
        .ThenInclude(c => c.Wagons)
        .SingleOrDefaultAsync(s => s.Id == id);
}