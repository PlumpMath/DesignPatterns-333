using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.BankWithdrawal
{
    public class Balance
    {
        public int MinBalance { get; set; }
        public int AvailableBalance { get; set; }

        public Balance()
        {
            this.MinBalance = 100;
            this.AvailableBalance = 1000;
        }

        public bool CheckMinBalance(int bal)
        {
            if (AvailableBalance - bal > MinBalance)
            {
                return true;
            }
            Console.WriteLine("Insufficient Funds !!");
            return false;
        }

        public void WithdrawMoney(int amount)
        {
            AvailableBalance -= amount;
            Console.WriteLine("Money withdrawn {0}", amount);
            Console.WriteLine("Available Funds {0}", AvailableBalance);

        }

        public void DepositMoney(int amount)
        {
            AvailableBalance += amount;
            Console.WriteLine("Money Deposited {0}", amount);
            Console.WriteLine("Available Funds {0}", AvailableBalance);
        }
    }
}
