using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
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
            return await _routesRepository.GetByIdAsync(id, cancellationToken);
        }
        
        public async void Update(Route route, CancellationToken cancellationToken)
        {
            await _routesRepository.UpdateAsync(route, cancellationToken);
        }
        
        public async void Like(Route route, CancellationToken cancellationToken)
        {
            route.LikeCount = route.LikeCount + 1;
            await _routesRepository.UpdateAsync(route, cancellationToken);
        }
        
        public async void UnLike(Route route, CancellationToken cancellationToken)
        {
            route.LikeCount = route.LikeCount == 0 ? 0 : route.LikeCount - 1;
            await _routesRepository.UpdateAsync(route, cancellationToken);
        }
        
        public async void DeleteAsync(Route route, CancellationToken cancellationToken)
        {
            await _routesRepository.DeleteAsync(route, cancellationToken);
        }
    }
}