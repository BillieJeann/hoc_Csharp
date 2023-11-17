using System.Text;
using System.Collections.Generic;
using System.Linq;
using System;
using System.Threading.Tasks;

namespace Partialclass.Bank
{
    class BankFunc
    {
        internal static Bank AddAccount()
        {
            while (true)
            {
                Console.Write("Nhập tên tài khoản : ");
                string fullName = Console.ReadLine();

                Console.Write("Nhập só dư : ");
                string balance = Console.ReadLine();

                Console.Write("Nhập tên ngân hàng : ");
                string bankName = Console.ReadLine();

                Console.Write("Nhập tháng hết hạn : ");
                string validMonth = Console.ReadLine();

                Console.Write("Nhập năm hết hạn : ");
                string validYear = Console.ReadLine();

                Console.Write("Nhập mã PIN : ");
                string pin = Console.ReadLine();

                if (long.TryParse(balance, out long newBalance) == false || int.TryParse(validMonth, out int newValidMonth) == false || int.TryParse(validYear, out int newValidYear) == false || int.TryParse(pin, out int newPin) == false)
                {
                    Console.WriteLine("Nhập sai định dạng mời nhập lại : ");
                    continue;
                }
                return new Bank(0, fullName, newBalance,bankName, newValidMonth, newValidYear, pin);
            }

        }
        public static Bank CheckID(Bank[] banks , long id)
        {          
            foreach (var item in banks)
            {
                if (item != null && item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }
        internal static void CheckBalance(Bank[] banks)
        {
            Console.Write("Nhập số tài khoản ngân hàng : ");
            long id = long.Parse(Console.ReadLine());
            var searched = CheckID(banks,id);

            if (searched != null)
            {
                searched.ShowBalance();
            }
            else
            {
                Console.WriteLine("Không tìm thấy só tài khoản !");
            }
        }

        internal static void AddBalance(Bank[] banks)
        {
            Console.Write("Nhập số tài khoản ngân hàng : ");
            long id = long.Parse(Console.ReadLine());

            var searched = CheckID(banks, id);

            if (searched != null)
            {
                searched.Recharge();
            }
            else
            {
                Console.WriteLine("Không tìm thấy só tài khoản !");
            }

        }

        internal static void WithDrawMoney(Bank[] banks)
        {
            Console.Write("Nhập số tài khoản ngân hàng : ");
            long id = long.Parse(Console.ReadLine());

            var searched = CheckID(banks, id);

            if (searched != null)
            {
                if (CheckPin(searched))
                {
                    searched.Withdraw();
                }
                else
                {
                    Console.WriteLine("Sai mã PIN");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy só tài khoản !");
            }
        }

        private static bool CheckPin(Bank searched)
        {
            while (true)
            {
                Console.Write("Nhập mã pin : ");
                string pin = Console.ReadLine();

                if (int.TryParse(pin, out int newPin) == false)
                {
                    Console.WriteLine("Nhập sai định dạng mã PIN !");
                    continue;
                }

                if (pin != searched.Pin)
                {
                    return false;
                }
                return true;
            }
        }

        internal static void TransferMoney(Bank[] banks)
        {
            Console.Write("Nhập số tài khoản ngân hàng nguồn : ");
            long id = long.Parse(Console.ReadLine());
            var sourceAcc = CheckID(banks, id);

            if (sourceAcc != null)
            {
                Console.Write("Nhập số tài khoản ngân đích : ");
                id = long.Parse(Console.ReadLine());

                var desAcc = CheckID(banks, id);

                if (desAcc != null)
                {
                    if (CheckPin(sourceAcc))
                    {
                        sourceAcc.Transfer(desAcc);
                    }
                    else
                    {
                        Console.WriteLine("Sai mã PIN");
                    }
                }
                else
                {
                    Console.WriteLine("Không tìm thấy tài khoản đích !");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy tài khoản nguồn !");
            }
        }

        internal static void ShowListOfAcc(Bank[] banks)
        {
            var titleId = "SỐ TÀI KHOẢN";
            var titleFullname = "HỌ VÀ TÊN";
            var titleBalance = "SỐ DƯ";
            var titleBankName = "TÊN NGÂN HÀNG";
            var titleValidDate = "HẠN SỬ DỤNG (THÁNG/NĂM)";
            var titlePin = "MÃ PIN";
            Console.WriteLine($"{titleId,-20} {titleFullname,-20} {titleBalance,-20} {titleBankName,-20} {titleValidDate,-20}  {titlePin,-20}");
            foreach (var item in banks)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id,-20} {item.FullName,-20} {item.Balance,-20} {item.BankName,-20} {item.ValidMonth + "/" + item.ValidYear,-20}     {item.Pin,-20}");
                }
            }
        }
    }
    class Programm
    {
        static void Main()
        {
            Bank[] banks = new Bank[10];
            int index = 0;
            string key;
            bool end = true;
            Console.OutputEncoding = Encoding.UTF8;

            while (end)
            {
                Console.WriteLine("" +
                    "1) Tạo mới một tài khoản ngân hàng với đầy đủ thông tin. Lưu vào danh sách tài khoản.\r\n" +
                    "2) Kiểm tra số dư của tài khoản bằng cách nhập vào số tài khoản cần kiểm tra.\r\n" +
                    "3) Nạp tiền vào tài khoản x bằng cách nhập số tài khoản và số tiền cần nạp.\r\n" +
                    "4) Rút tiền từ tài khoản x bằng cách nhập số tài khoản, mã PIN và số tiền cần rút. Việc rút\r\ntiền chỉ thành công khi nhập đúng mã PIN, đúng số tài khoản và số tiền cần rút < số dư\r\nhiện có + 50k VNđ.\r\n" +
                    "5) Chuyển tiền từ tài khoản x sang tài khoản y. Để chuyển tiền người dùng cung cấp số tài\r\nkhoản nguồn, số tài khoản đích, số tiền cần chuyển và mã PIN. Việc chuyển tiền chỉ thành\r\ncông khi người dùng nhập đúng tài khoản nguồn, tài khoản đích, đúng mã PIN và số tiền\r\ncần chuyển phải < số dư + 50k VNđ.\r\n" +
                    "6) Hiển thị danh sách tài khoản ra màn hình dạng bảng gồm các hàng, cột.\r\n" +
                    "7) Kết thúc chương trình.\r\n");

                Console.Write("Nhập lựa chọn của bạn : ");
                key = Console.ReadLine();
                if (int.TryParse(key, out int newKey) == false)
                {
                    Console.WriteLine("Nhập sai cú pháp !");
                    continue;
                }
                switch (newKey)
                {
                    case 1:
                        banks[index++] = BankFunc.AddAccount();
                        break;
                    case 2:
                        BankFunc.CheckBalance(banks);
                        break;
                    case 3:
                        BankFunc.AddBalance(banks);
                        break;
                    case 4:
                        BankFunc.WithDrawMoney(banks);
                        break;
                    case 5:
                        BankFunc.TransferMoney(banks);
                        break;
                    case 6:
                        BankFunc.ShowListOfAcc(banks);
                        break;
                    case 7:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Nhập sai lựa chọn !");
                        break;
                }
            }
        }
    }
}
