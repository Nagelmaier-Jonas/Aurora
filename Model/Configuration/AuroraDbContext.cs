using Microsoft.EntityFrameworkCore;
using Model.Entities;

namespace Model.Configuration;

public class AuroraDbContext : DbContext
{
    public AuroraDbContext(DbContextOptions<AuroraDbContext> options) : base(options)
    {
    }

    public DbSet<Addon> Addons { get; set; }

    public DbSet<Convoy> Convoys { get; set; }

    public DbSet<Truck> Trucks { get; set; }

    public DbSet<Wagon> Wagons { get; set; }

    public DbSet<AUpgradeable> Upgradeables { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Wagon>().HasOne(t => t.Truck).WithMany(e => e.Wagons).HasForeignKey(t => t.TruckId);

        builder.Entity<Convoy>()
            .HasOne(c => c.BackTruck)
            .WithOne()
            .HasForeignKey<Convoy>(c => c.BackTruckId);

        builder.Entity<Convoy>()
            .HasOne(c => c.FrontTruck)
            .WithOne()
            .HasForeignKey<Convoy>(c => c.FrontTruckId);

        builder.Entity<AUpgradeable>()
            .HasOne(a => a.Addon)
            .WithOne()
            .HasForeignKey<AUpgradeable>(a => a.AddonId);
    }
}