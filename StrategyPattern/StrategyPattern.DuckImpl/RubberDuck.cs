using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DuckImpl
{
    public class RubberDuck : Duck
    {
        public RubberDuck()
        {
            Fb = new NoFly();
            Qb = new Squeak();
        }
    }
}
