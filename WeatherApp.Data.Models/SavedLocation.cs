using System.ComponentModel.DataAnnotations;
using static WeatherApp.GCommon.EntityValidation;

namespace WeatherApp.Data.Models
{
    public class SavedLocation
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(MaxCityNameLength)]
        public string CityName { get; set; } = null!;

        [Required]
        [MaxLength(MaxCountryNameLength)]
        public string Country { get; set; } = null!;

        [Required]
        public double Lat { get; set; }

        [Required]
        public double Lon { get; set; }

        public DateTime SavedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public string UserId { get; set; } = null!;

        public virtual ApplicationUser User { get; set; } = null!;
    }
}
