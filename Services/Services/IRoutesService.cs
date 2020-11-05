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
        void Update(Route route, CancellationToken cancellationToken);
        void Like(Route route, CancellationToken cancellationToken);
        void UnLike(Route route, CancellationToken cancellationToken);
        void DeleteAsync(Route route, CancellationToken cancellationToken);
    }
}