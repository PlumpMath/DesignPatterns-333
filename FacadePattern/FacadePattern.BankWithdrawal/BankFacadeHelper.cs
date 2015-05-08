using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FacadePattern.BankWithdrawal
{
    //bank facade to call bank related methods
    public class BankFacadeHelper
    {
        public int AccNum { get; set; }
        public int Code { get; set; }

        public Account Account { get; set; }
        public Balance Balance { get; set; }
        public SecurityCode SecurityCode { get; set; }

        public BankFacadeHelper(int accnum, int code)
        {
            this.AccNum = accnum;
            this.Code = code;

            //instantiating 
            this.Account = new Account();
            this.SecurityCode = new SecurityCode();
            this.Balance = new Balance();
        }

        //delegating to balance class for withdrawal
        public void Withdraw(int amt)
        {
            if (Account.CheckValidAccount(AccNum) && SecurityCode.CheckValidCode(Code) && Balance.CheckMinBalance(amt))
                Balance.WithdrawMoney(amt);

        }

        //delegating to balance to deposit money
        public void Deposit(int amt)
        {
            if (Account.CheckValidAccount(AccNum) && SecurityCode.CheckValidCode(Code))
                Balance.DepositMoney(amt);

        }
    }
}
