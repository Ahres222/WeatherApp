using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;

using System.IO;
using Newtonsoft.Json;
using WeatherApp_2._0.JSON_Objects.CurrentWeather;
using WeatherApp_2._0.JSON_Objects.Forecast;

namespace WeatherApp_2._0
{
    class WeatherInformationRequestingClass
    {
        static HttpClient _client = new HttpClient();

        string _myID = "113fada86bc7ff038a895dba2d9c031b";
        string _city;
        //string _plzCode = "30161";
        //string _countryCode = "de";

        public WeatherInformationRequestingClass(string city)
        {
            _city = city;
        }

        public WeatherInformationRequestingClass()
        {}

        public async Task<WeatherMainClass> CurrentWeatherData()
        {
            string apiCallString = "https://api.openweathermap.org/data/2.5/weather?q=" + _city + ",&units=metric" + "&lang=de" + "&appid=" + _myID;

            try
            {
                HttpResponseMessage response = await _client.GetAsync(apiCallString);
                if (response.IsSuccessStatusCode)
                {
                    var p = await response.Content.ReadAsStringAsync();
                    var obj = CreateOjectsFromJSONCurrentWeather(p);
                    return obj;
                }
                else
                {
                    Console.WriteLine(response.ReasonPhrase);
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }

        }

        //Create Objekt from Json Text
        private WeatherMainClass CreateOjectsFromJSONCurrentWeather(string txt)
        {
            try
            {
                var myObject = JsonConvert.DeserializeObject<WeatherMainClass>(txt);
                return myObject;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }



        //https://openweathermap.org/forecast5

        public async Task<WeatherForecastMainClass> WeatherForecastData()
        {
            string apiCallString = "https://api.openweathermap.org/data/2.5/forecast?q=" + _city + ",&units=metric" + "&lang=de" + "&appid=" + _myID;

            try
            {
                HttpResponseMessage response = await _client.GetAsync(apiCallString);
                if (response.IsSuccessStatusCode)
                {
                    string p = await response.Content.ReadAsStringAsync();
                    var obj = CreateOjectsFromJSONForecastWeather(p);
                    return obj;
                }
                else
                {
                    Console.WriteLine(response.ReasonPhrase);
                    return null;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                return null;
            }

        }

        //Create Objekt from Json Text
        private WeatherForecastMainClass CreateOjectsFromJSONForecastWeather(string txt)
        {
            try
            {
                var myObject = JsonConvert.DeserializeObject<WeatherForecastMainClass>(txt);
                return myObject;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return null;
            }
        }
    }
}
