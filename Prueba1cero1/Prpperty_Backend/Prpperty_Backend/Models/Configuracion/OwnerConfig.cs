using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Prpperty_Backend.Models.Configuracion
{
    public class OwnerConfig : IEntityTypeConfiguration<Owner>
    {
        public void Configure(EntityTypeBuilder<Owner> builder)
        {
            builder.HasKey(prop => prop.IdOwner);

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(prop => prop.Address)
                .HasMaxLength(250);

            builder.Property(prop => prop.Photo)
                .HasMaxLength(500);

            builder.Property(prop => prop.Birthday)
                .HasColumnType("date");

        }
    }
}
