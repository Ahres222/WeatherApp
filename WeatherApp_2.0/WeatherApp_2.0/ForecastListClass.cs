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
    class ForecastListClass:BaseClass
    {
       //Nicht Sortierte Liste wird übergeben
        public ForecastListClass(List<ForecastDisplayClass> _weatherList)
        {       
            ForecastDisplayClassesCollection.Clear();
            ForecastDisplayClassesCollection = _weatherList;
        }

        List<ForecastDisplayClass> _forecastDisplayClasses = new List<ForecastDisplayClass>();
        public List<ForecastDisplayClass> ForecastDisplayClassesCollection
        {
            get { return _forecastDisplayClasses; }
            set
            {
                _forecastDisplayClasses = value;
                OnPropertyChanged();
            }
        }
    }
}
