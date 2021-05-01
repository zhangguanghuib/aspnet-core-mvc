using FakeXiecheng.API.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiecheng.API.Services
{
   // public class MockTouristRouteRepository : ITouristRouteRepository
      public class MockTouristRouteRepository 
    {
        private List<TouristRoute> _routes;

        private void InitializeTouristRoutes()
        {
            _routes = new List<TouristRoute>()
            {
                new TouristRoute
                {
                    Id = Guid.NewGuid(),
                    Title = "黄山",
                    Description="黄山真好玩",
                    OriginalPrice =1299,
                    Features="<p>吃住行娱乐购买</p>",
                    Fees="<p>交通费用自理</p>",
                    Notes= "<p>小心危险</p>"
                },
                 new TouristRoute
                {
                    Id = Guid.NewGuid(),
                    Title = "华山",
                    Description="华山真好玩",
                    OriginalPrice =1299,
                    Features="<p>吃住行娱乐购买</p>",
                    Fees="<p>交通费用自理</p>",
                    Notes= "<p>小心危险</p>"
                }
            };
        }

        public MockTouristRouteRepository()
        {
            if(_routes == null)
            {
                InitializeTouristRoutes();
            }
        }
        TouristRoute GetTouristRoute(Guid touristRouteId)
        {
            return _routes.FirstOrDefault<TouristRoute>(n=>n.Id == touristRouteId);
        }

        IEnumerable<TouristRoute> GetTouristRoutes(string keyword, string ratingOperator, int ratingValue)
        {
            return _routes;
        }

        bool TouristRouteExist(Guid touristRouteId)
        {
            throw new NotImplementedException();
        }

        IEnumerable<TouristRoutePicture> GetPicturesByTouristRouteId(Guid touristRouteId)
        {
            throw new NotImplementedException();
        }

        TouristRoutePicture GetPicture(int pictureId)
        {
            throw new NotImplementedException();
        }
    }
}
