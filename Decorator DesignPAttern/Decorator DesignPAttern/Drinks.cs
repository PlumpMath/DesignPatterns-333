using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPAttern
{
    public class ColdCoffee : IBeverage 
    {
        public int Cost()
        {
            return 10;
        }

        public string Description()
        {
            return "Cold Coffee, ";
        }
    }

    class HotChocolate : IBeverage
    {
        public int Cost()
        {
            return 15;
        }

        public string Description()
        {
            return "Hot Chocolate, ";
        }
    }
}
