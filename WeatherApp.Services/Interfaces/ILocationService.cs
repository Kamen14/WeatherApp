using WeatherApp.Services.Models.Location;

namespace WeatherApp.Services.Interfaces
{
    public interface ILocationService
    {
        Task<IEnumerable<LocationDto>> SearchLocationsAsync(string query);
        Task<LocationDto> GetLocationByIdAsync(string locationId);
    }
}
