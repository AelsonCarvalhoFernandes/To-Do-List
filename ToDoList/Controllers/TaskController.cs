using Microsoft.AspNetCore.Mvc;
using System.Diagnostics.Contracts;
using ToDoList.Models;
using ToDoList.Repositories.TaskRepository;

namespace ToDoList.Controllers
{
    [ApiController]
    public class TaskController : ControllerBase
    {

        private readonly ITaskRepository _taskRepository;

        public TaskController(ITaskRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet]
        [Route("tasks")]
        public IActionResult GetAll()
        {
            return Ok(_taskRepository.GetAll());
        }

        [HttpGet]
        [Route("tasks/{id}")]
        public IActionResult Get(int id)
        {
            return Ok(_taskRepository.GetById(id));
        }

        [HttpPost]
        [Route("tasks")]
        public IActionResult CreateTask(TaskModel model)
        {
            TaskModel task = _taskRepository.Create(model);

            if (task == null)
            {
                return BadRequest("A tarefa não pode ser criada");
            }

            return Ok(task);
        }

        [HttpPut]
        [Route("tasks")]
        public IActionResult UpdateTask(TaskModel model)
        {
            TaskModel task = _taskRepository.Update(model);

            if (task == null)
            {
                return BadRequest("A tarefa não pode ser atualizada");
            }

            return Ok(task);
        }

        [HttpDelete]
        [Route("tasks/{id}")]
        public IActionResult DeleteTask(int id)
        {
            bool task = _taskRepository.Delete(id);

            if (task == false)
            {
                return BadRequest("Houve um error ao excluir a tarefa");
            }

            return Ok("Tarefa excluida com sucesso!!");
        }
    }
}
