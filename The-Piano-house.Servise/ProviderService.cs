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

        public async Task<IEnumerable<Provider>> Get()
        {
          return await _providerRepository.Get();
        }

        public async Task<Provider> Get(int id)
        {
            return await _providerRepository.Get(id);
        }

        public async Task <Provider> Post( Provider p)
        {
         return await _providerRepository.Post(p); 
        }

        public async Task <Provider> Put(int id, Provider p)
        {
         return await  _providerRepository.Put(id, p); 
        }
        public async Task Delete(int id)
        {
            await  _providerRepository.Delete(id);  
        }
    }
}
