using System.Reflection;
using EFBootcamp.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace EFBootcamp.Data;

public class EFDbContext : DbContext
{
    //DbSet
    
    //Constructor Options
    public EFDbContext(DbContextOptions<EFDbContext> options) : base(options)
    {
    }

    //OnModelCreating
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        // modelBuilder.Entity<Item>().HasKey(x => x.Id);
        // modelBuilder.Entity<ItemIdentifier>().HasKey(x => new { x.ItemId, x.IdentifierId });
        // modelBuilder.Entity<ItemStatus>().HasKey(x => x.Id);
        // modelBuilder.Entity<Identifier>().HasKey(x => x.Id);
        // modelBuilder.Entity<IdentifierType>().HasKey(x => x.Id);
        
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        base.OnModelCreating(modelBuilder);
        
    }
}

