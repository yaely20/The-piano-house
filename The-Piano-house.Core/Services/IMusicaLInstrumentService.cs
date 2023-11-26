using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using The_piano_house.Core.Entities;

namespace The_Piano_house.Core.Services
{
    public interface IMusicaLInstrumentService
    {
        List<MusicaLInstrument> Get();

        MusicaLInstrument Get(int id);

        void Post([FromBody] MusicaLInstrument m);

        void Put(int id, [FromBody] MusicaLInstrument m);

        void Delete(int id);
    }
}
