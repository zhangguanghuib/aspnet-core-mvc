using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using FakeXiecheng.API.ValidationAttributes;

namespace FakeXiecheng.API.Dtos
{
    [TouristRouteTitleMustBeDifferentFromDescriptionAttribute]
    public abstract class TouristRouteForManipulationDto
    {
        [Required(ErrorMessage = "Title can't be null")]
        [MaxLength(100)]
        public string Title { get; set; }

        [Required]
        [MaxLength(1500)]
        public virtual string Description { get; set; }
        //public decimal OriginalPrice { get; set; }
        //public double? DiscountPercentage { get; set; }
        public decimal Price { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime? UpdateTime { get; set; }
        public DateTime? DepartureTime { get; set; }
        public string Features { get; set; }
        public string Fees { get; set; }
        public string Notes { get; set; }
        public double? Rating { get; set; }
        public string TravelDays { get; set; }
        public string TripType { get; set; }
        public string DepartureCity { get; set; }
        public ICollection<TouristRoutePictureForCreationDto> TouristRoutePictures { get; set; } = new List<TouristRoutePictureForCreationDto>();

    }
}
