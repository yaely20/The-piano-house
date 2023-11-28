using Microsoft.AspNetCore.Mvc;
using The_piano_house.Core.Entities;
using The_Piano_house.Core.Services;
using The_Piano_house.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace The_piano_house.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicaLInstrumentController : ControllerBase
    {
<<<<<<< HEAD
        private readonly IMusicaLInstrumentService _musicaLInstrumentService;
        public MusicaLInstrumentController(IMusicaLInstrumentService musicaLInstrumentService)
        {
            _musicaLInstrumentService = musicaLInstrumentService;
=======
        private readonly DataContext _conect;
        public MusicaLInstrumentController(DataContext conect)
        {
            _conect = conect;
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
        }
        // GET: api/<MusicaLInstrumentController>
        [HttpGet]
        public List<MusicaLInstrument> Get()
        {
<<<<<<< HEAD
            return  _musicaLInstrumentService.Get();
=======
            return  _conect.MusicaLInstrumentList;
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
        }

        // GET api/<MusicaLInstrumentController>/5
        [HttpGet("{id}")]
        public ActionResult< MusicaLInstrument> Get(int id)
        {
<<<<<<< HEAD
           return _musicaLInstrumentService.Get(id);

            //if (ev == null)
            //   return NotFound();
            //return ev;
=======
            var ev = _conect.MusicaLInstrumentList.Find(e => e.code == id);

            if (ev == null)
                return NotFound();

            return ev;
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
        }

        // POST api/<MusicaLInstrumentController>
        [HttpPost]
        public void Post([FromBody] MusicaLInstrument m)
        {
<<<<<<< HEAD
            _musicaLInstrumentService.Post(m);  
=======

            _conect.MusicaLInstrumentList.Add(new MusicaLInstrument {code = _conect.index++, name = m.name, manufacturer = m.manufacturer, costPrice = m.costPrice, purchasePrice = m.purchasePrice, stockpile = m.stockpile, providerCode = m.providerCode });
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
        }

        // PUT api/<MusicaLInstrumentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] MusicaLInstrument m)
        {
<<<<<<< HEAD
            
           _musicaLInstrumentService .Put(id, m);
           // if (ev == null)
           // return NotFound();
           
           return Ok();  
=======
            var ev = _conect.MusicaLInstrumentList.Find(e => e.code == id);

            if (ev == null)
                return NotFound();
            ev.name = m.name;
            ev.manufacturer = m.manufacturer;
            ev.costPrice = m.costPrice;
            ev.purchasePrice = m.purchasePrice;
            ev.stockpile = m.stockpile;
            ev.providerCode = m.providerCode;
            return Ok();  
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
            
        }

        // DELETE api/<MusicaLInstrumentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
<<<<<<< HEAD
           
            _musicaLInstrumentService.Delete(id);
            //if (ev == null)
            //   return NotFound();
           
=======
            var ev = _conect.MusicaLInstrumentList.Find(e => e.code == id);

            if (ev == null)
                return NotFound();
            _conect.MusicaLInstrumentList.Remove(ev);
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
            return Ok();
        }
    }
}
