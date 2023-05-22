using Microsoft.AspNetCore.Mvc;

namespace Dot.Net.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RuleNameController : ControllerBase
    {
        // TODO: Inject RuleName service

        [HttpGet]
        [Route("list")]
        public IActionResult Home()
        {
            // TODO: find all RuleName, add to model
            return Ok();
        }

        [HttpGet]
        [Route("add")]
        public IActionResult AddRuleName([FromBody]RuleName trade)
        {
            return Ok();
        }

        [HttpGet]
        [Route("validate")]
        public IActionResult Validate([FromBody]RuleName trade)
        {
            // TODO: check data valid and save to db, after saving return RuleName list
            return Ok();
        }

        [HttpGet]
        [Route("update/{id}")]
        public IActionResult ShowUpdateForm(int id)
        {
            // TODO: get RuleName by Id and to model then show to the form
            return Ok();
        }

        [HttpPost]
        [Route("update/{id}")]
        public IActionResult UpdateRuleName(int id, [FromBody] RuleName rating)
        {
            // TODO: check required fields, if valid call service to update RuleName and return RuleName list
            return Ok();
        }

        [HttpDelete]
        [Route("{id}")]
        public IActionResult DeleteRuleName(int id)
        {
            // TODO: Find RuleName by Id and delete the RuleName, return to Rule list
            return Ok();
        }
    }
}