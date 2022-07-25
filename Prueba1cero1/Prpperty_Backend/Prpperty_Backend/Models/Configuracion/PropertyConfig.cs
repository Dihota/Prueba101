using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Prpperty_Backend.Models.Configuracion
{
    public class PropertyConfig : IEntityTypeConfiguration<Property>
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasKey(x => x.IdProperty);

            builder.Property(prop => prop.Name)
                .IsRequired()
                .HasMaxLength(200);

            builder.Property(prop => prop.Address)
                .HasMaxLength(250)
                .IsUnicode(true);

            builder.Property(prop => prop.Price)
                .HasPrecision(precision:15,scale:2);
        }
    }
}
