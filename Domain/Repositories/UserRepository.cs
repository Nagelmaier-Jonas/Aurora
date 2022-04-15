using Microsoft.EntityFrameworkCore;
using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories;

public class UserRepository : ARepository<User>{
    public UserRepository(AuroraDbContext context) : base(context){
    }
    
    public async Task<User> ReadConvoysAsync(int id) => await _set.Include(u => u.Convoys).SingleOrDefaultAsync(u => u.Id == id);
}