using asingment.Dto;
using BusinessLogicLayer;
using DataAccessLayer.IRepository;
using DataAccessLayer.Model;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace asingment.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TasksController : ControllerBase
    {
        private readonly IPersonBLL personBLL;
        public TasksController(IPersonBLL _personBLL)
        {
            personBLL = _personBLL;
        }



        [HttpGet("/getAllOrder")]
        public IActionResult GetAllOrder()
        {
            var s = personBLL.GetTasks();
            return Ok(s);
        }


        [HttpGet("/getPersonName/{name}")]
        public IActionResult GetPersonByName(string name)
        {
            var person = personBLL.PersonExists(name);
            if (!person)
            {
                return NotFound("ei mal nai");
            }

            var x = personBLL.GetPersonByName(name);
            return Ok(x);
        }

        [HttpGet("/listOfTask/{name}")]
        public IActionResult GetListOfTasksByName(string name)
        {
            var x = personBLL.GetListOfTasksByName(name);
            return Ok(x);
        }


        [HttpGet("/listOfCompletedTasks/{name}")]
        public IActionResult GetListOfCompletedTasksByName(string name)
        {
            var x = personBLL.GetListOfCompleTaskByName(name);
            return Ok(x);
        }

        [HttpPost]
        public IActionResult CreatePerson(Person x)
        {
            if (!personBLL.CreatePerson(x))
            {
                return BadRequest("kam ses");
            }
            return Ok("sucessfully");
        }

    }
}
