using Microsoft.AspNetCore.Mvc;

namespace RouteBoast.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class AuthController : ControllerBase
    {
        [HttpPost("Login", Name = nameof(Login))]
        public ActionResult Login()
        {
            return new OkResult();
        }

        [HttpGet("Logout", Name = nameof(Logout))]
        public ActionResult Logout()
        {
            return new OkResult();
        }
    }
}