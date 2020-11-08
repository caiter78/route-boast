using Microsoft.AspNetCore.Http;

namespace Routes.ViewModels
{
    public class CreateRouteVm
    {
        public string Name { get; set; }
        public IFormFile Gpx { get; set; }
    }
}