using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Model.Entities.Cargo;
using Model.Entities.Slots;

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

    public DbSet<CargosJtKeywords> CargosJtKeywords{ get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.Entity<Wagon>()
            .HasOne(t => t.Truck)
            .WithMany(e => e.Wagons)
            .HasForeignKey(t => t.TruckId);
        
        

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
        

        builder.Entity<User>()
            .HasIndex(u => u.Name)
            .IsUnique();
        
        
        builder.Entity<ASlot>()
            .HasOne(e => e.Element)
            .WithMany(s => s.Slots)
            .HasForeignKey(e => e.ElementId);


        builder.Entity<ConvoyElementHasKeywords>().HasKey(c =>new{c.ElementId, c.KeywordId});
        
        builder.Entity<ConvoyElementHasKeywords>()
            .HasOne(c => c.Element)
            .WithMany()
            .HasForeignKey(c => c.ElementId);
        
        builder.Entity<ConvoyElementHasKeywords>()
            .HasOne(c => c.Keyword)
            .WithMany()
            .HasForeignKey(c => c.KeywordId);
        
        
        
        builder.Entity<CargosJtKeywords>().HasKey(i =>new{i.CargoId, i.KeywordId});
        
        builder.Entity<CargosJtKeywords>()
            .HasOne(i => i.Cargo)
            .WithMany(k => k.Keywords)
            .HasForeignKey(i => i.CargoId);
        
        builder.Entity<CargosJtKeywords>()
            .HasOne(i => i.Keyword)
            .WithMany()
            .HasForeignKey(i => i.KeywordId);


        builder.Entity<Session>()
            .HasOne(s => s.User)
            .WithMany(u => u.Sessions)
            .HasForeignKey(s => s.UserId);
        builder.Entity<Session>()
            .HasOne(s => s.Convoy)
            .WithOne()
            .HasForeignKey<Session>(s => s.ConvoyId);
        
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