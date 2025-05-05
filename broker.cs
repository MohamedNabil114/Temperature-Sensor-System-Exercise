using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Temperature_Sensor
{
    internal class Broker
    {
        private Dictionary<string, List<Action<tempargs>>> _subscriberlist = new Dictionary<string, List<Action<tempargs>>>();
        public void subscribe(string subject, Action<tempargs> action)
        {
            if (!_subscriberlist.ContainsKey(subject))
            {
                _subscriberlist[subject] = new List<Action<tempargs>>();
            }

            _subscriberlist[subject].Add(action);
        }

        public void publish(string subject, tempargs message )
        {
            if (_subscriberlist.ContainsKey(subject))
            {
                List<Action<tempargs>> subscribers = _subscriberlist[subject];
                foreach (var subscriber in subscribers)
                {
                subscriber.Invoke(message);
                }
            }
        }
    }
}
