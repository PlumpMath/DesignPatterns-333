using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.BankWithdrawal
{
    public class SecurityCode
    {
        public int Code { get; set; }

        public SecurityCode()
        {
            this.Code = 1234;
        }

        public bool CheckValidCode(int code)
        {
            if (Code == code)
                return true;
            return false;
        }
    }
}
