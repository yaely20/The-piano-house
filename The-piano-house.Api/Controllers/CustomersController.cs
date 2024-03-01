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
        public async Task <ActionResult<CustumerDTO>> Get()
        {
            var x = await _customersService.Get();
            return Ok(_mapper.Map<ActionResult<CustumerDTO>>(x));
            
        }


        // GET api/<CustomersController>/5
        [HttpGet("{id}")]
        // public ActionResult< Customers> Get(int id)
        public async Task <ActionResult> Get(int id)
        {
            var c=await _customersService.Get(id);
            return Ok( _mapper.Map<CustumerDTO>(c));
            // var ev = _conect.CustomersList.Find(e => e.id == id);

            //   if (ev == null)
            //     return NotFound();

            //     return ev;
        }


        // POST api/<CustomersController>
        [HttpPost]
        //  public ActionResult Post([FromBody] Customers c)
        public  async Task <ActionResult> Post([FromBody] CustomerPostModel c)
        {
            var CustomerToAdd = new Customer ();

             _mapper.Map(c,CustomerToAdd);
            return Ok (  await _customersService.Post(CustomerToAdd));
            // return Ok();
            //if (c.id.ToString().Length != 9)
            //    return BadRequest();
            //_conect.CustomersList.Add(new Customers { id =c.id,name=c.name,phone=c.phone,address=c.address,lastPurchaseDate=c.lastPurchaseDate  });
            //return Ok();
        }


        // PUT api/<CustomersController>/5
        [HttpPut("{id}")]
        // public ActionResult Put(int id, [FromBody] Customers c)
        public async Task <ActionResult> Put(int id, [FromBody] CustomerPostModel c)
        {
            var   customer  = await _customersService.Get(id);
            if (customer is null)
                return NotFound();
            _mapper.Map(c, customer);
           await _customersService.Put(id, customer);
            return Ok();

            // if (ev == null)
            //    return NotFound();



            //  return Ok();
        }

        // DELETE api/<CustomersController>/5
        [HttpDelete("{id}")]
        //   public ActionResult Delete(int id)
        public async Task <ActionResult> Delete(int id)
        {
            var cust =await _customersService. Get(id);
            if (cust is null)
            {
                return NotFound();
            }
            await  _customersService.Delete(id);
            return Ok();
            //if (ev == null)
            //   return NotFound();             
            //  return Ok();      


        }
    }
}
