using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Kethua
{
    internal class Bankfunc
    {
        internal static void CheckBalanceById(Bank[] banks)
        {
            Console.Write("Nhập số tài khoản cần kiểm tra : ");
            long id = long.Parse(Console.ReadLine());
            var searched = CheckId(banks, id);
            if (searched != null)
            {
                searched.CheckBalance();
            }
            else
            {
                Console.WriteLine("Không tìm thấy tài khoản ngân hàng");
            }
        }

        private static Bank CheckId(Bank[] banks, long id)
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

        internal static Bank CreatAccount()
        {
            while (true)
            {
                Console.WriteLine("" +
                    "Bạn muốn tạo loại tài khoản nào ?\r\n" +
                    "1) Tài khoản tiết kiệm\r\n" +
                    "2) Tài khoản tiêu dùng\r\n" +
                    "Nhập lựa chọn của bạn : ");
                string key = Console.ReadLine();
                if (int.TryParse(key, out int value) == false || value < 0 || value > 2)
                {
                    Console.WriteLine("Sai lựa chọn");
                    continue;
                }
                Console.Write("Nhập tên : ");
                string name = Console.ReadLine();
                Console.Write("Nhập số dư : ");
                string bal = Console.ReadLine();
                Console.Write("Nhập tên ngân hàng : ");
                string bname = Console.ReadLine();
                Console.Write("Nhập tháng hết hạn : ");
                string month = Console.ReadLine();
                Console.Write("Nhập năm hết hạn : ");
                string year = Console.ReadLine();
                Console.Write("Nhập mã pin : ");
                string pin = Console.ReadLine();
                if (long.TryParse(bal, out long balance) == false || balance < 50000 || int.TryParse(month, out int validMonth) == false || int.TryParse(year, out int validYear) == false)
                {
                    Console.WriteLine("Nhập không đúng");
                    continue;
                }
                if (value == 1)
                {
                    Console.Write("Nhập kỳ hạn gửi : ");
                    int time = int.Parse(Console.ReadLine());
                    Console.Write("Nhập lãi suất : ");
                    double rate = double.Parse(Console.ReadLine());
                    Console.Write("Nhập tiền lãi");
                    long interest = long.Parse(Console.ReadLine());
                    return new Savingaccount(0, name, balance, bname, validMonth, validYear, pin, time, rate, interest);
                }
                if (value == 2)
                {
                    Console.Write("Nhập hạn mức trong ngày : ");
                    long limit = long.Parse(Console.ReadLine());
                    Console.Write("Nhập phí nội ngân hàng : ");
                    long innerCharge = long.Parse(Console.ReadLine());
                    Console.Write("Nhập phí ngoại ngân hàng : ");
                    long outterCharge = long.Parse(Console.ReadLine());
                    return new PaymentAccount(0, name, balance, bname, validMonth, validYear, pin, limit, innerCharge, outterCharge);
                }
            }
        }

        internal static void RechargeById(Bank[] banks)
        {
            Console.Write("Nhập số tài khoản cần kiểm tra : ");
            long id = long.Parse(Console.ReadLine());
            var searched = CheckId(banks, id);
            long amount = long.Parse(Console.ReadLine());
            if (searched != null)
            {
                if (searched.Recharge(amount) > 0)
                {
                    Console.WriteLine("Chuyển tiền thành công");
                }
                else
                {
                    Console.WriteLine("Chuyển tiền thất bại");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy tài khoản ngân hàng");
            }
        }
        internal static void WithdrawById(Bank[] banks)
        {
            Console.Write("Nhập số tài khoản cần kiểm tra : ");
            long id = long.Parse(Console.ReadLine());
            var searched = CheckId(banks, id);
            Console.Write("Nhập số tiền : ");
            long amount = long.Parse(Console.ReadLine());
            if (searched != null)
            {
                Console.Write("Nhập mã PIN : ");
                string pin = Console.ReadLine();
                if (searched.Pin.CompareTo(pin) == 0)
                {
                    if (searched.Withdraw(amount) > 0)
                    {
                        Console.Write("Chuyển tiền thành công");
                    }
                    else
                    {
                        Console.WriteLine("Chuyển tiền thất bại");
                    }
                }
                else
                {
                    Console.WriteLine("Sai mã PIN");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy tài khoản ngân hàng");
            }
        }

        internal static void Transfers(Bank[] banks)
        {
            Console.Write("Nhập số tài khoản  : ");
            long id = long.Parse(Console.ReadLine());
            var searched = CheckId(banks, id);
            if (searched != null)
            {
                Console.Write("Nhập mã PIN : ");
                string pin = Console.ReadLine();
                if (searched.Pin.CompareTo(pin) == 0)
                {
                    Console.Write("Nhập tài khoản đích : ");
                    id = long.Parse(Console.ReadLine());
                    var desbank = CheckId(banks, id);
                    if (desbank != null)
                    {
                        Console.Write("Nhập số tiền : ");
                        long amount = long.Parse(Console.ReadLine());
                        if (searched.Transfer(desbank, amount) > 0)
                        {
                            Console.WriteLine("Chuyển tiền thành công");
                        }
                        else
                        {
                            Console.WriteLine("Chuyển tiền thất bại");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Không tìm thấy tài khoản đích");
                    }
                }
                else
                {
                    Console.WriteLine("Sai mã PIN");
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy tài khoản ngân hàng");
            }
        }

        internal static void ShowListBank(Bank[] banks)
        {
            var titleId = "SỐ TÀI KHOẢN";
            var titleAccName = "TÊN TÀI KHOẢN";
            var titleBalance = "SỐ DƯ";
            var titleBankName = "TÊN NGÂN HÀNG";
            var titleValidMonth = "THÁNG";
            var titleValidYear = "NĂM";
            var titlePin = "MÃ PIN";
            var titleDPL = "HẠN MỨC NGÀY";
            var titleIBPC = "PHÍ NỘI NGÂN HÀNG";
            var titleOBPC = "PHÍ NGOẠI NGÂN HÀNG";
            var titleTimeDepo = "KỲ HẠN GỬI";
            var titleIR = "MỨC LÃI SUÂT";
            var titleInterest = "LÃI SUẤT";
            Console.WriteLine($"{titleId,-15} {titleAccName,-15} {titleBalance,-15} {titleBankName,-15} {titleValidMonth + "/" + titleValidYear,-15} {titlePin,-15} " +
                $"{titleDPL,-15} {titleIBPC,-15} {titleOBPC,-15} {titleTimeDepo,-15} {titleIR,-15} {titleInterest,-15}");
            foreach (var item in banks)
            {
                if (item is PaymentAccount)
                {
                    var paymentAccount = (PaymentAccount)item;
                    Console.WriteLine($"{paymentAccount.Id,-15} {paymentAccount.AccName,-15} {paymentAccount.Balance,-15} {paymentAccount.BankName,-15} {paymentAccount.ValidMonth + "/" + paymentAccount.ValidYear,-15} {paymentAccount.Pin,-15} " +
               $"{paymentAccount.DailyPaymentLimit,-15} {paymentAccount.InnerBankPaymentCharge,-15} {paymentAccount.OutterBankPaymentCharge,-15} --  --  --");
                }
                if(item is Savingaccount)
                {
                    var savingacc = (Savingaccount)item;
                    Console.WriteLine($"{savingacc.Id,-15} {savingacc.AccName,-15} {savingacc.Balance,-15} {savingacc.BankName,-15} {savingacc.ValidMonth + "/" + savingacc.ValidYear,-15} {savingacc.Pin,-15} " +
              $"-- -- -- {savingacc.TimeDeposit,-15} {savingacc.InterestRate,-15} {savingacc.Interest,-15}");
                }
            }            
        }

        internal static void SortByBalance(Bank[] banks)
        {
            for (int i = 0; i < banks.Length - 1; i++)
            {
                for (int j = i + 1; j < banks.Length; j++)
                {
                    if (CheckBank(banks[i], banks[j]) > 0)
                    {
                        Swap(ref banks[i], ref banks[j]);
                    }
                }
            }
        }

        private static void Swap(ref Bank bank1, ref Bank bank2)
        {
            Bank tmp = bank1;
            bank1 = bank2;
            bank2 = tmp;
        }

        private static int CheckBank(Bank bank1, Bank bank2)
        {
            if (bank1 == null || bank2 == null)
            {
                return 0;
            }
            if (bank1.Balance < bank2.Balance)
            {
                return 1;
            }
            return 0;
        }

        internal static void FindAccByLastIdDigits(Bank[] banks)
        {
            Console.Write("Nhập 4 số cuối của ID : ");
            string id = Console.ReadLine();
            var searched = CheckLastDigits(banks, id);
            Bank[] item = new Bank[1];
            if(searched != null)
            {
                item[0] = searched; 
                ShowListBank(item);
            }
            else
            {
                Console.WriteLine("Không tìm thây ID");
            }
        }

        private static Bank CheckLastDigits(Bank[] banks, string id)
        {                   
            foreach (var item in banks)
            {
                if (item != null)
                {
                    var length = item.Id.ToString();
                    string value = "";
                    for (int i = length.Length - 4; i < length.Length; i++)
                    {
                        value += length[i];
                    }
                    if (value.CompareTo(id.ToString()) == 0)
                    {
                        return item;
                    }
                }
            }
            return null;
        }
    }
}
