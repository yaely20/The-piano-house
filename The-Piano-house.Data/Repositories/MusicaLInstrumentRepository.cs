using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        public async Task < IEnumerable<MusicalInstrument>> Get()
        {
            return await _context.MusicaLInstruments.ToListAsync();
        }

        public async Task <MusicalInstrument> Get(int id)
        {
            return await _context.MusicaLInstruments.FindAsync(id);
        }

        public async Task< MusicalInstrument> Post( MusicalInstrument m)
        {
            _context.MusicaLInstruments.Add(m);
          await  _context.SaveChangesAsync();
            return m;
        }

        public async Task< MusicalInstrument> Put(int id,  MusicalInstrument m)
        {
            var ev = await Get(id);
            if (ev != null)
            {
                ev.Name = m.Name;
                ev.Manufacturer = m.Manufacturer;
                ev.CostPrice = m.CostPrice;
                ev.PurchasePrice = m.PurchasePrice;
                ev.Stockpile = m.Stockpile;
                ev.ProviderCode = m.ProviderCode;
                await _context.SaveChangesAsync();
            }
            return ev;
        }
     public async Task Delete(int id)
     {
         var ev = await Get(id);
            _context.MusicaLInstruments.Remove(ev);
          await  _context.SaveChangesAsync();

        }
}
}
