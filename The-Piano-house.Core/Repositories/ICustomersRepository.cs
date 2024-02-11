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

        Task<IEnumerable<Customer>> Get();

        Task<Customer> Get(int id);

        Task<Customer> Post(Customer c);

        Task<Customer> Put(int id, Customer c);

        Task Delete(int id);

    }
}
