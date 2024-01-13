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
        IEnumerable<MusicalInstrument> Get();

        MusicalInstrument Get(int id);

        MusicalInstrument Post([FromBody] MusicalInstrument m);

        MusicalInstrument Put(int id, [FromBody] MusicalInstrument m);

        void Delete(int id);
    }
}
