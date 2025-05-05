using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Display
    {

        public const string message = "Temprature changed";

        public void subscribe(Broker broker)
        {
            broker.subscribe(message, DisplayTemprature);
        }

        public void DisplayTemprature(tempargs e)
        {
            Console.WriteLine($"The current temperature is {e.TemperatureEventArgs} degrees.");
        }
    }
}
