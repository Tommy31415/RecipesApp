using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using RecipesApp.API.Data;
using RecipesApp.API.Models;

namespace RecipesApp.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        private readonly IAuthRepository _authRepository;
        public AuthController(IAuthRepository authRepository)
        {
            _authRepository = authRepository;
        }

        [HttpPost("register")]
        public async Task<IActionResult> Register(string username, string password)
        {
            username = username.ToLower();
            if(await _authRepository.UserExist(username))
                return BadRequest("User exists");

            var userToCreate = new User(){
                Name = username
            };

            var createdUser = await _authRepository.Register(userToCreate, password);

            return StatusCode(201);
        }
    }
}