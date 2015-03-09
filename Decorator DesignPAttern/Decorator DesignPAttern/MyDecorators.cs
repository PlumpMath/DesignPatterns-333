using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_DesignPAttern
{
    public class Whip : BeverageDecorator
    {
        private IBeverage bev;

        public Whip(IBeverage b)
        {
            bev = b;
        }



        public override int Cost()
        {
            return bev.Cost() + 5;
        }

        public override string Description()
        {
            return string.Concat("Whip ,",bev.Description());
        }
    }

    public class Mocha : BeverageDecorator
    {
        private IBeverage bev;

       public Mocha(IBeverage b)
        {
            bev = b;
        }


        public override int Cost()
        {
            return bev.Cost() + 8;
        }

        public override string Description()
        {
            return string.Concat("Mocha ," , bev.Description());
        }
    }
}
