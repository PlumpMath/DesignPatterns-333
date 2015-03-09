using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryDesignPattern
{
    public abstract class IceCream
    {
        protected int Cost { get; set; }
        protected String Container { get; set; }

       
        public abstract string PrepareIceCream();

        public abstract int GetCost();
        
        public string PackIceCream() { return "Ice cream packed !!"; }
    }

    public class FCRoadMangoIceCream : IceCream
    {
        public override int GetCost() { return 50; }

        public override string PrepareIceCream()
        {
            return "FC Mango";
        }
    }

    public class JMRoadMangoIceCream : IceCream
    {
        public override int GetCost() { return 40; }
        
        public override string PrepareIceCream()
        {
            return "JM Mango";
        }
    }

    public class FCRoadKiwiIceCream : IceCream
    {
        public override int GetCost() { return 30; }

        public override string PrepareIceCream()
        {
            return "FC Kiwi";
        }
    }

    public class JMRoadKiwiIceCream : IceCream
    {
        public override int GetCost() { return 20; }

        public override string PrepareIceCream()
        {
            return "JMRoad Kiwi";
        }
    }



}
