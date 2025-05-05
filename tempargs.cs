using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class tempargs : EventArgs
    {
        public int TemperatureEventArgs { get; set; }
        public tempargs(int temp)
        {
            this.TemperatureEventArgs = temp;
        }
    }
}
