using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FacadePattern.BankWithdrawal;

namespace FacadePattern
{
    class Program
    {
        static void Main(string[] args)
        {
            BankFacadeHelper bfh = new BankFacadeHelper(123456789, 1234);
            bfh.Withdraw(5000);
            bfh.Withdraw(200);
            bfh.Deposit(2500);

            Console.ReadKey();
        }
    }
}
