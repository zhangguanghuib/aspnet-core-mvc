using FakeXiecheng.API.Database;
using FakeXiecheng.API.Models;
using Microsoft.EntityFrameworkCore;
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
            return _context.TouristRoutes.Include(t => t.TouristRoutePictures).FirstOrDefault<TouristRoute>(t => t.Id == touristRouteId);
        }

        public IEnumerable<TouristRoute> GetTouristRoutes(string keyword, string ratingOperator, int ratingValue)
        {
            IQueryable<TouristRoute> result = _context
                .TouristRoutes
                .Include(t => t.TouristRoutePictures);

            if(!string.IsNullOrEmpty(keyword))
            {
                keyword = keyword.Trim();
                result = result.Where(t => t.Title.Contains(keyword));
            }

            if (ratingValue > 0)
            {
                switch (ratingOperator)
                {
                    case "largerThan":
                        result = result.Where(t=>t.Rating >= ratingValue);
                        break;
                    case "lessThan":
                        result = result.Where(t=>t.Rating <= ratingValue);
                        break;
                    case "equalTo":
                        result = result.Where(t=>t.Rating == ratingValue);
                        break;
                }
            }

            // include vs join
            return result.ToList<TouristRoute>();
        }

        public TouristRoutePicture GetPicture(int pictureId)
        {
            return _context.TouristRoutePictures.Where(p => p.Id == pictureId).FirstOrDefault();
        }

        public IEnumerable<TouristRoutePicture> GetPicturesByTouristRouteId(Guid touristRouteId)
        {
            return _context.TouristRoutePictures
                .Where(p => p.TouristRouteId == touristRouteId)
                .ToList<TouristRoutePicture>();
        }

        public bool TouristRouteExist(Guid touristRouteId)
        {
            return _context.TouristRoutes.Any<TouristRoute>(t => t.Id == touristRouteId);
        }
    }
}
