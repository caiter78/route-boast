using Common.Exceptions;
using Microsoft.AspNetCore.Mvc;

namespace RouteBoast.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet(Name = nameof(GetAllUsers))]
        public ActionResult GetAllUsers(ApiVersion version)
        {
            return new OkResult();
        }
        
        [HttpGet]
        [Route("{id:int}")]
        public ActionResult GetUser(ApiVersion version, int id)
        {
            throw new NotFoundException("User does not found");
            return new OkResult();
        }
    }
}