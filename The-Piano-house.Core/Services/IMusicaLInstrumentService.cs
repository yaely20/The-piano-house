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
        Task<IEnumerable<MusicalInstrument>> Get();

        Task<MusicalInstrument> Get(int id);

        Task<MusicalInstrument> Post(MusicalInstrument m);

        Task<MusicalInstrument> Put(int id, MusicalInstrument m);

        Task Delete(int id);
    }
}
