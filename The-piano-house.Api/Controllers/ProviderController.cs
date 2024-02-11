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
    public class ProviderController : ControllerBase
    {
        private readonly IProviderService _providerService;
        private readonly IMapper _mapper;

        public ProviderController(IProviderService providerService , IMapper mapper)
        {
            _providerService = providerService;
            _mapper = mapper;
        }

        // GET: api/<ProviderController>
        [HttpGet]
        public async Task <ActionResult<Provider>> Get()
        {
            return Ok(await _providerService.Get());
        }

        // GET api/<ProviderController>/5
        [HttpGet("{id}")]
        public async Task< ActionResult<Provider>> Get(int id)
        {

            return Ok( await _providerService.Get(id));
            //if (ev == null)
            //   return NotFound();

            //return ev;
        }
        // POST api/<ProviderController>
        [HttpPost]
        public async Task <ActionResult> Post([FromBody] ProviderPostModel p)
        {
            var pToadd = new Provider { Name = p.Name, Phone = p.Phone, Address = p.Address };

            var newp = await _providerService.Post(pToadd); 
            var custumerDto = _mapper.Map<ProviderDTO>(newp);
            return Ok(pToadd);
            // if (p.id.ToString().Length != 9)
            //    return BadRequest();
           
           
        }

        // PUT api/<ProviderController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ProviderPostModel p)
        {

            Provider p1 = new Provider();
            p1.Name = p.Name;
            p1.Phone = p.Phone;
            p1.Address = p.Address;
            var newp = await _providerService.Put(id, p1);
            var custumerDto = _mapper.Map<ProviderDTO>(newp);

            //if (ev == null)
            //   return NotFound();
            return Ok(p1 );
        }

        // DELETE api/<ProviderController>/5
        [HttpDelete("{id}")]
        public async Task< ActionResult> Delete(int id)
        {
            var pro = await _providerService.Get(id);
            if (pro is null)
            {
                return NotFound();
            }

         await _providerService.Delete(id);
            return NoContent();
            // if (ev == null)
            //    return NotFound();
        }
    }
}
