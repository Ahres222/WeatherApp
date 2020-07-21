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

namespace WeatherApp_2._0
{
    class WeatherDiscriptionCurrentClass:BaseClass
    {

        private WeatherConditionClass _weatherConditionClass = new WeatherConditionClass();

        public WeatherDiscriptionCurrentClass(int weatherIconID, string statusTxt)
        {

            try
            {
                var path = _weatherConditionClass.ConditionList.Where(x => x.ConditionID == weatherIconID).FirstOrDefault().ConditionImagePath;
                WeatherIcon = new BitmapImage(new Uri(Directory.GetCurrentDirectory() + path.AbsolutePath, UriKind.Absolute));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

            StatusTxt = statusTxt;
        }

        BitmapImage _WeatherIcon;
        public BitmapImage WeatherIcon
        {
            get { return _WeatherIcon; }
            set
            {
                _WeatherIcon = value;
                OnPropertyChanged();
            }
        }

        string _statusTxt;
        public string StatusTxt
        {
            get { return _statusTxt; }
            set
            {
                _statusTxt = value;
                OnPropertyChanged();
            }
        }

    }
}
