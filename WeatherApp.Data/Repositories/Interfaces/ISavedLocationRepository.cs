using WeatherApp.Data.Models;

namespace WeatherApp.Data.Repositories.Interfaces
{
    public interface ISavedLocationRepository
    {
        public IQueryable<SavedLocation> GetAllSavedLocations();

        public Task SaveLocation(SavedLocation location);

        public Task DeleteSavedLocationAsync(SavedLocation location);   
    }
}
