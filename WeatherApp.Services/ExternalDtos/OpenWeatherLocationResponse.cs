using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.Services.ExternalDtos
{
    public class OpenWeatherLocationResponse
    {
        public string Name { get; set; } = null!;
        public string Country { get; set; } = null!;
        public double Lat { get; set; }
        public double Lon { get; set; }
    }
}
