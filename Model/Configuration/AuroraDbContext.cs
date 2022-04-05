using Microsoft.EntityFrameworkCore;
using Model.Entities.Database;

namespace Model.Configuration;

public class AuroraDbContext : DbContext{
    public AuroraDbContext(DbContextOptions<AuroraDbContext> options) : base(options){
    }

    public DbSet<Addon> Addons{ get; set; }
    public DbSet<Convoy> Convoys{ get; set; }
    //public DbSet<Slot> Slots{ get; set; }
    public DbSet<Truck> Trucks{ get; set; }
    //public DbSet<Vehicle> Vehicles{ get; set; }
    public DbSet<Wagon> Wagons{ get; set; }

    protected override void OnModelCreating(ModelBuilder builder){
        // builder.Entity<User>().HasIndex(u => u.Username).IsUnique(); Example

        // builder.Entity<Item>().HasOne(i => i.Creator).WithMany().HasForeignKey(i => i.CreatorId); Example

        // builder.Entity<Bid>().HasKey(b => new {b.ItemId, b.UserId}); Example
        // builder.Entity<Bid>().HasOne(u => u.User).WithMany().HasForeignKey(u => u.UserId); Example
        // builder.Entity<Bid>().HasOne(i => i.Item).WithMany().HasForeignKey(i => i.ItemId); Example

        builder.Entity<Wagon>().HasOne(t => t.Truck).WithMany().HasForeignKey(t => t.TruckId);
        builder.Entity<Convoy>()
            .HasOne(c => c.BackTruck)
            .WithOne()
            .HasForeignKey<Convoy>(c => c.BackTruckId);

        builder.Entity<Convoy>()
            .HasOne(c => c.FrontTruck)
            .WithOne()
            .HasForeignKey<Convoy>(c => c.FrontTruckId);
        //builder.Entity<Slot>().HasOne(v=>v.Vehicle).WithMany().HasForeignKey(v=>v.VehicleId);
    }
}