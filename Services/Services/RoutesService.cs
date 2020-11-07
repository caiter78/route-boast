using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Common.Exceptions;
using Data.Entities.Route;
using Data.Repositories;

namespace Services.Services
{
    public class RoutesService : IRoutesService
    {
        private readonly IRoutesRepository _routesRepository;
        
        public RoutesService(IRoutesRepository routesRepository)
        {
            _routesRepository = routesRepository;
        }

        public async Task<List<Route>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _routesRepository.GetAllAsync(cancellationToken);
        }
        
        public async Task<Route> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            var route = await _routesRepository.GetByIdAsync(id, cancellationToken);
            if (route == null)
            {
                throw new NotFoundException($"Route with id {id} not found");
            }

            return route;
        }
        
        public async Task UpdateAsync(Route route, CancellationToken cancellationToken)
        {
            var existedRoute = await _routesRepository.GetByIdAsync(route.Id, cancellationToken);
            if (existedRoute == null)
            {
                throw new NotFoundException($"Route with id {route.Id} not found");
            }

            await _routesRepository.UpdateAsync(existedRoute, cancellationToken);
        }
        
        public async Task LikeAsync(long id, CancellationToken cancellationToken)
        {
            var route = await _routesRepository.GetByIdAsync(id, cancellationToken);
            if (route == null)
            {
                throw new NotFoundException($"Route with id {id} not found");
            }
            route.LikeCount = route.LikeCount + 1;
            await _routesRepository.UpdateAsync(route, cancellationToken);
        }
        
        public async Task UnLikeAsync(long id, CancellationToken cancellationToken)
        {
            var route = await _routesRepository.GetByIdAsync(id, cancellationToken);
            if (route == null)
            {
                throw new NotFoundException($"Route with id {id} not found");
            }
            route.LikeCount = route.LikeCount == 0 ? 0 : route.LikeCount - 1;
            await _routesRepository.UpdateAsync(route, cancellationToken);
        }
        
        public async Task DeleteAsync(long id, CancellationToken cancellationToken)
        {
            var route = await _routesRepository.GetByIdAsync(id, cancellationToken);
            if (route == null)
            {
                throw new NotFoundException($"Route with id {id} not found");
            }
            await _routesRepository.DeleteAsync(route, cancellationToken);
        }
    }
}