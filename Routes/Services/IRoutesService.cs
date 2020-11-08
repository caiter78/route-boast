using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Routes.Dtos;

namespace Routes.Services
{
    public interface IRoutesService
    {
        Task<List<RouteDto>> GetAllAsync(CancellationToken cancellationToken);
        Task<RouteDto> GetRouteDtoByIdAsync(long id, CancellationToken cancellationToken);
        Task UpdateAsync(RouteDto route, CancellationToken cancellationToken);
        Task LikeAsync(long id, CancellationToken cancellationToken);
        Task UnLikeAsync(long id, CancellationToken cancellationToken);
        Task DeleteAsync(long id, CancellationToken cancellationToken);
    }
}