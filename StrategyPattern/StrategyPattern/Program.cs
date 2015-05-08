using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using StrategyPattern.DuckImpl;

namespace StrategyPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            //creating object of white duck 
            Duck d = new WhiteDuck();
            d.Fly();
            d.Fb = new FlySlow();
            
            d.Quack();
            d.Fly();

            //creating object of red duck 
            d = new RedDuck();
            d.Fly();
            d.Quack();

            //creating object of rubber duck 
            d = new RubberDuck();
            d.Fly();
            d.Quack();

            //creating object of wooden duck 
            d = new WoodenDuck();
            d.Fly();
            d.Quack();



            Console.ReadKey();
        }
    }
}
