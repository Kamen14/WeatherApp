using Microsoft.Extensions.Options;
using System.Net.Http.Json;
using WeatherApp.Services.Configuration;
using WeatherApp.Services.ExternalDtos;
using WeatherApp.Services.Interfaces;
using WeatherApp.Services.Models.Location;

namespace WeatherApp.Services
{
    public class LocationService : ILocationService
    {
        private readonly HttpClient _httpClient;
        private readonly WeatherApiSettings _settings;

        public LocationService(HttpClient httpClient, IOptions<WeatherApiSettings> settings)
        {
            _httpClient = httpClient;
            _settings = settings.Value;
        }

        public async Task<IEnumerable<LocationDto>> SearchLocationsAsync(string query)
        {
            List<OpenWeatherLocationResponse>? response = await _httpClient.GetFromJsonAsync<List<OpenWeatherLocationResponse>>(
                $"geo/1.0/direct?q={query}&limit={_settings.LocationSearchLimit}&appid={_settings.ApiKey}");

            if(response is null)
            {
                return [];
            }

            List<LocationDto> locations = response.Select(loc => new LocationDto
            {
                CityName = loc.Name,
                Country = loc.Country,
                Lat = loc.Lat,
                Lon = loc.Lon
            }).ToList();

            return locations;
        }

        public Task<LocationDto> GetLocationByIdAsync(string locationId)
        {
            throw new NotImplementedException();
        }

    }
}
