using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Karros.DataObjects
{
    public class Record
    {
        private string _DeviceID;
        public string DeviceID
        {
            get { return _DeviceID; }
            set { _DeviceID = value; }
        }
        private string _Vin;
        public string Vin
        {
            get { return _Vin; }
            set { _Vin = value; }
        }
        private string _Odometer;
        public string Odometer
        {
            get { return _Odometer; }
            set { _Odometer = value; }
        }
        private string _Insertiontime;
        public string Insertiontime
        {
            get { return _Insertiontime; }
            set { _Insertiontime = value; }
        }

        public Record() { }


    }
}
