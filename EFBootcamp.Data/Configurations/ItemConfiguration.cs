using EFBootcamp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFBootcamp.Data.Configurations;

public class ItemConfiguration : IEntityTypeConfiguration<Item> 
{
    public void Configure(EntityTypeBuilder<Item> builder)
    {
        builder.HasKey(x => x.Id);
    }
}