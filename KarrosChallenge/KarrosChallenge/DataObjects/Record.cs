using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KarrosChallenge.DataObjects
{
    public class Record
    {
        private string DeviceID;
        public string DeviceIDObj
        {
            get { return DeviceID; }
            set { DeviceID = value; }
        }
        private string Vin;
        public string VinObj
        {
            get { return Vin; }
            set { Vin = value; }
        }
        private string odometer;
        public string odometerObj
        {
            get { return odometer; }
            set { odometer = value; }
        }
        private string insertiontime;
        public string insertiontimeObj
        {
            get { return insertiontime; }
            set { insertiontime = value; }
        }
    }
}
