using Microsoft.AspNetCore.Mvc;
using FrankBot_API.Interfaces;
using FrankBot_API.Models;
using FrankBot_API.Exceptions;

namespace FrankBot_API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController: ControllerBase
    {
        private readonly IUserRepositore userRepositore;

        [HttpGet("{id}")]
        public async Task<ActionResult<Users>> Get(int id)
        {
            try
            {
                return new ObjectResult(await userRepositore.GetUserByIdAsync(id));
            }
            catch (NullException)
            {
                return NotFound("User with this Id not found.");
            }
        }
        [HttpPost]
        public async Task<ActionResult> Add(Users user)
        {
            try
            {
                await userRepositore.AddUserAsync(user);
                return Ok("User added");
            }
            catch 
            {
                return NotFound("");
            }
        }
        [HttpPost]
        public async Task<ActionResult> Delete(Users user)
        {
            try
            {
                await userRepositore.DeleteUserAsync(user);
                return Ok("User deleted");
            }
            catch
            {
                return NotFound("");
            }
        }
    }
}
