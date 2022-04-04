using Microsoft.EntityFrameworkCore;

namespace Model.Configuration;

public class AuroraDbContext : DbContext{
    public AuroraDbContext(DbContextOptions<AuroraDbContext> options) : base(options){
    }

    // public DbSet<User> Users{ get; set; } Example

    protected override void OnModelCreating(ModelBuilder builder){
        // builder.Entity<User>().HasIndex(u => u.Username).IsUnique(); Example

        // builder.Entity<Item>().HasOne(i => i.Creator).WithMany().HasForeignKey(i => i.CreatorId); Example

        // builder.Entity<Bid>().HasKey(b => new {b.ItemId, b.UserId}); Example
        // builder.Entity<Bid>().HasOne(u => u.User).WithMany().HasForeignKey(u => u.UserId); Example
        // builder.Entity<Bid>().HasOne(i => i.Item).WithMany().HasForeignKey(i => i.ItemId); Example
    }
}