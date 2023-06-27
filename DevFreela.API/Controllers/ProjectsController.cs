﻿using DevFreela.API.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace DevFreela.API.Controllers
{
    [ApiController]
    [Route("api/projects")]
    public class ProjectsController : ControllerBase
    {
        private readonly OpeningTimeOption _option;

        public ProjectsController(IOptions<OpeningTimeOption> option)
        {
            _option = option.Value;
        }

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

        [HttpPost("CriarProjeto")]
        public IActionResult Post([FromBody] CreateProjectModel createProjectModel)
        {
            return CreatedAtAction(nameof(GetById), new { id = createProjectModel.Id }, createProjectModel );
        }

        [HttpPut("AtualizarProjeto/{id}")]
        public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProjectModel) //Colocar o que será atualizado 
        {
            return NoContent();
        }

        [HttpDelete("RemoverProjeto/{id}")]
        public IActionResult Delete(int id)
        {
            return Ok();
        }

        [HttpPost("{id}/comments")]
        public IActionResult PostComment(int id, [FromBody] CreateModelComment createComment)
        {
            return NoContent();
        }

        [HttpPut("{id}/login")]
        public IActionResult Login()
        {
            return NoContent();
        }    

    }
}
