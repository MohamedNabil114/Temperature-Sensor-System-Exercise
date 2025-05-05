using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Alarm
    {
        public int alarmValue { get; set; }
        public Alarm(int alarmValue)
        {
            this.alarmValue = alarmValue;
        }

        public void SetAlarmValue(int newalarmValue)
        {
            alarmValue = newalarmValue;
        }

        public void FireAlarm(tempargs e)
        {
            if (e.TemperatureEventArgs > alarmValue)
            {
                Console.WriteLine($"Alarm! The temperature is greater than {alarmValue}!\n");
            }
        }

        public void subscribe(Broker broker)
        {
            broker.subscribe(Display.message, FireAlarm);
        }



    }
}
