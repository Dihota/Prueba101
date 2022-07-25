

namespace Prpperty_Backend.Models
{
    public class Property
    {
     
        public int IdProperty { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public decimal Price { get; set; }
        public int CodeInternal { get; set; }
        public int Year { get; set; }
        public int ownerIdOwner { get; set; }
        public Owner owner { get; set; }
        public List<PropertyImage> propertyImage { get; set; }
        public List<PropertyTrace> propertyTrace { get; set; }

    }
}
