using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ObserverPattern.Weather
{
    public class RainConditionsSubscriber : ISubscriber
    {
        public int Humidity { get; set; }

        public RainConditionsSubscriber(int hum){
            this.Humidity = hum;
        }

        public void Update(int temp, int humidity, int preassure)
        {
            this.Humidity = humidity;
            Display();
        }

        public void Display()
        {
            if(Humidity > 70)
                Console.WriteLine("Humidity {0}%. High Probability Of Rains !!", Humidity);
            else Console.WriteLine("Humidity {0}%. Low Probability Of Rains !!", Humidity);
        }
    }
}
