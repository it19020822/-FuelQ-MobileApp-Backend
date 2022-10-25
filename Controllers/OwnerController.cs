/*
  --------------------
    OWNER CONTROLLER
  --------------------
*/

using FuelQ.Models;
using FuelQ.Services;
using Microsoft.AspNetCore.Mvc;

namespace FuelQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class OwnerController : ControllerBase
    {
        private readonly IOwnerService ownerService;
        public OwnerController(IOwnerService ownerService)
        { 
            this.ownerService = ownerService;
        }
        // GET: api/<OwnerController>
        [HttpGet]
        public ActionResult<List<Owner>> Get()
        {
            return ownerService.Get();
        }

        // GET api/<OwnerController>/5
        [HttpGet("{id}")]
        public ActionResult<Owner> Get(string id)
        {
            var owner = ownerService.Get(id);

            if (owner == null)
            {
                return NotFound($"Owner with Id = {id} not found!!!");
            }
            return owner;
        }

        // POST api/<OwnerController>
        [HttpPost]
        public ActionResult<Owner> Post([FromBody] Owner owner)
        {
            ownerService.Create(owner);

            return CreatedAtAction(nameof(Get), new { id = owner.Id }, owner);
        }

        // PUT api/<OwnerController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Owner owner)
        {
            var existingOwner = ownerService.Get(id);

            if (existingOwner == null)
            {
                return NotFound($"Owner with Id = {id} not found");
            }

            ownerService.Update(id, owner);

            return NoContent();
        }

        // DELETE api/<OwnerController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var owner = ownerService.Get(id);

            if (owner == null)
            { 
                return NotFound($"Owner with Id = {id} not found");
            }

            ownerService.Remove(owner.Id);

            return Ok($"Owner with Id = {id} deleted");
        }
    }
}
