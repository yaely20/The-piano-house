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
<<<<<<< HEAD
        private readonly ICustomersService _customersService;
        public CustomersController(ICustomersService customersService)
        {
            _customersService = customersService;
=======
        private readonly DataContext _conect;
        public CustomersController(DataContext conect)
        {
            _conect = conect;
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
        }


        // GET: api/<CustomersController>
        [HttpGet]
        public List<Customers> Get()
        {
<<<<<<< HEAD
            return  _customersService.Get();
=======
            return _conect.CustomersList;
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
        }


        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
<<<<<<< HEAD
       // public ActionResult< Customers> Get(int id)
        public  Customers  Get(int id)
        {
            return _customersService.Get(id);
           // var ev = _conect.CustomersList.Find(e => e.id == id);

         //   if (ev == null)
           //     return NotFound();

           //     return ev;
=======
        public ActionResult< Customers> Get(int id)
        {
            var ev = _conect.CustomersList.Find(e => e.id == id);

            if (ev == null)
                return NotFound();

                return ev;
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
        }


        // POST api/<CustomersController>
        [HttpPost]
<<<<<<< HEAD
      //  public ActionResult Post([FromBody] Customers c)
        public void Post([FromBody] Customers c)
        {
          _customersService.Post(c);  
           // return Ok();
            //if (c.id.ToString().Length != 9)
            //    return BadRequest();
            //_conect.CustomersList.Add(new Customers { id =c.id,name=c.name,phone=c.phone,address=c.address,lastPurchaseDate=c.lastPurchaseDate  });
            //return Ok();
=======
        public ActionResult Post([FromBody] Customers c)
        {
            if (c.id.ToString().Length != 9)
                return BadRequest();
            _conect.CustomersList.Add(new Customers { id =c.id,name=c.name,phone=c.phone,address=c.address,lastPurchaseDate=c.lastPurchaseDate  });
            return Ok();
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
        }


        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
<<<<<<< HEAD
       // public ActionResult Put(int id, [FromBody] Customers c)
        public void Put(int id, [FromBody] Customers c)
        {


           _customersService.Put(id, c);    
           // if (ev == null)
            //    return NotFound();
           
         
            
           //  return Ok();
=======
        public ActionResult Put(int id, [FromBody] Customers c)
        {


            var ev = _conect.CustomersList.Find(e => e.id == id);

            if (ev == null)
                return NotFound();
            ev.name = c.name;
            ev.address = c.address;
            ev.lastPurchaseDate= c.lastPurchaseDate;
            ev.phone= c.phone;
         
            
             return Ok();
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
<<<<<<< HEAD
     //   public ActionResult Delete(int id)
        public void Delete(int id)
        {
            
            _customersService.Delete(id);
            //if (ev == null)
             //   return NotFound();             
                //  return Ok();      
=======
        public ActionResult Delete(int id)
        {
            var ev = _conect.CustomersList.Find(e => e.id == id);

            if (ev == null)
                return NotFound();             
          _conect.CustomersList.Remove(ev);
            return Ok();      
>>>>>>> 52c5b8f7c1561ec08eba0a6d2ca8d33be77ff548
                
            
        }
    }
}
