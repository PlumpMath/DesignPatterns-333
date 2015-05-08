using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DuckImpl
{
    public class QuackQuack : QuackBehaviour
    {

        public void Quack()
        {
            Console.WriteLine("I can quack !!");
        }
    }
}
