using System;
using System.Threading.Tasks;
using Domain.Data;
using Entitiy;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication.Controllers
{
    public class UsersController:ControllerBase
    {
        private IUserRepo userRepo;

        public UsersController(IUserRepo userRepo)
        {
            this.userRepo = userRepo;
        }
        
        [HttpPost]
        [Route("api/users/register")]

        public async Task<ActionResult<User>> RegisterUser([FromBody] User user)
        {
            try
            {
                User user1 = await userRepo.RegisterNewUser(user);
                return Ok(user1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return StatusCode(500, e.Message);
            }
        }

        [HttpPost]
        [Route("api/users/login")]

        public async Task<ActionResult<User>> Login([FromBody] User user)
        {
            
            try
            {
                User user1 = await userRepo.ValidateUser(user.Username, user.Password);
                Console.WriteLine($"Controller: username: {user1.Username}, password:{user1.Password}");
                return Ok(user1);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return StatusCode(500, e.Message);
            }
        }
    }
}