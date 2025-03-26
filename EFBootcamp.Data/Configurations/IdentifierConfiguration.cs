using EFBootcamp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFBootcamp.Data.Configurations;

public class IdentifierConfiguration : IEntityTypeConfiguration<Identifier>
{
    public void Configure(EntityTypeBuilder<Identifier> builder)
    {
        builder.HasKey(x => x.Id);
    }
}