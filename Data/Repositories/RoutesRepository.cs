using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Data.Contracts;
using Entities.Route;
using Microsoft.EntityFrameworkCore;

namespace Data.Repositories
{
    public class RoutesRepository: IRoutesRepository
    {
        private readonly ApplicationDbContext _dbContext;

        public RoutesRepository(ApplicationDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public async Task<List<Route>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.Routes.ToListAsync(cancellationToken);
        }

        public async Task<Route> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.Routes.FindAsync(id, cancellationToken);
        }

        public async Task UpdateAsync(Route route, CancellationToken cancellationToken)
        {
            _dbContext.Routes.Update(route);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }

        public async Task DeleteAsync(Route route, CancellationToken cancellationToken)
        {
            _dbContext.Routes.Remove(route);
            await _dbContext.SaveChangesAsync(cancellationToken);
        }
    }
}