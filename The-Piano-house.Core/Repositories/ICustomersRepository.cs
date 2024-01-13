using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_piano_house.Core.Entities;


namespace The_Piano_house.Core.Repositories
{
    public interface ICustomersRepository
    {
       // object CustomersList { get; }

        IEnumerable<Customer> Get();

        Customer Get(int id);

        Customer Post( Customer c);

        Customer Put(int id, [FromBody] Customer c);

        void Delete(int id);


    }
}
