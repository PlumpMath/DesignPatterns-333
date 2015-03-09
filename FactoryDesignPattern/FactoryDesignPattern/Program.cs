using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IceCreamStore ics = new JMRoadStore();
            ics.OrderIceCream("kiwi");
            Console.ReadKey();
           
        }
    }
}
