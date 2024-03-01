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
using Microsoft.EntityFrameworkCore;

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

        public async  Task< IEnumerable<Customer>> Get()
        {
            return await _context.Customers.ToListAsync();
          //  return await _context.Customers.Include(Customer => Customer.Plan).ToListAsync();

        }

        public async Task <Customer> Get(int id)
        {
            return await _context.Customers.FindAsync(id);


        }

        public async Task<Customer> Post( Customer c)
        {

            _context.Customers.Add(c);
             await   _context.SaveChangesAsync();
            return c;
        }

        public async Task<Customer> Put(int id, Customer c)
        {
            var ev = await Get(id);
            if (ev != null)
            { 
            ev.Name = c.Name;
            ev.Address = c.Address;
            ev.LastPurchaseDate = c.LastPurchaseDate;
            ev.Phone = c.Phone;
            await _context.SaveChangesAsync();
                
            }
        return ev ;
        }
        public async Task  Delete(int id)
        {
            var ev = await Get(id);
            _context.Customers.Remove(ev);
           await _context.SaveChangesAsync();

        }

    }
}
