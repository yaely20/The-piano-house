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
    public class MusicaLInstrumentService : IMusicaLInstrumentService
    {
        private readonly IMusicaLInstrumentRepository _musicaLInstrumentRepository;

        public MusicaLInstrumentService(IMusicaLInstrumentRepository MusicaLInstrumentRepository)
        {
            _musicaLInstrumentRepository = MusicaLInstrumentRepository;
        }
       

        public async Task <IEnumerable<MusicalInstrument>> Get()
        {
            return await _musicaLInstrumentRepository.Get();
        }

        public async Task<MusicalInstrument> Get(int id)
        {
            return await _musicaLInstrumentRepository.Get(id);
        }

        public async Task <MusicalInstrument> Post(MusicalInstrument m)
        {
           return await _musicaLInstrumentRepository.Post(m);   
        }

        public async Task <MusicalInstrument> Put(int id, MusicalInstrument m)
        {
           return  await _musicaLInstrumentRepository.Put(id, m);    
        }
        public async Task Delete(int id)
        {
          await  _musicaLInstrumentRepository.Delete(id);
        }
    }
}
