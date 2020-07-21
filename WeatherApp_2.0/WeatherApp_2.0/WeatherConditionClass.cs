using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WeatherApp_2._0
{
    class WeatherConditionClass
    {
        public WeatherConditionClass()
        {
            FillList();
        }

        public List<Condition> ConditionList { get; set; }

        private void FillList()
        {
            ConditionList = new List<Condition>();


            // https://openweathermap.org/weather-conditions

            //Thunderstorm
            var thunderstormPath = new Uri("pack://application:,,,/Images/thunderstorm.jpg");
            var thunderstormRainPath = new Uri("pack://application:,,,/Images/thunderstormAndRain.jpg");


            ConditionList.Add(new Condition( 200, "thunderstorm with light rain", thunderstormRainPath));
            ConditionList.Add(new Condition( 201, "thunderstorm with rain", thunderstormRainPath));
            ConditionList.Add(new Condition( 202, "thunderstorm with heavy rain", thunderstormRainPath));
            ConditionList.Add(new Condition( 210, "light thunderstorm", thunderstormPath));
            ConditionList.Add(new Condition( 211, "thunderstorm", thunderstormPath));
            ConditionList.Add(new Condition( 212, "heavy thunderstorm", thunderstormPath));
            ConditionList.Add(new Condition( 221, "ragged thunderstorm", thunderstormPath));
            ConditionList.Add(new Condition( 230, "thunderstorm with light drizzle", thunderstormRainPath));
            ConditionList.Add(new Condition( 231, "thunderstorm with drizzle", thunderstormRainPath));
            ConditionList.Add(new Condition( 232, "thunderstorm with heavy drizzle", thunderstormRainPath));


            //Drizzle(Niesel)
            var drizzelPath = new Uri("pack://application:,,,/Images/drizzel.jpg");


            ConditionList.Add(new Condition( 300, "light intensity drizzle", drizzelPath));
            ConditionList.Add(new Condition( 301, "drizzle", drizzelPath));
            ConditionList.Add(new Condition( 302, "heavy intensity drizzle", drizzelPath));
            ConditionList.Add(new Condition( 310, "light intensity drizzle rain", drizzelPath));
            ConditionList.Add(new Condition( 311, "drizzle rain", drizzelPath));
            ConditionList.Add(new Condition( 312, "heavy intensity drizzle rain", drizzelPath));
            ConditionList.Add(new Condition( 313, "shower rain and drizzle", drizzelPath));
            ConditionList.Add(new Condition( 314, "heavy shower rain and drizzle", drizzelPath));
            ConditionList.Add(new Condition( 321, "shower drizzle", drizzelPath));


            //Rain

            var rainPath = new Uri("pack://application:,,,/Images/rain.jpg");

            ConditionList.Add(new Condition( 500, "light rain", rainPath));
            ConditionList.Add(new Condition( 501, "moderate rain", rainPath));
            ConditionList.Add(new Condition( 502, "heavy intensity rain", rainPath));
            ConditionList.Add(new Condition( 503, "very heavy rain", rainPath));
            ConditionList.Add(new Condition( 504, "extreme rain", rainPath));
            ConditionList.Add(new Condition( 511, "freezing rain", rainPath));
            ConditionList.Add(new Condition( 520, "light intensity shower rain", rainPath));
            ConditionList.Add(new Condition( 521, "shower rain", rainPath));
            ConditionList.Add(new Condition( 522, "heavy intensity shower rain", rainPath));
            ConditionList.Add(new Condition( 531, "ragged shower rain", rainPath));


            //Snow

            var snowPath = new Uri("pack://application:,,,/Images/snow.jpg");
            var snowRainPath = new Uri("pack://application:,,,/Images/snow and rain.jpg");

            ConditionList.Add(new Condition( 600, "light snow", snowPath));
            ConditionList.Add(new Condition( 601, "Snow", snowPath));
            ConditionList.Add(new Condition( 602, "Heavy snow", snowPath));
            ConditionList.Add(new Condition( 611, "Sleet", snowPath));
            ConditionList.Add(new Condition( 612, "Light shower sleet", snowPath));
            ConditionList.Add(new Condition( 613, "Shower sleet", snowPath));
            ConditionList.Add(new Condition( 615, "Light rain and snow", snowRainPath));
            ConditionList.Add(new Condition( 616, "Rain and snow", snowRainPath));
            ConditionList.Add(new Condition( 620, "Light shower snow", snowRainPath));
            ConditionList.Add(new Condition( 621, "Shower snow", snowRainPath));
            ConditionList.Add(new Condition( 622, "Heavy shower snow", snowRainPath));


            //Atmosphere 

            var mistPath = new Uri("pack://application:,,,/Images/mist.fog.nebel.jpg");
            var sandPath = new Uri("pack://application:,,,/Images/sand.jpg");
            var ashPath = new Uri("pack://application:,,,/Images/ash.jpg");
            var squallPath = new Uri("pack://application:,,,/Images/squall.boe.jpg");
            var tornadoPath = new Uri("pack://application:,,,/Images/tornado.jpg");


            ConditionList.Add(new Condition( 701, "Mist", mistPath));
            ConditionList.Add(new Condition( 711, "Smoke", mistPath));
            ConditionList.Add(new Condition( 721, "Haze", mistPath));
            ConditionList.Add(new Condition( 731, "Dust", mistPath));
            ConditionList.Add(new Condition( 741, "Fog", mistPath));
            ConditionList.Add(new Condition( 751, "Sand", sandPath));
            ConditionList.Add(new Condition( 761, "Dust", sandPath));
            ConditionList.Add(new Condition( 762, "Ash", ashPath));
            ConditionList.Add(new Condition( 771, "Squall",squallPath));
            ConditionList.Add(new Condition( 781, "Tornado",tornadoPath));


            //Clear
            var clearPath = new Uri("pack://application:,,,/Images/clear.jpg");

            ConditionList.Add(new Condition( 800, "Clear",clearPath));


            //Clouds
            var cloudsPath = new Uri("pack://application:,,,/Images/clouds.jpg");

            ConditionList.Add(new Condition( 801, "few clouds: 11-25%", cloudsPath));
            ConditionList.Add(new Condition( 802, "scattered clouds: 25-50%", cloudsPath));
            ConditionList.Add(new Condition( 803, "broken clouds: 51-84%", cloudsPath));
            ConditionList.Add(new Condition( 804, "overcast clouds: 85-100%", cloudsPath));

        }

    }
}
