using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Data.Repositories;
using Entities.Route;

namespace Services
{
    public class RoutesService
    {
        private readonly RouteRepository _repository;
        
        public RoutesService(RouteRepository repository)
        {
            _repository = repository;
        }

        public async Task<List<Route>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _repository.GetAllAsync(cancellationToken);
        }
        
        public async Task<Route> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            return await _repository.GetByIdAsync(cancellationToken, id);
        }
        
        public async void Update(Route route, CancellationToken cancellationToken)
        {
            await _repository.UpdateAsync(route, cancellationToken);
        }
        
        public async void Like(Route route, CancellationToken cancellationToken)
        {
            route.LikeCount = route.LikeCount + 1;
            await _repository.UpdateAsync(route, cancellationToken);
        }
        
        public async void UnLike(Route route, CancellationToken cancellationToken)
        {
            route.LikeCount = route.LikeCount == 0 ? 0 : route.LikeCount - 1;
            await _repository.UpdateAsync(route, cancellationToken);
        }
        
        public async void DeleteAsync(Route route, CancellationToken cancellationToken)
        {
            await _repository.DeleteAsync(route, cancellationToken);
        }
    }
}