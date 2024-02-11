using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_piano_house.Core.Entities;

namespace The_Piano_house.Core.Repositories
{
    public interface IProviderRepository
    {
        //  object ProvidersList { get; }
        Task<IEnumerable<Provider>> Get();

        Task<Provider> Get(int id);

       Task<Provider> Post(Provider p);

        Task<Provider> Put(int id, Provider p);

        Task Delete(int id);

    }
}
