using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace RouteBoast.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class UsersController : ControllerBase
    {
        [HttpGet(Name = nameof(GetAll))]
        public ActionResult GetAll(ApiVersion version)
        {
            return new OkResult();
        }
        
        [HttpGet]
        [Route("{id:int}")]
        public ActionResult GetOne(ApiVersion version, int id)
        {
            return new OkResult();
        }
    }
}