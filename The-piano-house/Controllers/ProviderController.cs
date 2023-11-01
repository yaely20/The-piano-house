using Microsoft.AspNetCore.Mvc;
using The_piano_house.Entities;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace The_piano_house.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProviderController : ControllerBase
    {
        public static List<Provider> _provider = new List<Provider>();
        public static int index = 0;


        // GET: api/<ProviderController>
        [HttpGet]
        public List<Provider> Get()
        {
            return _provider;
        }

        // GET api/<ProviderController>/5
        [HttpGet("{id}")]
        public Provider Get(int id)
        {
            for (int i = 0; i < index; i++)
            {
                if (_provider[i].id == id)
                    return _provider[i];
            }
            return null;
        }
        // POST api/<ProviderController>
        [HttpPost]
        public void Post([FromBody] Customers p)
        {
            _provider.Add(new Provider { id = index++, name = p.name, phone = p.phone, address = p.address });
        }

        // PUT api/<ProviderController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Provider p)
        {
            for (int i = 0; i < index; i++)
            {
                if (_provider[i].id == id)
                {
                   _provider[i].name = p.name;
                   _provider[i].address = p.address;
                    _provider[i].phone = p.phone;

                }
            }
        }

        // DELETE api/<ProviderController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            foreach (Provider item in _provider)
            {
                if (item.id == id)
                {
                    _provider.Remove(item);
                    break;
                }
            }
        }
    }
}
