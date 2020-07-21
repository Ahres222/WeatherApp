using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp_2._0.JSON_Objects.Forecast
{
    [JsonObject]
    class RainSnowInfoClass
    {
        //Rain volume for last 3 hours, mm
        [JsonProperty("rain")]
        public double _rainFallAmount { get; set; }

        [JsonProperty("snow")]
        public double _snowFallAmount { get; set; }
    }
}
