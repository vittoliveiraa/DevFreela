using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        [HttpGet("ObterTodos")]
        public IActionResult Get()
        {
            
            return Ok();
        }
        [HttpGet("ObterPorId/{id}")]
        public IActionResult GetById(int id)
        {

            return Ok();
        }
        [HttpPost("CriarUsuario")]
        public IActionResult Post() //Montar o [FromBody]
        {
          //  return CreatedAtAction();
        }
        [HttpPut("AtualizarUsuario/{id}")]
        public IActionResult Put(int id) //Colocar o que será atualizado 
        { 
            return NoContent();    
        }
        [HttpDelete("RemoverUsuario/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }
    }
}
