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

        public MusicaLInstrumentRepository(DataContext context)
        {
            _context = context;
        }

        public List<MusicaLInstrument> Get()
        {
            return _context.MusicaLInstrumentList;
        }

        public MusicaLInstrument Get(int id)
        {
            return _context.MusicaLInstrumentList.First(u => u.code== id);
        }

        public void Post([FromBody] MusicaLInstrument m)
        {
            _context.MusicaLInstrumentList.Add(new MusicaLInstrument {code = _context.index++, name = m.name, manufacturer = m.manufacturer, costPrice = m.costPrice, purchasePrice = m.purchasePrice, stockpile = m.stockpile, providerCode = m.providerCode });

        }

        public void Put(int id, [FromBody] MusicaLInstrument m)
        {
            var ev = _context.MusicaLInstrumentList.Find(e => e.code == id);
            ev.name = m.name;
            ev.manufacturer = m.manufacturer;
            ev.costPrice = m.costPrice;
            ev.purchasePrice = m.purchasePrice;
            ev.stockpile = m.stockpile;
            ev.providerCode = m.providerCode;
        }
     public void Delete(int id)

     {
         var ev = _context.MusicaLInstrumentList.Find(e => e.code == id);
        _context.MusicaLInstrumentList.Remove(ev);
           
     }
}
}
