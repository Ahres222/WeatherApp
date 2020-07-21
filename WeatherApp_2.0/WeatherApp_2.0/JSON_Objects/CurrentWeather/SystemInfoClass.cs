using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp_2._0.JSON_Objects.CurrentWeather
{
    [JsonObject]
    class SystemInfoClass
    {
        [JsonProperty("type")]
        public int _type { get; set; }

        [JsonProperty("id")]
        public int _id { get; set; }

        [JsonProperty("country")]
        public string _country { get; set; }

        [JsonProperty("sunrise")]
        public int _sunrise { get; set; }

        [JsonProperty("sunset")]
        public int _sunset { get; set; }
    }
}
