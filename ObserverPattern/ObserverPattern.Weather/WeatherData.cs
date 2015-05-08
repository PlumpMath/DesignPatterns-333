using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Weather
{
    public class WeatherData : ISubject
    {
        public int Temprature { get; set; }
        public int Preassure { get; set; }
        public int Humidity { get; set; }
        public List<ISubscriber> Subscribers { get; set; }

        public WeatherData(int temp, int pres, int hum)
        {
            this.Preassure = pres;
            this.Temprature = temp;
            this.Humidity = hum;
            Subscribers = new List<ISubscriber>();
        }

        public void RegisterSubscriber(ISubscriber subc)
        {
            Subscribers.Add(subc);
        }

        public void RemoveSubscriber(ISubscriber subc)
        {
            foreach (var s in Subscribers)
            {
                if (s == subc)
                    Subscribers.Remove(s);
            }
        }

        public void NotifySubscribers()
        {
            foreach (var s in Subscribers)
            {
                s.Update(Temprature, Humidity, Preassure);
            }
        }

        public void WeatherChanged()
        {
            NotifySubscribers();
        }

        public void SetWeatherData(int temp, int pres, int hum)
        {
            Temprature = temp;
            Preassure = pres;
            Humidity = hum;
            WeatherChanged();
        }
    }
}
