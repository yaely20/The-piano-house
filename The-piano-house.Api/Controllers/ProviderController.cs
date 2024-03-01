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
            var x = await _providerService.Get();
            return Ok( _mapper.Map<List<ProviderDTO>>(x));
        }

        // GET api/<ProviderController>/5
        [HttpGet("{id}")]
        public async Task< ActionResult<Provider>> Get(int id)
        {
            var provider = await _providerService.Get(id);
            return Ok(_mapper.Map<ProviderDTO>(provider));
            //if (ev == null)
            //   return NotFound();

            //return ev;
        }
        // POST api/<ProviderController>
        [HttpPost]
        public async Task <ActionResult> Post([FromBody] ProviderPostModel p)
        {
            Provider newProvider = new Provider();
            _mapper.Map(p, newProvider);
            await _providerService.Post(newProvider);
            return Ok(newProvider);
            // if (p.id.ToString().Length != 9)
            //    return BadRequest();
           
           
        }

        // PUT api/<ProviderController>/5
        [HttpPut("{id}")]
        public async Task<ActionResult> Put(int id, [FromBody] ProviderPostModel p)
        {

            var provider = await _providerService.Get(id);
            if (provider == null)
                return NotFound();
            _mapper.Map(p, provider);
            return Ok(    await _providerService.Put(id, provider));

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
            return Ok();
            // if (ev == null)
            //    return NotFound();
        }
    }
}
