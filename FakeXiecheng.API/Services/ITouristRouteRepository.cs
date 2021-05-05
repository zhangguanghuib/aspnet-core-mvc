using FakeXiecheng.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiecheng.API.Services
{
    public interface ITouristRouteRepository
    {
        public IEnumerable<TouristRoute> GetTouristRoutes(string keyword, string ratingOperator, int? ratingValue);
        public TouristRoute GetTouristRoute(Guid touristRouteId);
        public bool TouristRouteExist(Guid touristRouteId);
        public IEnumerable<TouristRoutePicture> GetPicturesByTouristRouteId(Guid touristRouteId);
        public TouristRoutePicture GetPicture(int pictureId);
        void AddTouristRoute(TouristRoute touristRoute);
        void AddTouristRoutePicture(Guid touristRouteId, TouristRoutePicture touristRoutePicture);
        bool Save();
    }
}
