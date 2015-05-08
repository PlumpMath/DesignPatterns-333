using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DuckImpl
{
    public class WoodenDuck : Duck
    {
        public WoodenDuck()
        {
            Fb = new NoFly();
            Qb = new Mute();
        }

        
    }
}
