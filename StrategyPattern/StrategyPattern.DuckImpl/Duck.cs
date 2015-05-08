using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyPattern.DuckImpl
{
    public abstract class Duck
    {
        public FlyBehaviour Fb { get; set; }
        public QuackBehaviour Qb { get; set; }

        public void Swim()
        {
            Console.WriteLine("I can swim !!");
        }

        public void Fly()
        {
            Fb.Fly();
        }

        public void Quack()
        {
            Qb.Quack();
        }

        //public abstract void Display();

    }
}
