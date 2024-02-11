using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using The_piano_house.Core.Entities;
using The_Piano_house.Core.DTOs;
using The_Piano_house.Core.Services;
using The_Piano_house.Servise;
using The_piano_house.Api.Models;


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
            return Ok (await _musicaLInstrumentService.Get());
        }

        // GET api/<MusicaLInstrumentController>/5
        [HttpGet("{id}")]
        public async Task <ActionResult<MusicalInstrument>> Get(int id)
        {
            return Ok( await _musicaLInstrumentService.Get(id));

            //if (ev == null)
            //   return NotFound();
            //return ev;
        }

        // POST api/<MusicaLInstrumentController>
        [HttpPost]
        public async Task <ActionResult> Post([FromBody] MusicalInstrumentPostModel m)
        {
            var mToAdd = new MusicalInstrument { Name = m.Name, Manufacturer = m.Manufacturer, CostPrice = m.CostPrice, PurchasePrice=m.PurchasePrice, Stockpile=m.Stockpile,ProviderId=m.ProviderId };

            var newm = await _musicaLInstrumentService.Post(mToAdd);
            var mDto = _mapper.Map<MusicalInstrumentDTO>(newm);
            return Ok(mToAdd);

          
        }

        // PUT api/<MusicaLInstrumentController>/5
        [HttpPut("{id}")]
        public async Task <ActionResult> Put(int id, [FromBody] MusicalInstrumentPostModel m)
        {
           MusicalInstrument mmm=new MusicalInstrument();
            mmm.Name = m.Name;  
            mmm.Manufacturer = m.Manufacturer;
            mmm.CostPrice = m.CostPrice;
            mmm.PurchasePrice = m.PurchasePrice;
            mmm.Stockpile = m.Stockpile;   
            mmm.ProviderId = m.ProviderId;
            var newmm = await _musicaLInstrumentService.Put(id, mmm);
            var mDto = _mapper.Map<MusicalInstrumentDTO>(newmm);
            return Ok(mmm);
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
            return NoContent();
            //if (ev == null)
            //   return NotFound();
        }
    }
}
