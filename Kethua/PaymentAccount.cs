using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethua
{
    internal class PaymentAccount : Bank
    {
        public long DailyPaymentLimit { get; set; }
        public long InnerBankPaymentCharge { get; set; }
        public long OutterBankPaymentCharge { get; set; }
        public PaymentAccount()
        {

        }
        public PaymentAccount(long id, string accname, long balance, string bankname, int validmonth, int validyear, string pin, long payLimit, long innerCharge, long outterCharge) : base(id, accname, balance, bankname, validmonth, validyear, pin)
        {
            DailyPaymentLimit = payLimit;
            InnerBankPaymentCharge = innerCharge;
            OutterBankPaymentCharge = outterCharge;
        }
        public override int Withdraw(long amount)
        {
            long limit = (long)(5 * Math.Pow(10, 6));
            long charge = (long)(amount * 0.1);
            if (amount < 0)
            {
                return 0;
            }
            if (amount > Balance || Balance - amount - charge < 50000)
            {
                return 0;
            }
            if (SumofDailyTransaction + amount >= DailyPaymentLimit || amount >= limit)
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
            if (amount > limit || amount > DailyPaymentLimit)
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

