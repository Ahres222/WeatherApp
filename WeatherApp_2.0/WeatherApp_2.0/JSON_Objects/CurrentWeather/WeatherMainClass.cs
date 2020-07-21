using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace WeatherApp_2._0.JSON_Objects.CurrentWeather
{
    [JsonObject]
    class WeatherMainClass
    {
        [JsonProperty("base")]
        public string _base { get; set; }

        [JsonProperty("visibility")]
        public int _visibility { get; set; }
        //????
        [JsonProperty("dt")]
        public int _dt { get; set; }

        [JsonProperty("timezone")]
        public int _timezone { get; set; }

        [JsonProperty("id")]
        public int _id { get; set; }

        [JsonProperty("name")]
        public string _name { get; set; }

        [JsonProperty("cod")]
        public int _cod { get; set; }


        [JsonProperty("coord")]
        public CoordinationClass _coordination { get; set; }

        [JsonProperty("weather")]
        public List<WeatherGrapicsIconInfo> _weatherGrapicsIconInfoList { get; set; }

        [JsonProperty("main")]
        public WeatherInfoBase _weatherInfoBase { get; set; }

        [JsonProperty("wind")]
        public WindBaseClass _windBase { get; set; }

        [JsonProperty("clouds")]
        public CloudStatusClass _cloudStatus { get; set; }

        [JsonProperty("sys")]
        public SystemInfoClass _systemInfo  { get; set; }
    }

}
