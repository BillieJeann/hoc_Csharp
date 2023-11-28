using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethua
{
    internal class Savingaccount : Bank
    {
        public int TimeDeposit { get; set; }
        public double InterestRate { get; set; }
        public long Interest { get; set; }
        public Savingaccount()
        {

        }
        public Savingaccount(long id, string accname, long balance, string bankname, int validmonth, int validyear, string pin, int timeDeposit, double interestRate, long interest) : base(id, accname, balance, bankname, validmonth, validyear, pin)
        {
            TimeDeposit = timeDeposit;
            InterestRate = interestRate;
            Interest = interest;
        }
        public override int Withdraw(long amount)
        {
            int charge = 1100;
            long limit = (long)(5 * Math.Pow(10, 6));

            if (amount < 0)
            {
                return 0;
            }
            if (amount > Balance || Balance - amount < 50000)
            {
                return 0;
            }

            if (SumofDailyTransaction >= limit || amount >= limit)
            {
                return 0;
            }
            SumofDailyTransaction += amount;
            Balance -= amount + charge;
            return 1;

        }
        public override int Transfer(Bank desbank, long amount)
        {
            long limit = (long)(5 * Math.Pow(10, 8));
            if (amount < 0)
            {
                return 0;
            }
            if (amount > Balance || Balance - amount < 50000)
            {
                return 0;
            }
            if (SumofDailyTransaction + amount >= limit)
            {
                return 0;
            }
            Balance -= amount;
            desbank.Balance += amount;
            SumofDailyTransaction += amount;
            return 1;

        }
    }
}
