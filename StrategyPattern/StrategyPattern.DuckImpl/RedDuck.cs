using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DuckImpl
{
    public class RedDuck : Duck
    {
        public RedDuck()
        {
            Fb = new FlySlow();
            Qb = new QuackQuack();
        }
    }
}
