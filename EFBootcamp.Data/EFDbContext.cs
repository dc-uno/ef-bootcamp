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
        base.OnModelCreating(modelBuilder);
    }
}