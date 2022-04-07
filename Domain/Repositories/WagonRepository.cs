using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories;

public class WagonRepository : ARepository<Wagon>
{
    public WagonRepository(AuroraDbContext context) : base(context)
    {
    }
}