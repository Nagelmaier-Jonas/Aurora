using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories;

public class AddonRepository : ARepository<Addon>{
    public AddonRepository(AuroraDbContext context) : base(context){
    }
}