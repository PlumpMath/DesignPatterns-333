using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public abstract class IceCreamStore
    {
        public void OrderIceCream(string flavor)
        {
             
            IceCream ic = MakeIceCream(flavor);
            Console.WriteLine(ic.PrepareIceCream());
            Console.WriteLine(ic.GetCost());
            Console.WriteLine(ic.PackIceCream());
        }


        public abstract IceCream MakeIceCream(string type);
    }

    public class FCRoadStore : IceCreamStore {

        public override IceCream MakeIceCream(string type)
        {
            IceCream ice;
            if (string.Equals(type, "kiwi"))
                return new FCRoadKiwiIceCream();
            else return new FCRoadMangoIceCream();
        }
    }

    public class JMRoadStore : IceCreamStore
    {

        public override IceCream MakeIceCream(string type)
        {
            IceCream ice;
            if (string.Equals(type, "kiwi"))
                return new JMRoadKiwiIceCream();
            else return new JMRoadMangoIceCream();
        }
    }
}
