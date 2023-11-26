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
        private readonly IMusicaLInstrumentRepository _MusicaLInstrumentRepository;

        public MusicaLInstrumentService(IMusicaLInstrumentRepository MusicaLInstrumentRepository)
        {
            _MusicaLInstrumentRepository = MusicaLInstrumentRepository;
        }
       

        public List<MusicaLInstrument> Get()
        {
            return _MusicaLInstrumentRepository.Get();
        }

        public MusicaLInstrument Get(int id)
        {
            return _MusicaLInstrumentRepository.Get(id);
        }

        public void Post([FromBody] MusicaLInstrument m)
        {
            _MusicaLInstrumentRepository.Post(m);   
        }

        public void Put(int id, [FromBody] MusicaLInstrument m)
        {
            _MusicaLInstrumentRepository.Put(id, m);    
        }
        public void Delete(int id)
        {
            _MusicaLInstrumentRepository.Delete(id);
        }
    }
}
