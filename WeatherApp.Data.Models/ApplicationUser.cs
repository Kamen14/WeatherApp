using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using static WeatherApp.GCommon.EntityValidation;

namespace WeatherApp.Data.Models
{
    public class ApplicationUser : IdentityUser
    {
        [MaxLength(MaxNicknameLength)]
        public string? Nickname { get; set; }

        public virtual ICollection<SavedLocation> SavedLocations { get; set; } = new List<SavedLocation>();
    }
}
