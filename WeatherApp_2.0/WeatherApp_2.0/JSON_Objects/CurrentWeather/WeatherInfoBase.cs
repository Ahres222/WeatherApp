using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp_2._0.JSON_Objects.CurrentWeather
{
    [JsonObject]
    class WeatherInfoBase
    {
        [JsonProperty("temp")]
        public double _temp { get; set; }

        [JsonProperty("feels_like")]
        public double _feelsLike { get; set; }

        [JsonProperty("temp_min")]
        public double _tempMin { get; set; }

        [JsonProperty("temp_max")]
        public double _tempMax { get; set; }

        [JsonProperty("pressure")]
        public int _pressure { get; set; }

        [JsonProperty("humidity")]
        public int _humidity { get; set; }
    }
}