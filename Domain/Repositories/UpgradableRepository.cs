using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories;

public class UpgradableRepository : ARepository<AUpgradableElement>{
    public UpgradableRepository(AuroraDbContext context) : base(context){
    }
}