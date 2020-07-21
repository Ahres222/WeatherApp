using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp_2._0.JSON_Objects.CurrentWeather
{
    [JsonObject]
    class CoordinationClass
    {
        [JsonProperty("lon")]
        public double _lon { get; set; }

        [JsonProperty("lat")]
        public double _lat { get; set; }
    }
}
