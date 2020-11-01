using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Common;
using Data.Contracts;
using Entities.Route;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class RouteRepository: Repository<Route>, IRouteRepository, IScopedDependency
    {
        public RouteRepository(ApplicationDbContext dbContext) : base(dbContext)
        {}

        public async Task<List<Route>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await base.TableNoTracking.ToListAsync(cancellationToken);
        }
    }
}