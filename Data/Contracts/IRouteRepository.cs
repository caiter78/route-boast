using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Entities.Route;

namespace Data.Contracts
{
    public interface IRouteRepository: IRepository<Route>
    {
        public Task<List<Route>> GetAllAsync(CancellationToken cancellationToken);
    }
}