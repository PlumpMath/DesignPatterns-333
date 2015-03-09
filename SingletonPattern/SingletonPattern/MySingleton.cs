using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingletonPattern
{
    public class MySingleton
    {
        private static volatile MySingleton s;
        private static object syncLock = new object();

        private MySingleton() { }

        public static MySingleton GetInstance(){
            if(s==null)
            {
                lock (syncLock) {
                    if (s == null)
                        s = new MySingleton();
                }
            }
            return s;
        }
    }
}
