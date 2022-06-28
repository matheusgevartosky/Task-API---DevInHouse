using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
    [ApiController]
    [Route("api/[controller]")] 
    public class TasksController : ControllerBase
    {
        [HttpGet]
        [Route("listar")] 
        public IActionResult Get()
        {
            
            return Ok(TarefaRepository.GetAll());
        }

        [HttpPost] 
        [Route("cadastrar")] 
        public IActionResult CreateTask([FromBody] Tasks tasks)
        {
            TarefaRepository.Add(tasks);
            return Created("", tasks);
        }

        [HttpDelete]
        [Route("deletar")]
        public IActionResult DeleteTask([FromQuery] int id)
        {
            TarefaRepository.Remove(TarefaRepository.GetById(id));
            return Ok();
        }
    }


}