using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_piano_house;
using The_piano_house.Core.Entities;
using The_piano_house.Data;
using The_Piano_house.Core.Repositories;

namespace The_Piano_house.Data.Repositories
{
    public class MusicaLInstrumentRepository : IMusicaLInstrumentRepository
    {
        private readonly DataContext _context;
      

     //   public object MusicalInstrumentsList => throw new NotImplementedException();

        public MusicaLInstrumentRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<MusicalInstrument> Get()
        {
            return _context.MusicaLInstruments;
        }

        public MusicalInstrument Get(int id)
        {
            return _context.MusicaLInstruments.Find(id);
        }

        public MusicalInstrument Post( MusicalInstrument m)
        {
            _context.MusicaLInstruments.Add(new MusicalInstrument {Id = _context.index++, Name = m.Name, Manufacturer = m.Manufacturer, CostPrice = m.CostPrice, PurchasePrice = m.PurchasePrice, Stockpile = m.Stockpile, ProviderCode = m.ProviderCode });
            _context.SaveChanges();
            return m;
        }

        public MusicalInstrument Put(int id,  MusicalInstrument m)
        {
            var ev = Get(id);
            ev.Name = m.Name;
            ev.Manufacturer = m.Manufacturer;
            ev.CostPrice = m.CostPrice;
            ev.PurchasePrice = m.PurchasePrice;
            ev.Stockpile = m.Stockpile;
            ev.ProviderCode = m.ProviderCode;
            _context.SaveChanges();
            return ev;
        }
     public void Delete(int id)

     {
         var ev = Get(id);
            _context.MusicaLInstruments.Remove(ev);
            _context.SaveChanges();

        }
}
}
