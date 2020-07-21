using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp_2._0.JSON_Objects.CurrentWeather
{
    [JsonObject]
    class WindBaseClass
    {
        [JsonProperty("speed")]
        public double _speed { get; set; }

        [JsonProperty("deg")]
        public int _deg { get; set; }
    }
}
