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

using System.Drawing;
using System.Windows.Controls;
using System.Windows.Media.Imaging;
using System.Windows.Media;
using System.Drawing.Imaging;

using System.Collections.ObjectModel;

namespace WeatherApp_2._0
{
    class WeatherAppViewModel : BaseClass
    {
        WeatherMainClass _weatherMainClass = new WeatherMainClass();
        WeatherForecastMainClass _weatherForecastMainClass = new WeatherForecastMainClass();
        ObservableCollection<ForecastSummaryDisplayClass> _forecastDisplayClassList = new ObservableCollection<ForecastSummaryDisplayClass>();
        ObservableCollection<WeatherDiscriptionCurrentClass> _weatherDiscriptionCurrentClass = new ObservableCollection<WeatherDiscriptionCurrentClass>();
        WeatherInformationRequestingClass _wInfo;

        public ActionCommand DoWeatherRequest { get; set; }
        public ActionCommand OpenOptions { get; set; }


        public WeatherAppViewModel()
        {
            //Optionen Laden!!!
            LoadOptions();
            _wInfo = new WeatherInformationRequestingClass(SelectedCityInformation);

            DoWeatherRequest = new ActionCommand(DoWeatherRequestMethod, DoWeatherRequestCanExecute);
            OpenOptions = new ActionCommand(OpenOptionsMethod, OpenOptionsCanExecute);

            GetCurrentWeatherData();
            GetWeatherForecastData();
        }

        private async void GetCurrentWeatherData()
        {
            try
            {
                var info = await _wInfo.CurrentWeatherData();
                _weatherMainClass = info;

                DateTime d = new DateTime(1970, 1, 1, 0, 0, 0);
                DateTime d2 = d.AddSeconds(_weatherMainClass._dt + _weatherMainClass._timezone);
                InfoRequestTime = d2;

                CloudStatus = _weatherMainClass._cloudStatus._all.ToString();
                WindDegree = _weatherMainClass._windBase._deg;
                WindSpeed = _weatherMainClass._windBase._speed.ToString();

                try
                {
                    ObservableCollection<WeatherDiscriptionCurrentClass> _dummyList = new ObservableCollection<WeatherDiscriptionCurrentClass>();

                    foreach (WeatherGrapicsIconInfo b in _weatherMainClass._weatherGrapicsIconInfoList)
                    {
                        _dummyList.Add(new WeatherDiscriptionCurrentClass(b._id, b._description));
                    }

                    WeatherDiscriptionCurrentClass = null;
                    WeatherDiscriptionCurrentClass = _dummyList;
                }
                catch(Exception e)
                {
                    Console.WriteLine(e);
                    WeatherDescription = "ERROR";
                }

                SelectedCityCountry = _weatherMainClass._systemInfo._country;

                FeelsLikeTemp = _weatherMainClass._weatherInfoBase._feelsLike.ToString();
                Humidity = _weatherMainClass._weatherInfoBase._humidity.ToString();
                Pressure = _weatherMainClass._weatherInfoBase._pressure.ToString();
                Temp = _weatherMainClass._weatherInfoBase._temp.ToString();
                TempMax = _weatherMainClass._weatherInfoBase._tempMax.ToString();
                TempMin = _weatherMainClass._weatherInfoBase._tempMin.ToString();
            }
            catch(Exception e)
            {
                Console.WriteLine(e);
            }

        }

        private async void GetWeatherForecastData()
        {
            try
            {
                var info = await _wInfo.WeatherForecastData();
                _weatherForecastMainClass = info;
                
                //Alle Vorhersage Elemente
                List<ForecastDisplayClass> _dummyList = new List<ForecastDisplayClass>();
                foreach ( ForecastBaseListElement b in _weatherForecastMainClass._weatherForecastList)
                {
                    _dummyList.Add(new ForecastDisplayClass(b._dtTXT, b._weatherInfoBase._temp, b._weatherInfoBase._humidity, b._weatherInfoBase._pressure, b._cloudStatus._all, 
                        b._weatherGrapicsIconInfoList));
                }

                //Liste mit den einzelnen Tagen
                //List<ForecastListClass> forcastDummy = new List<ForecastListClass>();
                DateTime nowDate = new DateTime();

                //Liste mit allen Tagesergebnissen
                List<ForecastDisplayClass> _forecast = new List<ForecastDisplayClass>();

                DateTime _todayPlus = new DateTime();
                _todayPlus = DateTime.Now;
                _todayPlus = _todayPlus.AddDays(3);

                ObservableCollection<ForecastSummaryDisplayClass> _forecastSummaryList = new ObservableCollection<ForecastSummaryDisplayClass>();

                //Alle Vorhersage Elemente Abarbeiten
                foreach (ForecastDisplayClass item in _dummyList)
                {
                    //Initial value
                    if (nowDate.Year == 1)
                    {
                        nowDate = new DateTime(item.ForcastTime.Year, item.ForcastTime.Month, item.ForcastTime.Day, item.ForcastTime.Hour, item.ForcastTime.Minute, item.ForcastTime.Second);
                    }
                    //Nur Vorhersagen der nächsten drei Tage
                    if(nowDate <= _todayPlus)
                    {
                        //Same Day, Same Collection
                        if (nowDate.Year == item.ForcastTime.Year && nowDate.Month == item.ForcastTime.Month && nowDate.Day == item.ForcastTime.Day)
                        {
                            _forecast.Add(item);
                        }
                        else
                        {
                            _forecastSummaryList.Add(new ForecastSummaryDisplayClass(_forecast));

                            //forcastDummy.Add(new ForecastListClass());
                            _forecast.Clear();
                            nowDate = new DateTime(item.ForcastTime.Year, item.ForcastTime.Month, item.ForcastTime.Day, item.ForcastTime.Hour, item.ForcastTime.Minute, item.ForcastTime.Second);
                        }
                    }
                    else
                    {
                        break;
                    }

                }

                ForecastDisplayClasses = null;
                ForecastDisplayClasses = _forecastSummaryList;  
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }


        DateTime _infoRequestTime;
        public DateTime InfoRequestTime
        {
            get { return _infoRequestTime; }
            set
            {
                _infoRequestTime = value;
                OnPropertyChanged();
            }
        }

        string _cloudStatus;
        public string CloudStatus
        {
            get { return _cloudStatus; }
            set
            {
                _cloudStatus = value;
                OnPropertyChanged();
            }
        }

#region wind

        int _windDegree;
        public int WindDegree
        {
            get { return _windDegree; }
            set
            {
                _windDegree = value;
                OnPropertyChanged();
            }
        }

        System.Windows.Controls.Image _windDegreePicture;
        public System.Windows.Controls.Image WindDegreePicture
        {
            get { return _windDegreePicture; }
            set
            {
                _windDegreePicture = value;
                OnPropertyChanged();
            }
        }

        string _windSpeed;
        public string WindSpeed
        {
            get { return _windSpeed; }
            set
            {
                _windSpeed = value;
                OnPropertyChanged();
            }
        }

#endregion


        string _weatherDescription;
        public string WeatherDescription
        {
            get { return _weatherDescription; }
            set
            {
                _weatherDescription = value;
                OnPropertyChanged();
            }
        }

        BitmapImage _weatherIcon;
        public BitmapImage WeatherIcon
        {
            get { return _weatherIcon; }
            set
            {
                _weatherIcon = value;
                OnPropertyChanged();
            }
        }

#region temp

        string _feelsLikeTemp;
        public string FeelsLikeTemp
        {
            get { return _feelsLikeTemp; }
            set
            {
                _feelsLikeTemp = value;
                OnPropertyChanged();
            }
        }

        string _humidity;
        public string Humidity
        {
            get { return _humidity; }
            set
            {
                _humidity = value;
                OnPropertyChanged();
            }
        }

        string _pressure;
        public string Pressure
        {
            get { return _pressure; }
            set
            {
                _pressure = value;
                OnPropertyChanged();
            }
        }

        string _temp;
        public string Temp
        {
            get { return _temp; }
            set
            {
                _temp = value;
                OnPropertyChanged();
            }
        }

        string _tempMin;
        public string TempMin
        {
            get { return _tempMin; }
            set
            {
                _tempMin = value;
                OnPropertyChanged();
            }
        }

        string _tempMax;
        public string TempMax
        {
            get { return _tempMax; }
            set
            {
                _tempMax = value;
                OnPropertyChanged();
            }
        }


        #endregion

#region Collections

        public ObservableCollection<ForecastSummaryDisplayClass> ForecastDisplayClasses
        {
            get { return _forecastDisplayClassList; }
            set
            {
                _forecastDisplayClassList = value;
                OnPropertyChanged();
            }
        }

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

#region Optionen

        string _city;

        private void LoadOptions()
        {
            string ApplicationFile = Directory.GetCurrentDirectory();
            string fileName = "_OPT.dob";
            string c = "";
            try
            {
                StreamReader streamReader = new StreamReader(ApplicationFile + "//" + fileName);
                c = streamReader.ReadLine();
                streamReader.Close();
            }
            catch(Exception e)
            {
                StreamWriter streamWriter = new StreamWriter(ApplicationFile + "//" + fileName);
                streamWriter.WriteLine("Hannover");
                streamWriter.Close();
                c = "Hannover";
            }

            SelectedCityInformation = c;
        }

        public string SelectedCityInformation
        {
            get { return _city; }
            set
            {
                _city = value;
                OnPropertyChanged();
            }
        }

        string _selectedCityCountry;
        public string SelectedCityCountry
        {
            get { return _selectedCityCountry; }
            set
            {
                _selectedCityCountry = value;
                OnPropertyChanged();
            }
        }

        #endregion

        #region Commands

        private void DoWeatherRequestMethod(object obj)
        {
            GetCurrentWeatherData();
            GetWeatherForecastData();
        }
        private bool DoWeatherRequestCanExecute(object obj)
        {
            return true;
        }

        private void OpenOptionsMethod(object obj)
        {
            Options op = new Options();
            op.ShowDialog();

            LoadOptions();

            _wInfo = new WeatherInformationRequestingClass(SelectedCityInformation);

            GetCurrentWeatherData();
            GetWeatherForecastData();
        }
        private bool OpenOptionsCanExecute(object obj)
        {
            return true;
        }

#endregion
    }
}
