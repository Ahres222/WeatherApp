using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

namespace WeatherApp_2._0.OptionWindow
{
    class OptionsViewModel: BaseClass
    {

        public ActionCommand SaveCommand { get; set; }
        public ActionCommand OpenOptions { get; set; }

        Options _option;

        public OptionsViewModel(Options op) 
        {
            SaveCommand = new ActionCommand(SaveCommandMethod, SaveCommandCanExecute);
            _option = op;
            ReadOptionsFile();
        }

        private void SaveCommandMethod(object obj)
        {
            WriteOptionsFile(CityOption);
            _option.Close();
        }
        private bool SaveCommandCanExecute(object obj)
        {
            return true;
        }

        //string _pLZOption;
        //public string PLZOption
        //{
        //    get { return _pLZOption; }
        //    set
        //    {
        //        _pLZOption = value;
        //        OnPropertyChanged();
        //    }
        //}

        //string _countryOption;
        //public string CountryOption
        //{
        //    get { return _countryOption; }
        //    set
        //    {
        //        _countryOption = value;
        //        OnPropertyChanged();
        //    }
        //}

        string _cityOption;
        public string CityOption
        {
            get { return _cityOption; }
            set
            {
                _cityOption = value;
                OnPropertyChanged();
            }
        }



        private void ReadOptionsFile()
        {
            string ApplicationFile = Directory.GetCurrentDirectory();
            string fileName = "_OPT.dob";

            if (!File.Exists(ApplicationFile + "//" + fileName))
            {
                File.Create(ApplicationFile + "//" + fileName);

                WriteOptionsFile("Hannover");
            }
            else
            {
                StreamReader streamReader = new StreamReader(ApplicationFile + "//" + fileName);
                var c = streamReader.ReadLine();
                streamReader.Close();

                CityOption = c;
            }

        }

        private void WriteOptionsFile(string city)
        {
            string ApplicationFile = Directory.GetCurrentDirectory();
            string fileName = "_OPT.dob";

            StreamWriter streamWriter = new StreamWriter(ApplicationFile + "//" + fileName);
            streamWriter.WriteLine(city);
            streamWriter.Flush();
            streamWriter.Close();
        }


    }
}
