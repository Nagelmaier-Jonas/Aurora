using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories;

public class UpgradeableRepository : ARepository<AUpgradeable>{
    public UpgradeableRepository(AuroraDbContext context) : base(context){
    }
}