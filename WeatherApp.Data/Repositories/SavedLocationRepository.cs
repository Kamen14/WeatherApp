using System.Numerics;
using WeatherApp.Data.Models;
using WeatherApp.Data.Repositories.Interfaces;

namespace WeatherApp.Data.Repositories
{
    public class SavedLocationRepository : ISavedLocationRepository
    {
        private readonly WeatherAppDbContext _dbContext;

        public SavedLocationRepository(WeatherAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IQueryable<SavedLocation> GetAllSavedLocations()
        {
            return _dbContext.SavedLocations;
        }

        public async Task SaveLocation(SavedLocation location)
        {
            await _dbContext.SavedLocations.AddAsync(location);
            await _dbContext.SaveChangesAsync(); 

        }

        public async Task DeleteSavedLocationAsync(SavedLocation location)
        {
            _dbContext.SavedLocations.Remove(location);
            await _dbContext.SaveChangesAsync();
        }
    }
}
