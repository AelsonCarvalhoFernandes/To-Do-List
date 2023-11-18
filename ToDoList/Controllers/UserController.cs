using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using ToDoList.Repositories.UserRepository;

namespace ToDoList.Controllers
{
    [ApiController]
    public class UserController : ControllerBase
    {

        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        [HttpGet]
        [Route("users")]
        public IActionResult GetAll()
        {
            return Ok(_userRepository.GetAll());
        }

        [HttpGet]
        [Route("user/{id}")]
        public IActionResult Get(int id) 
        {
            return Ok(_userRepository.GetById(id));
        }

        [HttpPost]
        [Route("users")]
        public IActionResult CreateUser(UserModel model)
        {
            UserModel user = _userRepository.Create(model);

            if(user == null)
            {
                return BadRequest("Usuario não pode ser criado!!");
            }

            return Ok(user);
        }

        [HttpPut]
        [Route("users")]
        public IActionResult UpdateUser(UserModel model)
        {
            UserModel user = _userRepository.Update(model);

            if (user == null)
            {
                return BadRequest("Usuario não pode ser atualizado!!");
            }

            return Ok(user);

        }

        [HttpDelete]
        [Route("users/{id}")]
        public IActionResult DeleteUser(int id)
        {
            bool user = _userRepository.Delete(id);

            if (user == false)
            {
                return BadRequest("Usuario não pode ser deletado!!");
            }

            return Ok("Usuario deletado com sucesso");
        }
    }
}
