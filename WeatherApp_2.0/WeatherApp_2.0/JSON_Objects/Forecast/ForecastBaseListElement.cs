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
    class ForecastBaseListElement
    {
        /*
         	 "dt": 1578409200,
             "dt_txt": "2020-01-07 15:00:00"
        */

        [JsonProperty("dt")]
        public int _dt { get; set; }

        [JsonProperty("main")]
        public WeatherInfoBase _weatherInfoBase { get; set; }

        [JsonProperty("weather")]
        public List<WeatherGrapicsIconInfo> _weatherGrapicsIconInfoList { get; set; }

        [JsonProperty("clouds")]
        public CloudStatusClass _cloudStatus { get; set; }

        [JsonProperty("wind")]
        public WindBaseClass _windBase { get; set; }

        //Regen und Schnee in einer Classe
        [JsonProperty("rain")]
        public RainSnowInfoClass _rainBase { get; set; }

        [JsonProperty("snow")]
        public RainSnowInfoClass _snowBase { get; set; }

        [JsonProperty("sys")]
        public SystemInfoClass _systemInfo { get; set; }

        //Da schauen ob abweichungen vorhanden
        [JsonProperty("dt_txt")]
        public string _dtTXT { get; set; }


    }
}
