using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Prpperty_Backend.Models.Configuracion
{
    public class PropertyImageConfig : IEntityTypeConfiguration<PropertyImage>
    {
        public void Configure(EntityTypeBuilder<PropertyImage> builder)
        {
            builder.HasKey(x => x.IdPropertyImage);

            builder.Property(prop => prop.Ruta)
                .HasMaxLength(500);
        }
    }
}
