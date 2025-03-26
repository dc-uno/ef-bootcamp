using EFBootcamp.Data.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EFBootcamp.Data.Configurations;

public class IdentifierTypeConfiguration : IEntityTypeConfiguration<IdentifierType>
{
    public void Configure(EntityTypeBuilder<IdentifierType> builder)
    {
        builder.HasKey(x => x.Id);
        builder.Property(x => x.Id).IsRequired();
        
        builder.HasData(GetIdentifierTypes());
    }
    
    private List<IdentifierType> GetIdentifierTypes()
    {
        return
        [
            new IdentifierType() { Id = 1, Name = "RFID" },
            new IdentifierType() { Id = 2, Name = "QR" }
        ];
    }
}