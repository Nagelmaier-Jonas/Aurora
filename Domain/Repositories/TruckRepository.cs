using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories;

public class TruckRepository : ARepository<Truck>
{
    public TruckRepository(AuroraDbContext context) : base(context)
    {
    }
}