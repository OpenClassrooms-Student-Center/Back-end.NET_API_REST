using Dot.Net.WebApi.Controllers.Domain;
using Microsoft.AspNetCore.Mvc;

namespace Dot.Net.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RatingController : ControllerBase
    {
        // TODO: Inject Rating service

        [HttpGet]
        [Route("list")]
        public IActionResult Home()
        {
            // TODO: find all Rating, add to model
            return Ok();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult AddRatingForm([FromBody]Rating rating)
        {
            return Ok();
        }

        [HttpGet]
        [Route("validate")]
        public IActionResult Validate([FromBody]Rating rating)
        {
            // TODO: check data valid and save to db, after saving return Rating list
            return Ok();
        }

        [HttpGet]
        [Route("update/{id}")]
        public IActionResult ShowUpdateForm(int id)
        {
            // TODO: get Rating by Id and to model then show to the form
            return Ok();
        }

        [HttpPost]
        [Route("update/{id}")]
        public IActionResult UpdateRating(int id, [FromBody] Rating rating)
        {
            // TODO: check required fields, if valid call service to update Rating and return Rating list
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteRating(int id)
        {
            // TODO: Find Rating by Id and delete the Rating, return to Rating list
            return Ok();
        }
    }
}