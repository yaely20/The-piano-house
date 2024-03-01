namespace The_piano_house.Api.Models
{
    public class MusicalInstrumentPostModel
    {
        public String? Name { get; set; }
        public String? Manufacturer { get; set; }
        public double CostPrice { get; set; }
        public double PurchasePrice { get; set; }
        public int Stockpile { get; set; }
        public int ProviderId { get; set; }
    }
}
