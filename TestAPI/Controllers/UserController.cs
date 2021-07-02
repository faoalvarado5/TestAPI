using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace TestAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private readonly ILogger<UserController> _logger;

        public UserController(ILogger<UserController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        // Get the model of the object User.
        public IActionResult Get()
        {
            return Ok(new User());
        }
        
        [HttpGet]
        [Route("1")]
        // Get the data of the user who's id is 1.
        public IActionResult GetUser1()
        {
            return Ok(new User() { ID=1, name="Juan", age=56});
        }
        
        [HttpGet]
        [Route("{number}")]
        // Get the data of the user who's id is the entered one.
        public IActionResult GetUserByNumber(int number)
        {
            return Ok(new User() { ID=number, name="Unknown", age=0});
        }
        
        [HttpGet]
        [Route("name/{name}")]
        // Get the data of the user who's name is the entered one.
        public IActionResult GetUserByName(string name)
        {
            return Ok(new User() { ID=0, name=name, age=0});
        }
    }
}
