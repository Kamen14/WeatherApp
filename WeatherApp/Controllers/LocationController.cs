using Microsoft.AspNetCore.Mvc;
using WeatherApp.Services.Interfaces;
using WeatherApp.Services.Models.Location;

namespace WeatherApp.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class LocationController : ControllerBase
    {
        private readonly ILocationService _locationService;

        public LocationController(ILocationService locationService)
        {
            _locationService = locationService;
        }

        [HttpGet("search")]
        public async Task<IActionResult> SearchLocations(string query)
        {
            IEnumerable<LocationDto> locations = await _locationService.SearchLocationsAsync(query);

            return Ok(locations);
        }
    }
}
