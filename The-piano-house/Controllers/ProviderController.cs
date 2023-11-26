using Microsoft.AspNetCore.Mvc;
using The_piano_house.Core.Entities;
using The_Piano_house.Core.Services;
using The_Piano_house.Servise;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace The_piano_house.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        private readonly IProviderService _providerService;
        public ProviderController(IProviderService providerService)
        {
            _providerService = providerService;
        }

        // GET: api/<ProviderController>
        [HttpGet]
        public List<Provider> Get()
        {
            return _providerService.Get();
        }

        // GET api/<ProviderController>/5
        [HttpGet("{id}")]
        public ActionResult< Provider> Get(int id)
        {
          
        return    _providerService.Get(id);
            //if (ev == null)
             //   return NotFound();

           //return ev;
        }
        // POST api/<ProviderController>
        [HttpPost]
        public ActionResult Post([FromBody] Provider p)
        {
           // if (p.id.ToString().Length != 9)
            //    return BadRequest();
            _providerService.Post(p);   
            return Ok();
        }

        // PUT api/<ProviderController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Provider p)
        {

           

            //if (ev == null)
            //   return NotFound();
               _providerService.Put(id, p);
            return Ok();
                
            
        }

        // DELETE api/<ProviderController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            

           // if (ev == null)
            //    return NotFound();
           _providerService.Delete(id);
            return Ok();

        }
    }
}
