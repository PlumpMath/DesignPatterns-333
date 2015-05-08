using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DuckImpl
{
    public class FlyFast : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I fly fast !!");
        }
    }
}
