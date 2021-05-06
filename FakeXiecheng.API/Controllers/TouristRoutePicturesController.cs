using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FakeXiecheng.API.Services;
using AutoMapper;
using FakeXiecheng.API.Dtos;
using FakeXiecheng.API.Models;

namespace FakeXiecheng.API.Controllers
{
    [Route("api/touristRoutes/{touristRouteId}/pictures")]
    [ApiController]
    public class TouristRoutePicturesController : ControllerBase
    {
        private ITouristRouteRepository _touristRouteRepository;
        private IMapper _mapper;

        public TouristRoutePicturesController(
            ITouristRouteRepository touristRouteRepository,
            IMapper mapper
            )
        {
            _touristRouteRepository = touristRouteRepository ?? throw new ArgumentNullException(nameof(touristRouteRepository));
            _mapper = mapper ?? throw new ArgumentNullException(nameof(mapper));
        }

        [HttpGet]
        public IActionResult GetPictureListForTouristRoute(Guid touristRouteId)
        {
            if (!_touristRouteRepository.TouristRouteExist(touristRouteId))
            {
                return NotFound("Tourist Route did not exist");
            }

            var picturesFromRepo = _touristRouteRepository.GetPicturesByTouristRouteId(touristRouteId);

            if (picturesFromRepo == null || picturesFromRepo.Count() <= 0)
            {
                return NotFound("The tourist route picture does not exist");
            }

            return Ok(_mapper.Map<IEnumerable<TouristRoutePictureDto>>(picturesFromRepo));

        }

        [HttpGet("{pictureId}", Name = "GetPicture")]
        public IActionResult GetPicture(Guid touristRouteId, int pictureId)
        {
            if (!_touristRouteRepository.TouristRouteExist(touristRouteId))
            {
                return NotFound("The tourist route did not exist");
            }

            var pictureFromRepo = _touristRouteRepository.GetPicture(pictureId);

            if (pictureFromRepo == null)
            {
                return NotFound("The tourist route picture did not exist");
            }

            return Ok(_mapper.Map<TouristRoutePictureDto>(pictureFromRepo));
        }

        [HttpPost]
        public IActionResult CreateTouristRoutePicture(
            [FromRoute] Guid touristRouteId,
            [FromBody] TouristRoutePictureForCreationDto touristRoutePictureForCreationDto)
        {
            if (!_touristRouteRepository.TouristRouteExist(touristRouteId))
            {
                return NotFound("The tourist route did not exist");
            }

            var pictureModel = _mapper.Map<TouristRoutePicture>(touristRoutePictureForCreationDto);
            _touristRouteRepository.AddTouristRoutePicture(touristRouteId, pictureModel);
            _touristRouteRepository.Save();

            var pictureModelToReturn = _mapper.Map<TouristRoutePictureDto>(pictureModel);
            return CreatedAtRoute(
                "GetPicture",
                new
                {
                    touristRouteId = pictureModel.TouristRouteId,
                    pictureId = pictureModel.Id
                },
                pictureModelToReturn
            );
        }

        [HttpDelete("{pictureId}")]
        public IActionResult DeletePicture([FromRoute]Guid touristRouteId, [FromRoute]int pictureId)
        {
            if (!_touristRouteRepository.TouristRouteExist(touristRouteId))
            {
                return NotFound("The tourist route did not exist");
            }

            var picture = _touristRouteRepository.GetPicture(pictureId);

            _touristRouteRepository.DeleteTouristRoutePicture(picture);
            _touristRouteRepository.Save();

            return NoContent();
        }
    }
}
