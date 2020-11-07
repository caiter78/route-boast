using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Data.Entities.Route;

namespace Services.Services
{
    public interface IRoutesService
    {
        Task<List<Route>> GetAllAsync(CancellationToken cancellationToken);
        Task<Route> GetByIdAsync(long id, CancellationToken cancellationToken);
        Task UpdateAsync(Route route, CancellationToken cancellationToken);
        Task LikeAsync(long id, CancellationToken cancellationToken);
        Task UnLikeAsync(long id, CancellationToken cancellationToken);
        Task DeleteAsync(long id, CancellationToken cancellationToken);
    }
}