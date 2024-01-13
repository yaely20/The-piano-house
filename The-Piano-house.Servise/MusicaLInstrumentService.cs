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
       

        public IEnumerable<MusicalInstrument> Get()
        {
            return _musicaLInstrumentRepository.Get();
        }

        public MusicalInstrument Get(int id)
        {
            return _musicaLInstrumentRepository.Get(id);
        }

        public MusicalInstrument Post(MusicalInstrument m)
        {
           return _musicaLInstrumentRepository.Post(m);   
        }

        public MusicalInstrument Put(int id, MusicalInstrument m)
        {
           return _musicaLInstrumentRepository.Put(id, m);    
        }
        public void Delete(int id)
        {
            _musicaLInstrumentRepository.Delete(id);
        }
    }
}
