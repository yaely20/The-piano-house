namespace The_piano_house.Core.Entities
{
    public class MusicaLInstrument
    {
        public int code  { get; set; }
        public String?     name   { get; set; }
        public String? manufacturer   { get; set; }
        public double costPrice  { get; set; }
        public double purchasePrice { get; set; }
        public int stockpile  { get; set; }
        public int providerCode { get; set; }

       
    }
}
