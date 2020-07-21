using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp_2._0.JSON_Objects.CurrentWeather
{
    [JsonObject]
    class CloudStatusClass
    {
        [JsonProperty("all")]
        public int _all { get; set; }
    }
}
