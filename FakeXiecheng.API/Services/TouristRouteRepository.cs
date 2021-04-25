using FakeXiecheng.API.Database;
using FakeXiecheng.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiecheng.API.Services
{
    public class TouristRouteRepository : ITouristRouteRepository
    {

        public readonly AppDbContext _context;

        public TouristRouteRepository(AppDbContext context)
        {
            this._context = context;
        }

        public TouristRoute GetTouristRoute(Guid touristRouteId)
        {
            return _context.TouristRoutes.FirstOrDefault<TouristRoute>(t=>t.Id == touristRouteId);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes()
        {
            return _context.TouristRoutes;
        }
    }
}
