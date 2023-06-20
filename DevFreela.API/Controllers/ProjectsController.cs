using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        [HttpGet("ObterTodos")]
        public IActionResult Get()
        {
            return Ok();
        }


    }
}
