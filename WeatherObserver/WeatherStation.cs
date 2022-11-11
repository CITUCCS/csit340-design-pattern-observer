using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    internal class WeatherStation
    {
        public event EventHandler<WeatherEventArgs>? WeatherEvent;

        private int _temp = 60;
        public int Temperature { 
            get 
            { 
                return _temp; 
            } 
            set 
            { 
                // Once we set a new value for temp, we notify all observers
                _temp = value;
                Notify();
            } 
        }
        private void Notify()
        {
            WeatherEvent?.Invoke(this, new WeatherEventArgs { Temperature = _temp });
        }
    }
}
