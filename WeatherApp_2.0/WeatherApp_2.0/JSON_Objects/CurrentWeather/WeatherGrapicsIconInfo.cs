using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp_2._0.JSON_Objects.CurrentWeather
{
    [JsonObject]
    class WeatherGrapicsIconInfo
    {
        [JsonProperty("id")]
        public int _id { get; set; }

        [JsonProperty("main")]
        public string _main { get; set; }

        [JsonProperty("description")]
        public string _description { get; set; }

        [JsonProperty("icon")]
        public string _icon { get; set; }
    }
}
