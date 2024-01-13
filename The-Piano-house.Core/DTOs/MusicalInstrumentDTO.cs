using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_piano_house.Core.Entities;

namespace The_Piano_house.Core.DTOs
{
    public class MusicalInstrumentDTO
    {
        public int Id { get; set; }

        public String? Name { get; set; }
        public String? Manufacturer { get; set; }
        public double CostPrice { get; set; }
        public double PurchasePrice { get; set; }
        public int Stockpile { get; set; }
       
        public int ProviderId { get; set; }
        public ProviderDTO Provider { get; set; }
    }
}
