using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //sensor >> input >> temperature value
            // display>> interact and display the temperature value
            // alarm >> check the temperature value and display the alarm value

            // the design pattern is used in is publisher subscriber pattern
            // solid principle is used in this code is the { single responsibility principle} and {open closed principle}

            Broker broker = new Broker();

            // publisher
            Sensor sensor = new Sensor(broker); 
            // subscriber
            Display display = new Display(); 
            Alarm alarm = new Alarm(20); // default alarm value

            

            display.subscribe(broker);
            alarm.subscribe(broker);

            while (true)
            {
                Console.WriteLine("Welcome to the Temperature System");
                Console.WriteLine("1. set the the Temerature");
                Console.WriteLine("2. set the Alarm Value, defult(20)");
                Console.WriteLine("3. Exit");

                var input = Console.ReadLine();
                switch(input)
                {
                    case "1":
                        Console.WriteLine("Enter the temperature value:");
                        var temperature = Console.ReadLine();
                        int value = Convert.ToInt32(temperature);
                        sensor.ChangeTemprature(value); // change the temperature
                        break;
                    case "2":
                        Console.WriteLine("Enter the temperature value for the alarm:");
                        var alarmValue = Console.ReadLine();
                        int AlarmTemprature = Convert.ToInt32(alarmValue);
                        alarm.SetAlarmValue(AlarmTemprature); // set the alarm value
                        break;
                    case "3":
                        Console.WriteLine("Exiting the program.");
                        return;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
            }

        }

        
          
    }
}
