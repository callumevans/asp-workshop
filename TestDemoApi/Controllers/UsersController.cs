using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TestDemoApi.Models;
using TestDemoApi.Services;

namespace TestDemoApi.Controllers
{
    [Route("users")]
    public class UsersController : Controller
    {
        private readonly UserRepository _userRepository;
        
        public UsersController(UserRepository userRepository)
        {
            _userRepository = userRepository;
        }
        
        [HttpGet]
        public List<User> Get()
        {
            return _userRepository.GetUsers();
        }

        [HttpPost]
        public ActionResult Post([FromBody]User userInput)
        {
            _userRepository.CreateUser(userInput);
            return Ok();
        }
    }
}