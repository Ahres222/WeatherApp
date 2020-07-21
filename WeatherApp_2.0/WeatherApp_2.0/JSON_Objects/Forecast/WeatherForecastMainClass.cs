using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Newtonsoft.Json;

namespace WeatherApp_2._0.JSON_Objects.Forecast
{
    [JsonObject]
    class WeatherForecastMainClass
    {
        
        [JsonProperty("cod")]
        public int _cod { get; set; }

        [JsonProperty("message")]
        public int _message { get; set; }

        [JsonProperty("cnt")]
        public int _cnt { get; set; }

        [JsonProperty("list")]
        public List<ForecastBaseListElement> _weatherForecastList { get; set; }

        [JsonProperty("city")]
        public CityClass _city { get; set; }   
    }
}
