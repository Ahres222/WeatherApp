using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;
using Newtonsoft.Json;
using WeatherApp_2._0.JSON_Objects.CurrentWeather;
using WeatherApp_2._0.JSON_Objects.Forecast;

using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Drawing.Imaging;

using System.Collections.ObjectModel;

namespace WeatherApp_2._0
{
    class TestingClass
    {

        private WeatherMainClass DummyClass()
        {

            WeatherMainClass myc = new WeatherMainClass();

            myc._base = "TEST BASE";
            myc._cod = 8008;
            myc._dt = 101;
            myc._id = 202;
            myc._name = "TEST NAME";
            myc._timezone = 0;
            myc._visibility = 100;


            CloudStatusClass cloudStatusClass = new CloudStatusClass();
            cloudStatusClass._all = 100;
            myc._cloudStatus = cloudStatusClass;


            CoordinationClass coordinationClass = new CoordinationClass();
            coordinationClass._lat = 10.2;
            coordinationClass._lon = 100.2;
            myc._coordination = coordinationClass;


            SystemInfoClass systemInfoClass = new SystemInfoClass();
            systemInfoClass._country = "GERMANYY";
            systemInfoClass._id = 101;
            systemInfoClass._sunrise = 1000;
            systemInfoClass._sunset = 2000;
            systemInfoClass._type = 141;
            myc._systemInfo = systemInfoClass;

            WeatherGrapicsIconInfo weatherGrapicsIconInfo1 = new WeatherGrapicsIconInfo();
            weatherGrapicsIconInfo1._id = 101;
            weatherGrapicsIconInfo1._description = "TEST WEATHER";
            weatherGrapicsIconInfo1._icon = "hust";
            weatherGrapicsIconInfo1._main = "juu";
            myc._weatherGrapicsIconInfoList = new List<WeatherGrapicsIconInfo>();
            myc._weatherGrapicsIconInfoList.Add(weatherGrapicsIconInfo1);


            WeatherInfoBase weatherInfoBase = new WeatherInfoBase();
            weatherInfoBase._feelsLike = 10.0;
            weatherInfoBase._humidity = 20;
            weatherInfoBase._pressure = 1000;
            weatherInfoBase._temp = 10.0;
            weatherInfoBase._tempMax = 10.0;
            weatherInfoBase._tempMin = 10.0;
            myc._weatherInfoBase = weatherInfoBase;


            WindBaseClass windBaseClass = new WindBaseClass();
            windBaseClass._deg = 241;
            windBaseClass._speed = 20.4;
            myc._windBase = windBaseClass;

            return myc;
        }
    }
}
