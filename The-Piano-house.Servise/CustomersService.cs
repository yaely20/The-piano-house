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
        public   IEnumerable<Customer> Get()
        {
            return _customersRepository.Get();
        }
        //public ActionResult<Customers> Get(int id)
           public Customer Get(int id)
        {
           return _customersRepository.Get(id);
            //var e= _customersRepository.Get(id);

            // if (e == null)
            //   return NotFound();
              

            //return e;
        }
    

        public Customer Post(Customer c)
        {
           return _customersRepository.Post(c);
        }

        public Customer Put(int id,  Customer c)
        {
          return _customersRepository.Put(id, c);
        }
        public void Delete(int id)
        {
            _customersRepository.Delete(id);
        }
    }
}
