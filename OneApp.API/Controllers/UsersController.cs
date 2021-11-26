using Microsoft.AspNetCore.Mvc;
using OneApp.Services;
using PosRest.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OneApp.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        
        private readonly IUserService _userService;

        public UsersController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("")]
        public async Task<ActionResult<IEnumerable<User>>> GetAllUser()
        {
            var users = await _userService.GetAllUsers();

            return Ok(users);
        }

        [HttpPost("")]
        public async Task<ActionResult<User>> CreateUser([FromBody] User saveUser)
        {    
            var newUser = await _userService.CreateUser(saveUser);

            return Ok(newUser);
        }
    }
}
