using FakeXiecheng.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiecheng.API.Services
{
    public interface ITouristRouteRepository
    {
        public IEnumerable<TouristRoute> GetTouristRoutes();
        public TouristRoute GetTouristRoute(Guid touristRouteId);
    }
}
