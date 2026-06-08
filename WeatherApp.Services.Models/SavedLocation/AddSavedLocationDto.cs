using System.ComponentModel.DataAnnotations;
using static WeatherApp.GCommon.EntityValidation;

namespace WeatherApp.Services.Models.SavedLocation
{
    public class AddSavedLocationDto
    {
        [Required]
        [StringLength(MaxCityNameLength, MinimumLength = MinCityNameLength)]
        public string CityName { get; set; } = null!;

        [Required]
        [StringLength(MaxCountryNameLength, MinimumLength = MinCountryNameLength)]
        public string Country { get; set; } = null!;

        [Range(MinLatitudeValue, MaxLatitudeValue)]
        public double Lat { get; set; }

        [Range(MinLongtitudeValue, MaxLongtitudeValue)]
        public double Lon { get; set; }
    }
}
