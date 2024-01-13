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
        private readonly IProviderRepository _providerRepository;

        public ProviderService(IProviderRepository ProviderRepository)
        {
            _providerRepository = ProviderRepository;
        }

        public IEnumerable<Provider> Get()
        {
          return  _providerRepository.Get();
        }

        public Provider Get(int id)
        {
            return _providerRepository.Get(id);
        }

        public Provider Post( Provider p)
        {
         return  _providerRepository.Post(p); 
        }

        public Provider Put(int id, Provider p)
        {
         return   _providerRepository.Put(id, p); 
        }
        public void Delete(int id)
        {
        _providerRepository.Delete(id);  
        }
    }
}
