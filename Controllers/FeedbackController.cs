/*
  --------------------
  FEEDBACK CONTROLLER
  --------------------
*/

using FuelQ.Models;
using FuelQ.Services;
using Microsoft.AspNetCore.Mvc;

namespace FuelQ.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedbackService feedbackService;
        public FeedbackController(IFeedbackService feedbackService)
        { 
            this.feedbackService = feedbackService;
        }
        // GET: api/<FeedbackController>
        [HttpGet]
        public ActionResult<List<Feedback>> Get()
        {
            return feedbackService.Get();
        }

        // GET api/<FeedbackController>/5
        [HttpGet("{id}")]
        public ActionResult<Feedback> Get(string id)
        {
            var feedback = feedbackService.GetById(id);

            if (feedback == null)
            {
                return NotFound($"Feedback with Id = {id} not found!!!");
            }
            return feedback;
        }

        // POST api/<FeedbackController>
        [HttpPost]
        public ActionResult<Feedback> Post([FromBody] Feedback feedback)
        {
            feedbackService.Create(feedback);

            return CreatedAtAction(nameof(Get), new { id = feedback.Id }, feedback);
        }

        // PUT api/<FeedbackController>/5
        [HttpPut("{id}")]
        public ActionResult Put(string id, [FromBody] Feedback feedback)
        {
            var existingFeedback = feedbackService.GetById(id);

            if (existingFeedback == null)
            {
                return NotFound($"Feedback with Id = {id} not found");
            }

            feedbackService.Update(id, feedback);

            return NoContent();
        }

        // DELETE api/<FeedbackController>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(string id)
        {
            var feedback = feedbackService.GetById(id);

            if (feedback == null)
            { 
                return NotFound($"Feedback with Id = {id} not found");
            }

            feedbackService.Remove(feedback.Id);

            return Ok($"Feedback with Id = {id} deleted");
        }
    }
}
