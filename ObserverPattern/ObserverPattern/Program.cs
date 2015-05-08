using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ObserverPattern.Weather;

namespace ObserverPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //create new subscribers
            ISubscriber rain = new RainConditionsSubscriber(60);
            ISubscriber curr = new CurrentConditionsSubscriber(60, 60, 60);
            ISubscriber pred = new WeatherPredictSubscriber(56, 40);
            
            //register subscribers
            WeatherData weather = new WeatherData(74, 24, 60);
            weather.RegisterSubscriber(rain);
            weather.RegisterSubscriber(curr);
            weather.RegisterSubscriber(pred);

            //update weather conditions
            weather.SetWeatherData(76, 24, 60);
            weather.SetWeatherData(84, 44, 80);

            Console.ReadKey();
        }
    }
}
