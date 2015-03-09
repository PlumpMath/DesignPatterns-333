using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPAttern
{
    class Program
    {
        static void Main(string[] args)
        {
            IBeverage bev = new Mocha(new ColdCoffee());
            int cost = bev.Cost();
            string desc = bev.Description();
            Console.WriteLine("Cost : {0}", cost);
            Console.WriteLine("Cost : {0}", desc);

            Console.ReadKey();
        }
    }
}
