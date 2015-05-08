using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Weather
{
    public class WeatherPredictSubscriber : ISubscriber
    {
        public int Preassure { get; set; }
        public int Temprature { get; set; }

        public WeatherPredictSubscriber(int temp, int pres)
        {
            this.Preassure = pres;
            this.Temprature = temp;
        }

        public void Update(int temp, int humidity, int preassure)
        {
            this.Preassure = preassure;
            this.Temprature = temp;
            Display();
        }

        public void Display()
        {
            Console.WriteLine("Weather Conditions As Predicted - Temprature : {0} | Preassure : {1}", Temprature + 10, Preassure + 15);
        }
    }
}
