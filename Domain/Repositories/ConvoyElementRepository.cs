using Microsoft.EntityFrameworkCore;
using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories;

public class ConvoyElementRepository : ARepository<AConvoyElement>{
    public ConvoyElementRepository(AuroraDbContext context) : base(context){
    }
    
    public async Task<AConvoyElement> ReadConvoysAsync(int id) => await _set.Include(s => s.Slots).SingleOrDefaultAsync(e => e.ElementId == id);
}