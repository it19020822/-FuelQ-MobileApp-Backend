/*
  -------------------
  CUSTOMER CONTROLLER
  -------------------
*/

using FuelQ.Models;
using FuelQ.Services;
using Microsoft.AspNetCore.Mvc;

namespace FuelQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
        private readonly ICustomerService customerService;
        public CustomerController(ICustomerService customerService)
        { 
            this.customerService = customerService;
        }

        // GET: api/<CustomerController>
        [HttpGet]
        public ActionResult<List<Customer>> Get()
        {
            return customerService.Get();
        }

        // GET api/<CustomerController>/5
        [HttpGet("{id}")]
        public ActionResult<Customer> Get(string id)
        {
            var customer = customerService.Get(id);

            if (customer == null)
            {
                return NotFound($"Customer with Id = {id} not found!!!");
            }
            return customer;
        }

        [HttpGet("/CustomerService/{shedName}")]
        public ActionResult<List<Customer>> GetByShedName(string shedName)
        {
            return customerService.GetByShedName(shedName);
        }

        // POST api/<CustomerController>
        [HttpPost]
        public ActionResult<Customer> Post([FromBody] Customer customer)
        {
            customerService.Create(customer);

            return CreatedAtAction(nameof(Get), new { id = customer.Id }, customer);
        }

        // PUT api/<CustomerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Customer customer)
        {
            var existingCustomer = customerService.Get(id);

            if (existingCustomer == null)
            {
                return NotFound($"Customer with Id = {id} not found");
            }

            customerService.Update(id, customer);

            return NoContent();
        }

        // DELETE api/<CustomerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var customer = customerService.Get(id);

            if (customer == null)
            { 
                return NotFound($"Customer with Id = {id} not found");
            }

            customerService.Remove(customer.Id);

            return Ok($"Customer with Id = {id} deleted");
        }
    }
}
