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
    public class ProviderRepository : IProviderRepository
    {
        private readonly DataContext _context;

        public ProviderRepository(DataContext context)
        {
            _context = context;
        }
        public List<Provider> Get()
        {
            return _context.ProviderList;
        }

        public Provider Get(int id)
        {
            return _context.ProviderList.First(u => u.id == id);
        }

        public void Post([FromBody] Provider p)
        {
            
            _context.ProviderList.Add(new Provider { id = p.id, name = p.name, phone = p.phone, address = p.address });
        }

        public void Put(int id, [FromBody] Provider p)
        {
            var ev = _context.ProviderList.Find(e => e.id == id);
            ev.name = p.name;
            ev.address = p.address;
            ev.phone = p.phone;

        }
        public void Delete(int id)
        {
            var ev = _context.ProviderList.Find(e => e.id == id);
            _context.ProviderList.Remove(ev);
          
        }
    }
}
