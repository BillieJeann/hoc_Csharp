using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Kethua
{
    internal class Bank
    {
        public static long idindex = (long)Math.Pow(10, 13);
        private long _id;
        public long Id
        {
            get => _id;
            set
            {
                if (value == 0)
                {
                    _id = idindex++;
                }
                else
                {
                    _id = value;
                }
            }
        }
        public string AccName { get; set; }
        public long Balance { get; set; }
        public string BankName { get; set; }
        public int ValidMonth { get; set; }
        public int ValidYear { get; set; }
        private string _pin;
        public string Pin
        {
            get => _pin;
            set
            {
                if (value.ToString().Length != 6)
                {
                    _pin = "000000";
                }
                else
                {
                    _pin = value;
                }
            }
        }
        public long SumofDailyTransaction { get; set; }
        public Bank()
        {

        }
        public Bank(long id)
        {
            Id = id;
        }
        public Bank(long id, string accname, long balance, string bankname, int validmonth, int validyear, string pin) : this(id)
        {
            AccName = accname;
            Balance = balance;
            BankName = bankname;
            ValidMonth = validmonth;
            ValidYear = validyear;
            Pin = pin;
        }
        public virtual void CheckBalance()
        {
            Console.Write($"Số dư của tài khoản {Id} là : {Balance}");
        }
        public virtual int Recharge(long amount)
        {
            if (amount < 0)
            {
                return 0;
            }
            Balance += amount;
            return 1;

        }
        public virtual int Withdraw(long amount)
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
            if (amount > limit)
            {
                return 0;
            }
            Balance -= amount + charge;
            SumofDailyTransaction += amount;
            return 1;
        }
        public virtual int Transfer(Bank desbank , long amount)
        {
            long limit = (long)(5 * Math.Pow(10, 8));
            while (true)
            {
                
                if (amount < 0)
                {
                    return 0;
                }
                if (amount > Balance || Balance - amount < 50000)
                {
                    return 0;
                }
                if (amount > limit)
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
}
