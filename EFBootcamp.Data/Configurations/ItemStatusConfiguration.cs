using EFBootcamp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFBootcamp.Data.Configurations;

public class ItemStatusConfiguration : IEntityTypeConfiguration<ItemStatus>
{
    public void Configure(EntityTypeBuilder<ItemStatus> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).ValueGeneratedOnAdd();
        builder.Property(x => x.Name).HasMaxLength(150);
        
        // Seed data
        builder.HasData(GetItemStatuses());
        
        builder.HasMany(x => x.Items)
            .WithOne(x => x.ItemStatus)
            .HasForeignKey(x => x.ItemStatusId);
    }

    private List<ItemStatus> GetItemStatuses()
    {
        return
        [
            new ItemStatus() { Id = 1, Name = "Active" },
            new ItemStatus() { Id = 2, Name = "Inactive" }
        ];
    }
}