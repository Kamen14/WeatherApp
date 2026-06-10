using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Services.Models.Location
{
    public class LocationDto
    {
        public string CityName { get; set; } = null!; // matches SavedLocation naming
        public string Country { get; set; } = null!;
        public double Lat { get; set; }
        public double Lon { get; set; }
    }
}
