using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Model.Entities.Cargo;
using Model.Entities.Cargo.Implementation;
using Model.Entities.Slots;
using Model.Entities.Slots.Implementation;

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
    
    public DbSet<User> Users { get; set; }

    public DbSet<ACargo> Items { get; set; }
    
    public DbSet<ASlot> Slots { get; set; }

    public DbSet<Keyword> Keywords { get; set; }

    public DbSet<AConvoyElement> ConvoyElements{ get; set; }
    
    public DbSet<Session> Sessions{ get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Wagon>()
            .HasOne(t => t.Truck)
            .WithMany(e => e.Wagons)
            .HasForeignKey(t => t.TruckId).OnDelete(DeleteBehavior.Cascade);
        
        

        builder.Entity<Convoy>()
            .HasOne(c => c.BackTruck)
            .WithOne()
            .HasForeignKey<Convoy>(c => c.BackTruckId).OnDelete(DeleteBehavior.Cascade);;

        builder.Entity<Convoy>()
            .HasOne(c => c.FrontTruck)
            .WithOne()
            .HasForeignKey<Convoy>(c => c.FrontTruckId).OnDelete(DeleteBehavior.Cascade);;
        
        

        builder.Entity<AUpgradeable>()
            .HasOne(a => a.Addon)
            .WithOne(n => n.Upgradeable)
            .HasForeignKey<AUpgradeable>(a => a.AddonId).OnDelete(DeleteBehavior.Cascade);;
        

        builder.Entity<User>()
            .HasIndex(u => u.Name)
            .IsUnique();
        
        
        builder.Entity<ASlot>()
            .HasOne(e => e.Element)
            .WithMany(s => s.Slots)
            .HasForeignKey(e => e.ElementId).OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Keyword>()
            .HasOne(c => c.Cargo)
            .WithMany(k => k.Keywords)
            .HasForeignKey(k => k.CargoId).OnDelete(DeleteBehavior.Cascade);

        builder.Entity<Session>()
            .HasOne(s => s.User)
            .WithMany(u => u.Sessions)
            .HasForeignKey(s => s.UserId).OnDelete(DeleteBehavior.Cascade);
        
        builder.Entity<Session>()
            .HasOne(s => s.Convoy)
            .WithOne(n => n.Session)
            .HasForeignKey<Session>(s => s.ConvoyId).OnDelete(DeleteBehavior.Cascade);
        
        builder.Entity<ACargo>()
            .HasOne(n => n.Slot)
            .WithOne(n => n.Cargo)
            .HasForeignKey<ACargo>(n=> n.SlotId);
        

        builder.Entity<ACargo>()
            .HasDiscriminator<string>("CARGO_TYPE")
            .HasValue<CrewCargo>(nameof(CrewCargo))
            .HasValue<FuelCargo>(nameof(FuelCargo))
            .HasValue<StandardCargo>(nameof(StandardCargo))
            .HasValue<ArmorCargo>(nameof(ArmorCargo))
            .HasValue<WeaponCargo>(nameof(WeaponCargo));


        builder.Entity<ASlot>()
            .HasDiscriminator<string>("SLOT_TYPE")
            .HasValue<CrewSlot>(nameof(CrewSlot))
            .HasValue<FuelSlot>(nameof(FuelSlot))
            .HasValue<StandardSlot>(nameof(StandardSlot))
            .HasValue<WeaponSlot>(nameof(WeaponSlot))
            .HasValue<ArmorSlot>(nameof(ArmorSlot));
    }
}