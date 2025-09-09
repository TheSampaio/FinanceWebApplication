using Microsoft.AspNetCore.Mvc;

namespace Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]s")]
    public class AccountController : ControllerBase
    {
        [HttpGet]
        public IActionResult GetAll()
        {
            return Ok();
        }

        [HttpGet("{id:Guid}")]
        public IActionResult GetById(Guid id)
        {
            return Ok();
        }

        [HttpPost()]
        public IActionResult Create()
        {
            return Created();
        }

        [HttpPut("{id:Guid}")]
        public IActionResult UpdateById(Guid id)
        {
            return NoContent();
        }

        [HttpDelete("{id:Guid}")]
        public IActionResult DeleteById(Guid id)
        {
            return NoContent();
        }
    }
}