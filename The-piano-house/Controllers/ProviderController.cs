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
<<<<<<< HEAD
        private readonly IProviderService _providerService;
        public ProviderController(IProviderService providerService)
        {
            _providerService = providerService;
=======
        private readonly DataContext _conect;
        public ProviderController(DataContext conect)
        {
            _conect = conect;
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
        }

        // GET: api/<ProviderController>
        [HttpGet]
        public List<Provider> Get()
        {
<<<<<<< HEAD
            return _providerService.Get();
=======
            return _conect.ProviderList ;
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
        }

        // GET api/<ProviderController>/5
        [HttpGet("{id}")]
        public ActionResult< Provider> Get(int id)
        {
<<<<<<< HEAD
          
        return    _providerService.Get(id);
            //if (ev == null)
             //   return NotFound();

           //return ev;
=======
            var ev = _conect.ProviderList.Find(e => e.id == id);

            if (ev == null)
                return NotFound();

            return ev;
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
        }
        // POST api/<ProviderController>
        [HttpPost]
        public ActionResult Post([FromBody] Provider p)
        {
<<<<<<< HEAD
           // if (p.id.ToString().Length != 9)
            //    return BadRequest();
            _providerService.Post(p);   
=======
            if (p.id.ToString().Length != 9)
                return BadRequest();

            _conect.ProviderList.Add(new Provider { id =p.id, name = p.name, phone = p.phone, address = p.address });
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
            return Ok();
        }

        // PUT api/<ProviderController>/5
        [HttpPut("{id}")]
        public ActionResult Put(int id, [FromBody] Provider p)
        {

<<<<<<< HEAD
           

            //if (ev == null)
            //   return NotFound();
               _providerService.Put(id, p);
=======
            var ev = _conect.ProviderList.Find(e => e.id == id);

            if (ev == null)
                return NotFound();
                  ev.name = p.name;
                  ev.address = p.address;
                  ev.phone = p.phone;
                  
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
            return Ok();
                
            
        }

        // DELETE api/<ProviderController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
<<<<<<< HEAD
            

           // if (ev == null)
            //    return NotFound();
           _providerService.Delete(id);
=======
            var ev = _conect.ProviderList.Find(e => e.id == id);

            if (ev == null)
                return NotFound();
            _conect.ProviderList.Remove(ev);
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
            return Ok();

        }
    }
}
