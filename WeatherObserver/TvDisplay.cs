using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    internal class TvDisplay : IObserver
    {
        private readonly WeatherStation _weatherStation;

        public TvDisplay(WeatherStation weatherStation)
        {
            _weatherStation = weatherStation;
        }

        public void Update()
        {
            Console.WriteLine("TV Update: Temp is " + _weatherStation.Temperature);
        }
    }
}
