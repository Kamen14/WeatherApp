using WeatherApp.Services.Models.SavedLocation;

namespace WeatherApp.Services.Interfaces
{
    public interface ISavedLocationService
    {
        Task<IEnumerable<SavedLocationDto>> GetSavedLocationsByUserIdAsync(string userId);

        Task AddSavedLoactionAsync(AddSavedLocationDto savedLocationDto, string userId);

        Task DeleteSavedLocation(int id, string userId);
    }
}
