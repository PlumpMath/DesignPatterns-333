using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.BankWithdrawal
{
    public class Account
    {
        public int AccNum { get; set; }

        public Account()
        {
            this.AccNum = 123456789;
        }

        public bool CheckValidAccount(int accnum)
        {
            if (AccNum == accnum)
                return true;
            return false;
        }
    }
}
