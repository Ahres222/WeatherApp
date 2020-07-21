using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Collections.ObjectModel;
using WeatherApp_2._0.JSON_Objects.CurrentWeather;

namespace WeatherApp_2._0
{
    class ForecastSummaryDisplayClass:BaseClass
    {


        public ForecastSummaryDisplayClass(List<ForecastDisplayClass> forcastDay)
        {
            try
            {
                _dayOfForcast = new DateTime();
                _dayOfForcast = forcastDay.FirstOrDefault().ForcastTime;
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

            MinDayTempValue = forcastDay.Min(x=> x.Temprature);
            MaxDayTempValue = forcastDay.Max(x => x.Temprature);
            AvrDayTempValue = (forcastDay.Sum(x => x.Temprature) / forcastDay.Count());

            MinHummValue = forcastDay.Min(x => x.Humidity);
            MaxHummValue = forcastDay.Max(x => x.Humidity);

            MinPressure = forcastDay.Min(x => x.Pressure);
            MaxPressure = forcastDay.Max(x => x.Pressure);

            MinCloud = forcastDay.Min(x => x.CloudStatus);
            MaxCloud = forcastDay.Max(x => x.CloudStatus);


            List<WeatherDiscriptionCurrentClass> dummy = new List<WeatherDiscriptionCurrentClass>();

            // Bildinformationen für den Forcast
            List<WeatherDiscriptionCurrentClass> _dummyList = new List<WeatherDiscriptionCurrentClass>();
            foreach (ForecastDisplayClass b in forcastDay)
            {
                var wp = b.WeatherDiscriptionCurrentClass.FirstOrDefault();

                if(!dummy.Exists(x => x.StatusTxt == wp.StatusTxt))
                {
                    dummy.Add(wp);
                }
            }
            WeatherDiscriptionCurrentClass.Clear();
            
            foreach(WeatherDiscriptionCurrentClass we in dummy)
            {
                WeatherDiscriptionCurrentClass.Add(we);
            }

        }

        DateTime _dayOfForcast = new DateTime();
        public DateTime DayOfForcast
        {
            get { return _dayOfForcast; }
            set
            {
                _dayOfForcast = value;
                OnPropertyChanged();
            }
        }



        #region TEMP

        double _maxDayTempValue;
        public double MaxDayTempValue
        {
            get { return _maxDayTempValue; }
            set
            {
                _maxDayTempValue = value;
                OnPropertyChanged();
            }
        }

        double _minDayTempValue;
        public double MinDayTempValue
        {
            get { return _minDayTempValue; }
            set
            {
                _minDayTempValue = value;
                OnPropertyChanged();
            }
        }

        double _avrDayTempValue;
        public double AvrDayTempValue
        {
            get { return _avrDayTempValue; }
            set
            {
                _avrDayTempValue = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region Hummidity

        int _maxHummValue;
        public int MaxHummValue
        {
            get { return _maxHummValue; }
            set
            {
                _maxHummValue = value;
                OnPropertyChanged();
            }
        }

        int _minHummValue;
        public int MinHummValue
        {
            get { return _minHummValue; }
            set
            {
                _minHummValue = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region PRESSURE

        int _minPressure;
        public int MinPressure
        {
            get { return _minPressure; }
            set
            {
                _minPressure = value;
                OnPropertyChanged();
            }
        }

        int _maxPressure;
        public int MaxPressure
        {
            get { return _maxPressure; }
            set
            {
                _maxPressure = value;
                OnPropertyChanged();
            }
        }
        #endregion

        #region CLOUDSTATUS

        int _minCloud;
        public int MinCloud
        {
            get { return _minCloud; }
            set
            {
                _minCloud = value;
                OnPropertyChanged();
            }
        }

        int _maxCloud;
        public int MaxCloud
        {
            get { return _maxCloud; }
            set
            {
                _maxCloud = value;
                OnPropertyChanged();
            }
        }

        #endregion

        //Noch keine Finale Idee
        #region WeatherDisplay

        ObservableCollection<WeatherDiscriptionCurrentClass> _weatherDiscriptionCurrentClass = new ObservableCollection<WeatherDiscriptionCurrentClass>();
        public ObservableCollection<WeatherDiscriptionCurrentClass> WeatherDiscriptionCurrentClass
        {
            get { return _weatherDiscriptionCurrentClass; }
            set
            {
                _weatherDiscriptionCurrentClass = value;
                OnPropertyChanged();
            }
        }

        #endregion
    }
}
