using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherObserver
{
    internal class WeatherStation : IObservable
    {
        private readonly List<IObserver> _observers = new();

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
        public void Add(IObserver observer)
        {
            _observers.Add(observer);
        }

        public void Notify()
        {
            foreach (var observer in _observers)
            {
                observer.Update();
            }
        }

        public void Remove(IObserver observer)
        {
            _observers.Remove(observer);
        }
    }
}
