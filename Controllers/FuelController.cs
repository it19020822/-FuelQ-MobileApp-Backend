using FuelQ.Models;
using FuelQ.Services;
using Microsoft.AspNetCore.Mvc;

namespace FuelQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FuelController : ControllerBase
    {
        private readonly IFuelService fuelService;
        public FuelController(IFuelService fuelService)
        { 
            this.fuelService = fuelService;
        }
        // GET: api/<FuelController>
        [HttpGet]
        public ActionResult<List<Fuel>> Get()
        {
            return fuelService.Get();
        }

        // GET api/<FuelController>/5
        [HttpGet("{id}")]
        public ActionResult<Fuel> Get(string id)
        {
            var fuel = fuelService.GetById(id);

            if (fuel == null)
            {
                return NotFound($"Fuel with Id = {id} not found!!!");
            }
            return fuel;
        }

        // POST api/<FuelController>
        [HttpPost]
        public ActionResult<Fuel> Post([FromBody] Fuel fuel)
        {
            fuelService.Create(fuel);

            return CreatedAtAction(nameof(Get), new { id = fuel.Id }, fuel);
        }

        // PUT api/<FuelController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Fuel fuel)
        {
            var existingFuel = fuelService.GetById(id);

            if (existingFuel == null)
            {
                return NotFound($"Fuel with Id = {id} not found");
            }

            fuelService.Update(id, fuel);

            return NoContent();
        }

        // DELETE api/<FuelController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var fuel = fuelService.GetById(id);

            if (fuel == null)
            { 
                return NotFound($"Fuel with Id = {id} not found");
            }

            fuelService.Remove(fuel.Id);

            return Ok($"Fuel with Id = {id} deleted");
        }
    }
}
