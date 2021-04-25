using FakeXiecheng.API.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FakeXiecheng.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TouristRoutesController : ControllerBase
    {
        private ITouristRouteRepository _touristRouteRepository;

        public TouristRoutesController(ITouristRouteRepository touristRouteRepository)
        {
            this._touristRouteRepository = touristRouteRepository;
        }

        [HttpGet]
        public IActionResult GetTouristRoutes()
        {
            var touristRouteFromRepo = _touristRouteRepository.GetTouristRoutes();
            if (touristRouteFromRepo == null || touristRouteFromRepo.Count() <= 0)
            {
                return NotFound("没有旅游路线");
            }
            return Ok(touristRouteFromRepo);
        }

        [HttpGet("{touristRouteId}")]
        public IActionResult GetTouristRouteById(Guid touristRouteId)
        {
            var touristRouteFromRepo = _touristRouteRepository.GetTouristRoute(touristRouteId);
            if(touristRouteFromRepo == null)
            {
                return NotFound($"旅游路线{touristRouteId}找不到");
            }
            return Ok(touristRouteFromRepo);
        }
    }
}
