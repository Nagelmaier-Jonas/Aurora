using Microsoft.EntityFrameworkCore;
using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories;

public class UserRepository : ARepository<User>{
    public UserRepository(AuroraDbContext context) : base(context){
    }
    
    public async Task<User?> ReadUserGraphAsync(int id) => await _set
        .Include(u => u.Sessions)
        .ThenInclude(s => s.Convoy)
        .ThenInclude(c => c.FrontTruck)
        .SingleOrDefaultAsync(u => u.Id == id);
}