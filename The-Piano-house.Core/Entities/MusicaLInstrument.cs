﻿using The_Piano_house.Core.Entities;

namespace The_piano_house.Core.Entities
{
    public class MusicalInstrument : BaseModel
    {
     
        public String? Name { get; set; }
        public String? Manufacturer { get; set; }
        public double CostPrice { get; set; }
        public double PurchasePrice { get; set; }
        public int Stockpile { get; set; }
        public int ProviderCode { get; set; }
        public int ProviderId { get; set; }
        public Provider Provider { get; set; }
    }
}
