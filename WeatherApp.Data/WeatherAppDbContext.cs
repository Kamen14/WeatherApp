using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using WeatherApp.Data.Models;

namespace WeatherApp.Data
{
    public class WeatherAppDbContext : IdentityDbContext<ApplicationUser>
    {
        public WeatherAppDbContext(DbContextOptions<WeatherAppDbContext> options)
            : base(options)
        {

        }
        public virtual DbSet<SavedLocation> SavedLocations { get; set; }
    }
}
