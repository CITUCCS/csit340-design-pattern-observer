using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    internal class PhoneDisplay : IObserver
    {
        private readonly WeatherStation _weatherStation;

        public PhoneDisplay(WeatherStation weatherStation)
        {
            _weatherStation = weatherStation;
        }

        public void Update()
        {
            Console.WriteLine("Phone Update: Temp is " + _weatherStation.Temperature);
        }
    }
}
