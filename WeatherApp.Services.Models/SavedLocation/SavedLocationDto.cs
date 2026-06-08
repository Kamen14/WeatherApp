namespace WeatherApp.Services.Models.SavedLocation
{
    public class SavedLocationDto
    {
        public int Id { get; set; }

        public string CityName { get; set; } = null!;

        public DateTime SavedAt { get; set; } = DateTime.UtcNow;
    }
}
