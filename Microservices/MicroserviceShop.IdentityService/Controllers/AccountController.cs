using MicroserviceShop.IdentityService.Application;
using MicroserviceShop.IdentityService.Domain;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace MicroserviceShop.IdentityService.Controllers
{
    [Route("api")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IJwtAuthenticationService _jwtAuthenticationService;

        public AccountController(IJwtAuthenticationService jwtAuthenticationService)
        {
            _jwtAuthenticationService = jwtAuthenticationService;
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
