namespace Prpperty_Backend.Models
{
    public class PropertyTrace
    {
        public int IdPropertyTrace { get; set; }
        public DateTime DateSale { get; set; }
        public string Name { get; set; }
        public decimal Value { get; set; }
        public decimal Tax { get; set; }
        public Property property { get; set; }

    }
}
