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
        object CustomersList { get; }

        List<Customers> Get();

        Customers Get(int id);

        void Post([FromBody] Customers c);

        void Put(int id, [FromBody] Customers c);

        void Delete(int id);


    }
}
