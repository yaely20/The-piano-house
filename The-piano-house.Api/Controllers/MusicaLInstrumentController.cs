using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using The_piano_house.Core.Entities;
using The_Piano_house.Core.DTOs;
using The_Piano_house.Core.Services;
using The_Piano_house.Servise;
using The_piano_house.Api.Models;
using System.Xml.Linq;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace The_piano_house.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MusicaLInstrumentController : ControllerBase
    {
        private readonly IMusicaLInstrumentService _musicaLInstrumentService;
        private readonly IMapper _mapper;

        public MusicaLInstrumentController(IMusicaLInstrumentService musicaLInstrumentService, IMapper mapper)
        {
            _musicaLInstrumentService = musicaLInstrumentService;
            _mapper = mapper;
        } 
        // GET: api/<MusicaLInstrumentController>
        [HttpGet]
        public async Task <ActionResult<MusicalInstrument>> Get()
        {
            var x = await _musicaLInstrumentService.Get();
            return Ok(_mapper.Map<ActionResult<MusicalInstrumentDTO>>(x));
        }       

        // GET api/<MusicaLInstrumentController>/5
        [HttpGet("{id}")]
        public async Task <ActionResult<MusicalInstrument>> Get(int id)
        {

            var m = await _musicaLInstrumentService.Get(id);
            return  Ok(_mapper.Map<MusicalInstrumentDTO>(m));
           

            //if (ev == null)
            //   return NotFound();
            //return ev;
        }

        // POST api/<MusicaLInstrumentController>
        [HttpPost]
        public async Task <ActionResult> Post([FromBody] MusicalInstrumentPostModel m)
        {
            var newMusicInstrument = new MusicalInstrument();
            _mapper.Map(m, newMusicInstrument);
            await _musicaLInstrumentService.Post(newMusicInstrument);
            return Ok(newMusicInstrument);
        }

        // PUT api/<MusicaLInstrumentController>/5
        [HttpPut("{id}")]
        public async Task <ActionResult> Put(int id, [FromBody] MusicalInstrumentPostModel m)
        {
            var musical = await _musicaLInstrumentService.Get(id);
            if (musical == null)
                            return NotFound();
            _mapper.Map(m, musical);
            return Ok(await _musicaLInstrumentService.Put(id, musical));
            // if (ev == null)
            // return NotFound();

          

        }

        // DELETE api/<MusicaLInstrumentController>/5
        [HttpDelete("{id}")]
        public  async Task <ActionResult> Delete(int id)
        {
            var mu = await _musicaLInstrumentService.Get(id);
            if (mu is null)
            {
                return NotFound();
            }
            await  _musicaLInstrumentService.Delete(id);
            return Ok();
            //if (ev == null)
            //   return NotFound();
        }
    }
}
