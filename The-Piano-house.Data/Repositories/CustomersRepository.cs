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
    public class CustomersRepository : ICustomersRepository
    {
        private readonly DataContext _context;

    //    public object CustomersList => throw new NotImplementedException();

        public CustomersRepository(DataContext context)
        {
            _context = context;
        }

        public IEnumerable<Customer> Get()
        {
            return _context.Customers;
        }

        public Customer Get(int id)
        {
            return _context.Customers.Find(id);


        }

        public Customer Post( Customer c)
        {

            _context.Customers.Add(new Customer { Id = c.Id, Name = c.Name, Phone = c.Phone, Address = c.Address, LastPurchaseDate = c.LastPurchaseDate });
            _context.SaveChanges();
            return c;
        }

        public Customer Put(int id, Customer c)
        {
            var ev = Get(id);
            ev.Name = c.Name;
            ev.Address = c.Address;
            ev.LastPurchaseDate = c.LastPurchaseDate;
            ev.Phone = c.Phone;
            _context.SaveChanges();
            return ev;
        }
        public void Delete(int id)
        {
            var ev = Get(id);
            _context.Customers.Remove(ev);
            _context.SaveChanges();

        }

    }
}
