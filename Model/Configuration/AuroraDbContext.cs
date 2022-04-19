using Microsoft.EntityFrameworkCore;
using Model.Entities;
using Model.Entities.Items;
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

    public DbSet<AItem> Items { get; set; }
    
    public DbSet<Slot> Slots { get; set; }
    
    public DbSet<Cargo> Cargo { get; set; }
    
    public DbSet<ChemicalLiquid> ChemicalLiquids { get; set; }
    
    public DbSet<CrewMember> CrewMembers { get; set; }
    
    public DbSet<Weapon> Weapons { get; set; }
    
    public DbSet<Keyword> Keywords { get; set; }

    public DbSet<AConvoyElement> ConvoyElements{ get; set; }

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
        
        

        builder.Entity<Convoy>()
            .HasOne(u => u.User)
            .WithMany(c => c.Convoys)
            .HasForeignKey(u => u.UserId);

        builder.Entity<User>()
            .HasIndex(u => u.Name)
            .IsUnique();
        
        
        builder.Entity<Slot>()
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
        
        
        
        builder.Entity<ItemHasKeywords>().HasKey(i =>new{i.ItemId, i.KeywordId});
        
        builder.Entity<ItemHasKeywords>()
            .HasOne(i => i.Item)
            .WithMany()
            .HasForeignKey(i => i.ItemId);
        
        builder.Entity<ItemHasKeywords>()
            .HasOne(i => i.Keyword)
            .WithMany()
            .HasForeignKey(i => i.KeywordId);
    }
}