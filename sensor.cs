using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    
    internal class Sensor
    {
        private Broker _broker;
        public Sensor(Broker broker)
        {
            _broker = broker;
        }

        private int _currentTemprature { get; set; }
        public void ChangeTemprature(int newTemprature)
        {
            _currentTemprature = newTemprature;
            _broker.publish(Display.message, new tempargs(newTemprature));
        }

        
    }
}
