using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/users")]
    public class UsersController : ControllerBase
    {
        //[HttpGet("ObterTodos")]
        //public IActionResult GetAll()
        //{
            
        //    return Ok();
        //}

        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {

            return Ok();
        }

        [HttpPost]
        public IActionResult Post([FromBody] CreateUserModel createUserModel) 
        {
            return CreatedAtAction(nameof(GetById), new {id = 1}, createUserModel);
        }

        [HttpPut("{id}/login")]
        public IActionResult Login(int id, [FromBody] LoginModel login) 
        { 
            return NoContent();
        }
        //[HttpPut("AtualizarUsuario/{id}")]
        //public IActionResult Put(int id) //Colocar o que será atualizado 
        //{ 
        //    return NoContent();    
        //}

        //[HttpDelete("RemoverUsuario/{id}")]
        //public IActionResult Delete(int id, [FromBody] LoginModel login)
        //{
        //    return Ok();
        //}

    }
}
