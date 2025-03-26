using EFBootcamp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFBootcamp.Data.Configurations;

public class ItemIdentifierConfiguration : IEntityTypeConfiguration<ItemIdentifier>
{
    public void Configure(EntityTypeBuilder<ItemIdentifier> builder)
    {
        builder.HasKey(x => new { x.ItemId, x.IdentifierId });
    }
}