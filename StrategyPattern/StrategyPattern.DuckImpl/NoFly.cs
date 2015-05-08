using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DuckImpl
{
    public class NoFly : FlyBehaviour
    {
        public void Fly()
        {
            Console.WriteLine("I dont fly !!");
        }
    }
}
