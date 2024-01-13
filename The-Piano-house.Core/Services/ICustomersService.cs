using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_piano_house.Core.Entities;

namespace The_Piano_house.Core.Services
{
    public interface ICustomersService
    {
        IEnumerable<Customer> Get();

        Customer Get(int id);

        Customer Post([FromBody] Customer c);

        Customer Put(int id, [FromBody] Customer c);

        void Delete(int id);



    }
}
