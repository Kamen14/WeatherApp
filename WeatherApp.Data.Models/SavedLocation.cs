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

        public DateTime SavedAt { get; set; } = DateTime.UtcNow;

        [Required]
        public string UserId { get; set; } = null!;

        public virtual ApplicationUser User { get; set; } = null!;
    }
}
