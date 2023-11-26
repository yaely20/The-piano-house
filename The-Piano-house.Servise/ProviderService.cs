using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_piano_house.Core.Entities;
using The_Piano_house.Core.Repositories;
using The_Piano_house.Core.Services;
using The_Piano_house.Data.Repositories;

namespace The_Piano_house.Servise
{
    public class ProviderService:IProviderService
    {
        private readonly IProviderRepository _ProviderRepository;

        public ProviderService(IProviderRepository ProviderRepository)
        {
            _ProviderRepository = ProviderRepository;
        }

        public List<Provider> Get()
        {
          return  _ProviderRepository.Get();
        }

        public Provider Get(int id)
        {
            return _ProviderRepository.Get(id);
        }

        public void Post([FromBody] Provider p)
        {
           _ProviderRepository.Post(p); 
        }

        public void Put(int id, [FromBody] Provider p)
        {
            _ProviderRepository.Put(id, p); 
        }
        public void Delete(int id)
        {
        _ProviderRepository.Delete(id);  
        }
    }
}
