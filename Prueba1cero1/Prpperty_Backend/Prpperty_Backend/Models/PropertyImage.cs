namespace Prpperty_Backend.Models
{
    public class PropertyImage
    {
        public int IdPropertyImage { get; set; }
        public string Ruta { get; set; }
        public bool Enabled { get; set; }
        public int propertyIdProperty { get; set; }
        public Property property { get; set; }

    }
}
