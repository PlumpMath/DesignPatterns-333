using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DuckImpl
{
    public class WhiteDuck : Duck
    {
        public WhiteDuck()
        {
            Fb = new FlyFast();
            Qb = new QuackQuack();
        }
    }
}
