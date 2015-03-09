using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPAttern
{
    public abstract class BeverageDecorator : IBeverage
    {


        public abstract int Cost();

        public abstract string Description();
    }
}
