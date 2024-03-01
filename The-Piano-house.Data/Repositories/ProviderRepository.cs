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
    public class ProviderRepository : IProviderRepository
    {
        private readonly DataContext _context;
      //  public object ProvidersList => throw new NotImplementedException();


        public ProviderRepository(DataContext context)
        {
            _context = context;
        }
        public async Task <IEnumerable<Provider>> Get()
        {
            return await _context.Providers.ToListAsync();
        }

        public async Task  <Provider> Get(int id)
        {
            return await _context.Providers.FindAsync(id);
        }

        public async Task <Provider> Post( Provider p)
        {
            
            _context.Providers.Add( p);
           await  _context.SaveChangesAsync();
            return p;
        }

        public async Task <Provider> Put(int id,  Provider p)
        {
            var ev = await Get(id);
            if (ev != null)
            {
                ev.Name = p.Name;
                ev.Address = p.Address;
                ev.Phone = p.Phone;
                await _context.SaveChangesAsync();
            }
            return ev;

        }
        public async Task Delete(int id)
        {
            var ev =await Get(id);
            _context.Providers.Remove(ev);
           await _context.SaveChangesAsync();

        }
    }
}
