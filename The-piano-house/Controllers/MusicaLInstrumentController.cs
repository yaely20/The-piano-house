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
        private readonly IMusicaLInstrumentService _musicaLInstrumentService;
        public MusicaLInstrumentController(IMusicaLInstrumentService musicaLInstrumentService)
        {
            _musicaLInstrumentService = musicaLInstrumentService;
        }
        // GET: api/<MusicaLInstrumentController>
        [HttpGet]
        public List<MusicaLInstrument> Get()
        {
            return  _musicaLInstrumentService.Get();
        }

        // GET api/<MusicaLInstrumentController>/5
        [HttpGet("{id}")]
        public ActionResult< MusicaLInstrument> Get(int id)
        {
           return _musicaLInstrumentService.Get(id);

            //if (ev == null)
            //   return NotFound();
            //return ev;
        }

        // POST api/<MusicaLInstrumentController>
        [HttpPost]
        public void Post([FromBody] MusicaLInstrument m)
        {
            _musicaLInstrumentService.Post(m);  
        }

        // PUT api/<MusicaLInstrumentController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] MusicaLInstrument m)
        {
            
           _musicaLInstrumentService .Put(id, m);
           // if (ev == null)
           // return NotFound();
           
           return Ok();  
            
        }

        // DELETE api/<MusicaLInstrumentController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
           
            _musicaLInstrumentService.Delete(id);
            //if (ev == null)
            //   return NotFound();
           
            return Ok();
        }
    }
}
