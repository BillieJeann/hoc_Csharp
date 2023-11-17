using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass.Bank
{
    internal partial class Bank
    {
        private static long _idindex = (long)Math.Pow(10, 13);
        private long _id;
        public long Id
        {
            get => _id;
            set
            {
                if (value != 0)
                {
                    _id = value;
                }
                else
                {
                    _id = _idindex++;
                }
            }
        }
        public string FullName { get; set; }
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
        public Bank(long id)
        {
            Id = id;
        }
        public Bank(long id, string fullName, long balance,string bankName, int validMonth, int validYear, string pin) : this(id)
        {
            FullName = fullName;
            Balance = balance;
            ValidMonth = validMonth;
            ValidYear = validYear;
            Pin = pin;
            BankName = bankName;
        }
        public partial void ShowBalance();
        public partial void Recharge();
        public partial void Withdraw();
        public partial void Transfer(Bank desAcc);
    }
    partial class Bank
    {
        public partial void ShowBalance()
        {
            Console.WriteLine($"Số dư của tài khoản {Id} là {Balance}");
        }
        public partial void Recharge()
        {
            Console.Write("Nhập số tiền cần nạp : ");
            long amount = long.Parse(Console.ReadLine());
            if (amount <= 0)
            {
                Console.WriteLine("Số tiền nạp không hợp lệ ");
            }
            Balance += amount;
            Console.WriteLine("Nạp tiền thành công !");
        }
        public partial void Withdraw()
        {
            Console.Write("Nhập số tiền cần rút : ");
            long amount = long.Parse(Console.ReadLine());
            if (amount <= 0)
            {
                Console.WriteLine("Số tiền rút không hợp lệ");
            }
            if (amount > Balance || Balance - amount < 50000)
            {
                Console.WriteLine("Không đủ số dư");
            }
            else
            {
                Balance -= amount;
            }
            Console.WriteLine("Rút tiền thành công !");
        }
        public partial void Transfer(Bank desAcc)
        {
            Console.Write("Nhập số tiền cần chuyển : ");
            long amount = long.Parse(Console.ReadLine());
            if (amount <= 0)
            {
                Console.WriteLine("Số tiền chuyển không hợp lệ");
            }
            if (amount > Balance || Balance - amount < 50000)
            {
                Console.WriteLine("Không đủ số dư");
            }
            else
            {
                Balance -= amount;
                desAcc.Balance += amount;
            }
            Console.WriteLine("Chuyển tiền thành công !");
        }
    }

}
