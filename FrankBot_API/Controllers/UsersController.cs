using Microsoft.AspNetCore.Mvc;
using FrankBot_API.Interfaces;
using FrankBot_API.Models;
using FrankBot_API.Exceptions;

namespace FrankBot_API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UsersController: ControllerBase
    {
        private readonly IUserRepositore userRepositore;
        public UsersController(IUserRepositore usersRepositore)
        {
            userRepositore = usersRepositore;
        }

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
        public async Task<ActionResult> Add(int id)
        {
            try
            {
                await userRepositore.AddUserAsync(id);
                return Ok("User added");
            }
            catch 
            {
                return NotFound("");
            }
        }
        [HttpDelete("{id}")]
        public async Task<ActionResult> Delete(int id)
        {
            try
            {
                await userRepositore.DeleteUserAsync(id);
                return Ok("User deleted");
            }
            catch
            {
                return NotFound("");
            }
        }
    }
}
