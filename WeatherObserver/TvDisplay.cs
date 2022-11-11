using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    internal class TvDisplay
    {
        public void OnWeatherUpdate(object? sender, WeatherEventArgs eventArgs)
        {
            Console.WriteLine("TV Update: Temp is " + eventArgs.Temperature);
        }
    }
}
