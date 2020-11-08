using AutoMapper;
using Data.Entities.Route;
using Routes.Dtos;

namespace Routes.Mapper
{
    public class RouteMappings: Profile 
    {
        public RouteMappings()
        {
            CreateMap<Route, RouteDto>();
        }
    }
}