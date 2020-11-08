using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using AutoMapper;
using AutoMapper.QueryableExtensions;
using Data;
using Data.Entities.Route;
using Microsoft.EntityFrameworkCore;
using Routes.Dtos;

namespace Routes.Repositories
{
    public class RoutesRepository : IRoutesRepository
    {
        private readonly ApplicationDbContext _dbContext;
        private readonly IMapper _mapper;

        public RoutesRepository(ApplicationDbContext dbContext, IMapper mapper)
        {
            _dbContext = dbContext;
            _mapper = mapper;
        }

        public async Task<List<RouteDto>> GetAllAsync(CancellationToken cancellationToken)
        {
            return await _dbContext.Routes.AsNoTracking().ProjectTo<RouteDto>(_mapper.ConfigurationProvider)
                .ToListAsync(cancellationToken);
        }

        public async Task<RouteDto> GetRouteDtoByIdAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.Routes.AsNoTracking().ProjectTo<RouteDto>(_mapper.ConfigurationProvider)
                .SingleOrDefaultAsync(r => r.Id.Equals(id), cancellationToken);
        }

        public async Task<Route> GetByIdAsync(long id, CancellationToken cancellationToken)
        {
            return await _dbContext.Routes.SingleOrDefaultAsync(r => r.Id.Equals(id), cancellationToken);
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