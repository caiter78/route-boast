using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Entities.Route;
using Microsoft.AspNetCore.Mvc;
using RouteBoast.ViewModels;
using Services;

namespace RouteBoast.Controllers.v1
{
    [ApiController]
    [ApiVersion("1.0")]
    [Route("api/v{version:apiVersion}/[controller]")]
    public class RoutesController : ControllerBase
    {
        private readonly IRoutesService _routesService;

        public RoutesController(IRoutesService routesService)
        {
            _routesService = routesService;
        }

        [HttpGet]
        public async Task<ActionResult<List<Route>>> GetAll(CancellationToken cancellationToken)
        {
            var list = await _routesService.GetAllAsync(cancellationToken);
            return Ok(list);
        }

        [HttpGet("top", Name = nameof(GetTop))]
        public async Task<ActionResult<List<Route>>> GetTop(CancellationToken cancellationToken)
        {
            var list = await _routesService.GetAllAsync(cancellationToken);
            return Ok(list);
        }

        [HttpGet("{id:int}")]
        public virtual async Task<ActionResult<Route>> Get(long id, CancellationToken cancellationToken)
        {
            var route = await _routesService.GetByIdAsync(id, cancellationToken);
            if (route == null)
            {
                return NotFound();
            }

            return Ok(route);
        }

        [HttpPut]
        public async Task<ActionResult> Update([FromBody] Route route, CancellationToken cancellationToken)
        {
            var existedRoute = await _routesService.GetByIdAsync(route.Id, cancellationToken);
            if (existedRoute == null)
            {
                return NotFound();
            }

            _routesService.Update(route, cancellationToken);
            return Ok();
        }

        [HttpDelete("{id:int}")]
        public async Task<ActionResult> Delete(long id, CancellationToken cancellationToken)
        {
            var route = await _routesService.GetByIdAsync(id, cancellationToken);
            if (route == null)
            {
                return NotFound();
            }

            _routesService.DeleteAsync(route, cancellationToken);
            return NoContent();
        }

        [HttpPost("{id:int}/like")]
        public async Task<ActionResult> Like(long id, CancellationToken cancellationToken)
        {
            var route = await _routesService.GetByIdAsync(id, cancellationToken);
            if (route == null)
            {
                return NotFound();
            }

            _routesService.Like(route, cancellationToken);
            return Ok();
        }

        [HttpDelete("{id:int}/like")]
        public async Task<ActionResult> Unlike(long id, CancellationToken cancellationToken)
        {
            var route = await _routesService.GetByIdAsync(id, cancellationToken);
            if (route == null)
            {
                return NotFound();
            }

            _routesService.UnLike(route, cancellationToken);
            return Ok();
        }

        [HttpPost("upload")]
        [DisableRequestSizeLimit]
        public IActionResult Upload([FromForm] CreateRouteVm createRouteVm)
        {
            var file = createRouteVm.Gpx;

            return Ok();
        }
    }
}