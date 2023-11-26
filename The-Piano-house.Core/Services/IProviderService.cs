using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_piano_house.Core.Entities;

namespace The_Piano_house.Core.Services
{
    public interface IProviderService
    {
        List<Provider> Get();

        Provider Get(int id);

        void Post([FromBody] Provider p);

        void Put(int id, [FromBody] Provider p);

        void Delete(int id);

    }
}
