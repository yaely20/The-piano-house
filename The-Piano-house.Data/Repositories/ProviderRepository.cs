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
      //  public object ProvidersList => throw new NotImplementedException();


        public ProviderRepository(DataContext context)
        {
            _context = context;
        }
        public IEnumerable<Provider> Get()
        {
            return _context.Providers;
        }

        public Provider Get(int id)
        {
            return _context.Providers.Find(id);
        }

        public Provider Post( Provider p)
        {
            
            _context.Providers.Add(new Provider { Id = p.Id, Name = p.Name, Phone = p.Phone, Address = p.Address });
            _context.SaveChanges();
            return p;
        }

        public Provider Put(int id,  Provider p)
        {
            var ev = Get(id);
            ev.Name = p.Name;
            ev.Address = p.Address;
            ev.Phone = p.Phone;
            _context.SaveChanges();
            return ev;

        }
        public void Delete(int id)
        {
            var ev = Get(id);
            _context.Providers.Remove(ev);
            _context.SaveChanges();

        }
    }
}
