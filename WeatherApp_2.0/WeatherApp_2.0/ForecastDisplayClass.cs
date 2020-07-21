using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Drawing.Imaging;
using System.IO;

using System.Collections.ObjectModel;

using WeatherApp_2._0.JSON_Objects.CurrentWeather;

namespace WeatherApp_2._0
{
    class ForecastDisplayClass:BaseClass
    {
        private WeatherConditionClass _weatherConditionClass = new WeatherConditionClass();

        public ForecastDisplayClass(string forcastTime, double temp, int humi, int pressu, int cloudStat, List<WeatherGrapicsIconInfo> _weatherGrapicsIconInfos)
        {
            try
            {
                var d = System.Convert.ToDateTime(forcastTime);
                //Error wegen nicht reservierten Speicher ?????
                ForcastTime = d;

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            try
            {
                List<WeatherDiscriptionCurrentClass> _dummyList = new List<WeatherDiscriptionCurrentClass>();
                foreach (WeatherGrapicsIconInfo b in _weatherGrapicsIconInfos)
                {
                    _dummyList.Add(new WeatherDiscriptionCurrentClass(b._id, b._description));
                }

                //var path = _weatherConditionClass.ConditionList.Where(x => x.ConditionID == weatherIconID).FirstOrDefault().ConditionImagePath;
                //ForcastWeatherIcon = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + path.AbsolutePath, UriKind.Absolute));
                WeatherDiscriptionCurrentClass.Clear();
                WeatherDiscriptionCurrentClass = _dummyList;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            Temprature = temp;
            Humidity = humi;
            Pressure = pressu;
            CloudStatus = cloudStat;
            //StatusTxt = statusTxt;
        }


        DateTime _forcastTime;
        public DateTime ForcastTime
        {
            get { return _forcastTime; }
            set
            {
                _forcastTime = value;
                OnPropertyChanged();
            }
        }

        double _temprature;
        public double Temprature        
        {
            get { return _temprature; }
            set
            {
                _temprature = value;
                OnPropertyChanged();
            }
        }

        int _humidity;
        public int Humidity
        {
            get { return _humidity; }
            set
            {
                _humidity = value;
                OnPropertyChanged();
            }
        }

        int _pressure;
        public int Pressure
        {
            get { return _pressure; }
            set
            {
                _pressure = value;
                OnPropertyChanged();
            }
        }

        int _cloudStatus;
        public int CloudStatus
        {
            get { return _cloudStatus; }
            set
            {
                _cloudStatus = value;
                OnPropertyChanged();
            }
        }

        List<WeatherDiscriptionCurrentClass> _weatherDiscriptionCurrentClass = new List<WeatherDiscriptionCurrentClass>();
        public List<WeatherDiscriptionCurrentClass> WeatherDiscriptionCurrentClass
        {
            get { return _weatherDiscriptionCurrentClass; }
            set
            {
                _weatherDiscriptionCurrentClass = value;
                OnPropertyChanged();
            }
        }

    }
}
