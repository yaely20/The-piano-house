using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using The_piano_house.Api.Models;
using The_piano_house.Core.Entities;
using The_Piano_house.Core.Services;
using The_Piano_house.Servise;
using The_Piano_house.Core.DTOs;



namespace The_piano_house.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly ICustomersService _customersService;
        private readonly  IMapper _mapper;
        public CustomersController(ICustomersService customersService, IMapper mapper)
        {
            _customersService = customersService;
            _mapper = mapper;
        }


        // GET: api/<CustomersController>
        [HttpGet]
        public ActionResult Get()
        {
            return Ok(_customersService.Get());
        }


        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        // public ActionResult< Customers> Get(int id)
        public ActionResult Get(int id)
        {
            return Ok(_customersService.Get(id));
            // var ev = _conect.CustomersList.Find(e => e.id == id);

            //   if (ev == null)
            //     return NotFound();

            //     return ev;
        }


        // POST api/<CustomersController>
        [HttpPost]
        //  public ActionResult Post([FromBody] Customers c)
        public  ActionResult Post([FromBody] CustomerPostModel c)
        {
            var CustomerToAdd = new Customer { Name = c.Name, Phone=c.Phone,Address=c.Address };

            var newCust=_customersService.Post(CustomerToAdd);
            var custumerDto = _mapper.Map<CustumerDTO>(newCust);
            return Ok(CustomerToAdd);
            // return Ok();
            //if (c.id.ToString().Length != 9)
            //    return BadRequest();
            //_conect.CustomersList.Add(new Customers { id =c.id,name=c.name,phone=c.phone,address=c.address,lastPurchaseDate=c.lastPurchaseDate  });
            //return Ok();
        }


        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        // public ActionResult Put(int id, [FromBody] Customers c)
        public ActionResult Put(int id, [FromBody] CustomerPostModel c)
        {
            Customer c1 = new Customer();
            c1.Name = c.Name;
            c1.Phone = c.Phone;
            c1.Address = c.Address;
            var newc=_customersService.Put(id, c1);
            var custumerDto = _mapper.Map<CustumerDTO>(newc);
            return Ok(c1);

            // if (ev == null)
            //    return NotFound();



            //  return Ok();
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        //   public ActionResult Delete(int id)
        public ActionResult Delete(int id)
        {
            var cust = _customersService. Get(id);
            if (cust is null)
            {
                return NotFound();
            }
            _customersService.Delete(id);
            return NoContent();
            //if (ev == null)
            //   return NotFound();             
            //  return Ok();      


        }
    }
}
