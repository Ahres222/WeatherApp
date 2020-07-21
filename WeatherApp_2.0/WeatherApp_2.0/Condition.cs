using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WeatherApp_2._0
{
    class Condition
    {
        public Condition(int id, string des, Uri path)
        {
            ConditionID = id;
            ConditionDescription = des;
            ConditionImagePath = path;
        }

        public int ConditionID { get; set; }
        public string ConditionDescription { get; set; }
        public Uri ConditionImagePath { get; set; }
    }
}
