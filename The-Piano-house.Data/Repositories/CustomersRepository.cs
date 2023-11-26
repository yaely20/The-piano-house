using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
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
    public class CustomersRepository: ICustomersRepository
    {
        private readonly DataContext _context;

        public object CustomersList => throw new NotImplementedException();

        public CustomersRepository(DataContext context)
        {
            _context = context;
        }

        public List<Customers> Get()
        {
            return _context.CustomersList;
        }
        public Customers Get(int id)
        {
            return _context.CustomersList.First(u => u.id == id);

        }

        public void Post([FromBody] Customers c)
        {
           
            _context.CustomersList.Add(new Customers { id = c.id, name = c.name, phone = c.phone, address = c.address, lastPurchaseDate = c.lastPurchaseDate });
            
        }

        public void Put(int id, [FromBody] Customers c)
        {
            var ev = _context.CustomersList.Find(e => e.id == id);
            ev.name = c.name;
            ev.address = c.address;
            ev.lastPurchaseDate = c.lastPurchaseDate;
            ev.phone = c.phone;
        }
        public void Delete(int id)
        {
            var ev = _context.CustomersList.Find(e => e.id == id);    
            _context.CustomersList.Remove(ev);
           
        }
    }
}
