using Microsoft.AspNetCore.Mvc;
using The_piano_house.Core.Entities;
using The_Piano_house.Core.Services;
using The_Piano_house.Servise;


// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace The_piano_house.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _customersService;
        public CustomersController(ICustomersService customersService)
        {
            _customersService = customersService;
        }


        // GET: api/<CustomersController>
        [HttpGet]
        public List<Customers> Get()
        {
            return  _customersService.Get();
        }


        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
       // public ActionResult< Customers> Get(int id)
        public  Customers  Get(int id)
        {
            return _customersService.Get(id);
           // var ev = _conect.CustomersList.Find(e => e.id == id);

         //   if (ev == null)
           //     return NotFound();

           //     return ev;
        }


        // POST api/<CustomersController>
        [HttpPost]
      //  public ActionResult Post([FromBody] Customers c)
        public void Post([FromBody] Customers c)
        {
          _customersService.Post(c);  
           // return Ok();
            //if (c.id.ToString().Length != 9)
            //    return BadRequest();
            //_conect.CustomersList.Add(new Customers { id =c.id,name=c.name,phone=c.phone,address=c.address,lastPurchaseDate=c.lastPurchaseDate  });
            //return Ok();
        }


        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
       // public ActionResult Put(int id, [FromBody] Customers c)
        public void Put(int id, [FromBody] Customers c)
        {


           _customersService.Put(id, c);    
           // if (ev == null)
            //    return NotFound();
           
         
            
           //  return Ok();
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
     //   public ActionResult Delete(int id)
        public void Delete(int id)
        {
            
            _customersService.Delete(id);
            //if (ev == null)
             //   return NotFound();             
                //  return Ok();      
                
            
        }
    }
}
