using Model.Configuration;
using Model.Entities;

namespace Domain.Repositories;

public class ConvoyElementRepository : ARepository<AConvoyElement>
{
    public ConvoyElementRepository(AuroraDbContext context) : base(context)
    {
    }
}