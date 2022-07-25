using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Prpperty_Backend.Models.Configuracion
{
    public class PropertyTraceConfig : IEntityTypeConfiguration<PropertyTrace>
    {
        public void Configure(EntityTypeBuilder<PropertyTrace> builder)
        {
            builder.HasKey(x => x.IdPropertyTrace);

            builder.Property(prop => prop.DateSale)
                .HasColumnType("date");

            builder.Property(prop => prop.Name)
                .HasMaxLength(200);

            builder.Property(prop => prop.Value)
                .HasPrecision(precision:15, scale:2);

            builder.Property(prop => prop.Tax)
                .HasPrecision(precision: 5, scale: 2);


        }
    }
}
