using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_piano_house.Core.Entities;
using The_Piano_house.Core.Repositories;
using The_Piano_house.Core.Services;

namespace The_Piano_house.Servise
{
    public class CustomersService:ICustomersService
    {
        private readonly ICustomersRepository _customersRepository;

        public CustomersService(ICustomersRepository customersRepository)
        {
            _customersRepository = customersRepository;
        }
        public async Task<  IEnumerable<Customer>> Get()
        {
            return await _customersRepository.Get();
        }
        //public ActionResult<Customers> Get(int id)
           public async Task< Customer> Get(int id)
        {
           return await _customersRepository.Get(id);
            //var e= _customersRepository.Get(id);

            // if (e == null)
            //   return NotFound();
              

            //return e;
        }
    

        public async Task <Customer> Post(Customer c)
        {
           return await _customersRepository.Post(c);
        }

        public async Task <Customer> Put(int id,  Customer c)
        {
          return await _customersRepository.Put(id, c);
        }
        public async Task Delete(int id)
        {
              await  _customersRepository.Delete(id);
        }
    }
}
