using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Weather
{
    public class CurrentConditionsSubscriber : ISubscriber
    {
        public int Temprature { get; set; }
        public int Preassure { get; set; }
        public int Humidity { get; set; }

        public CurrentConditionsSubscriber(int temp, int pres, int hum)
        {
            this.Preassure = pres;
            this.Temprature = temp;
            this.Humidity = hum;
        }

        public void Update(int temp, int humidity, int preassure)
        {
            this.Preassure = preassure;
            this.Temprature = temp;
            this.Humidity = humidity;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Current Weather Conditions - Temprature : {0} | Preassure : {1} | Humidity : {2}",Temprature,Preassure,Humidity);
        }
    }
}
