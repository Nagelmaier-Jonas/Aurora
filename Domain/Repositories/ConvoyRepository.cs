using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories;

public class ConvoyRepository : ARepository<Convoy>{
    public ConvoyRepository(AuroraDbContext context) : base(context){
    }
}