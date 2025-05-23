using LegacyApplicationRefactoring.Models;
using LegacyApplicationRefactoring.Services;
using LegacyApplicationRefactoring.Interfaces;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace LegacyApplicationRefactoring.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }

        [HttpGet("welcome")]
        public async Task<IActionResult> GetWelcomeMessage([FromQuery] string username)
        {
            var result = await _userService.GetWelcomeMessageAsync(username);

            if (result.Message == "Username is required.")
            {
                return BadRequest(result.Message);
            }

            if (result.Message == "Username not found.")
            {
                return NotFound(result.Message);
            }

            return Ok(result);
        }
    }
}