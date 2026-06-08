using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherApp.GCommon
{
    public static class EntityValidation
    {
        public const int MaxCityNameLength = 100;
        public const int MinCityNameLength = 2;

        public const int MinCountryNameLength = 2;
        public const int MaxCountryNameLength = 70;

        public const int MinLatitudeValue = -90;
        public const int MaxLatitudeValue = 90;

        public const int MinLongtitudeValue = -180;
        public const int MaxLongtitudeValue = 180;


        public const int MaxNicknameLength = 25;
    }
}
