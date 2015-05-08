using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdapterPattern.MediaPlayer;

namespace AdapterPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            IWinAmpPlayer p1 = new WinAmp();
            p1.Play();

            IWinAmpPlayer p = new MediaAdapter();
            p.Play();

            Console.ReadKey();
        }
    }
}
