using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

using WeatherApp_2._0.JSON_Objects.CurrentWeather;

namespace WeatherApp_2._0.JSON_Objects.Forecast
{
    [JsonObject]
    class CityClass
    {
        [JsonProperty("id")]
        public int _id { get; set; }

        [JsonProperty("name")]
        public string _name { get; set; }

        [JsonProperty("coord")]
        public CoordinationClass _coord { get; set; }

        [JsonProperty("country")]
        public string _country { get; set; }

        [JsonProperty("timezone")]
        public int _timezone { get; set; }

        [JsonProperty("sunrise")]
        public int _sunrise { get; set; }

        [JsonProperty("sunset")]
        public int _sunset { get; set; }
    }
}
