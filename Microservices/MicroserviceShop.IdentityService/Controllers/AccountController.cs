using MicroserviceShop.IdentityService.Application;
using MicroserviceShop.IdentityService.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceShop.IdentityService.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        private readonly IJwtAuthenticationService _jwtAuthenticationService;

        public AccountController(IJwtAuthenticationService jwtAuthenticationService)
        {
            _jwtAuthenticationService = jwtAuthenticationService;
        }

        [HttpGet("index")]
        public IActionResult Index()
        {
            return Ok("This is for test");
        }

        [HttpPost("authenticate")]
        public IActionResult Authenticate([FromBody] User user)
        {
            var jwtToken = _jwtAuthenticationService.Authenticate(user.Username, user.Password);

            if (jwtToken is null) return Unauthorized();

            return Ok(jwtToken);
        }


    }
}
