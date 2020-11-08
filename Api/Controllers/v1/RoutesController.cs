using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Routes.Dtos;
using Routes.Services;
using Routes.ViewModels;

namespace Api.Controllers.v1
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
        public async Task<ActionResult<List<RouteDto>>> GetAll(CancellationToken cancellationToken)
        {
            var list = await _routesService.GetAllAsync(cancellationToken);
            return Ok(list);
        }
        
        [HttpPost]
        [DisableRequestSizeLimit]
        public IActionResult Upload([FromForm] CreateRouteVm createRouteVm)
        {
            var file = createRouteVm.Gpx;

            return Ok();
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] RouteDto route, CancellationToken cancellationToken)
        {
            await _routesService.UpdateAsync(route, cancellationToken);
            return Ok();
        }

        [HttpGet("top", Name = nameof(GetTop))]
        public async Task<ActionResult<List<RouteDto>>> GetTop(CancellationToken cancellationToken)
        {
            var list = await _routesService.GetAllAsync(cancellationToken);
            return Ok(list);
        }

        [HttpGet("{id:int}")]
        public virtual async Task<IActionResult> Get(long id, CancellationToken cancellationToken)
        {
            var route = await _routesService.GetRouteDtoByIdAsync(id, cancellationToken);

            return Ok(route);
        }

        [HttpDelete("{id:int}")]
        public async Task<IActionResult> Delete(long id, CancellationToken cancellationToken)
        {
            await _routesService.DeleteAsync(id, cancellationToken);
            return NoContent();
        }

        [HttpPost("{id:int}/like")]
        public async Task<IActionResult> Like(long id, CancellationToken cancellationToken)
        {
            await _routesService.LikeAsync(id, cancellationToken);
            return Ok();
        }

        [HttpDelete("{id:int}/like")]
        public async Task<IActionResult> Unlike(long id, CancellationToken cancellationToken)
        {
            await _routesService.UnLikeAsync(id, cancellationToken);
            return Ok();
        }
    }
}