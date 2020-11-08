using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Data.Entities.Route;
using Routes.Dtos;

namespace Routes.Repositories
{
    public interface IRoutesRepository
    {
        public Task<List<RouteDto>> GetAllAsync(CancellationToken cancellationToken);
        public Task<RouteDto> GetRouteDtoByIdAsync(long id, CancellationToken cancellationToken);
        public Task<Route> GetByIdAsync(long id, CancellationToken cancellationToken);
        public Task UpdateAsync(Route route,  CancellationToken cancellationToken);
        public Task DeleteAsync(Route route, CancellationToken cancellationToken);
    }
}