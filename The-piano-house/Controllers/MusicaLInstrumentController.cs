using Microsoft.AspNetCore.Mvc;
using The_piano_house.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace The_piano_house.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicaLInstrumentController : ControllerBase
    {
        public static List<MusicaLInstrument> _musicaLInstrument = new List<MusicaLInstrument>();
        public static int index = 0;

        // GET: api/<MusicaLInstrumentController>
        [HttpGet]
        public List<MusicaLInstrument> Get()
        {
            return _musicaLInstrument;
        }

        // GET api/<MusicaLInstrumentController>/5
        [HttpGet("{id}")]
        public MusicaLInstrument Get(int id)
        {
            for (int i = 0; i < index; i++)
            {
                if (_musicaLInstrument[i].code==id)
                    return _musicaLInstrument[i];
            }
            return null;
        }

        // POST api/<MusicaLInstrumentController>
        [HttpPost]
        public void Post([FromBody] MusicaLInstrument m)
        {
            _musicaLInstrument.Add(new MusicaLInstrument {code = index++, name = m.name, manufacturer = m.manufacturer, costPrice = m.costPrice, purchasePrice = m.purchasePrice, stockpile = m.stockpile, providerCode = m.providerCode });
        }

        // PUT api/<MusicaLInstrumentController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] MusicaLInstrument m)
        {
            for (int i = 0; i < index; i++)
            {
                if (_musicaLInstrument[i].code==id)
                {
                    _musicaLInstrument[i].name = m.name;
                    _musicaLInstrument[i].manufacturer = m.manufacturer;
                    _musicaLInstrument[i].costPrice = m.costPrice;
                    _musicaLInstrument[i].purchasePrice = m.purchasePrice;
                    _musicaLInstrument[i].stockpile = m.stockpile;
                    _musicaLInstrument[i].providerCode = m.providerCode;
                }
            }
        }

        // DELETE api/<MusicaLInstrumentController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (MusicaLInstrument item in _musicaLInstrument)
            {
                if(item.code== id)
                {
                    _musicaLInstrument.Remove(item);
                    break;
                        }
            }
        }
    }
}
