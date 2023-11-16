//using Microsoft.SqlServer.Server;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Linq;
//using System.Net.Http.Headers;
//using System.Runtime.CompilerServices;
//using System.Runtime.InteropServices;
//using System.Runtime.Remoting.Messaging;
//using System.Security.Cryptography.X509Certificates;
//using System.Text;
//using System.Threading.Tasks;

//namespace Chương_6
//{
//    #region Bài 1 :
//    //public class Employee
//    //{
//    //    private static int EmpID = 1000;
//    //    public string FullName { get; set; }
//    //    public int PhoneNumb { get; set; }
//    //    public string Job { get; set; }

//    //    public long BaseSalary = 7000000;
//    //    public long Pay
//    //    {
//    //        get => _payset; set
//    //        {
//    //            if (value > 10000000)
//    //            {
//    //                _payset = 10000000;
//    //            }
//    //            else
//    //            {
//    //                _payset = value;
//    //            }
//    //        }
//    //    }
//    //    private long _payset;
//    //    public string Id
//    //    {
//    //        get => _id; set
//    //        {
//    //            if (value == null)
//    //            {
//    //                _id = "EMP" + EmpID++;
//    //            }
//    //            else
//    //            {
//    //                _id = "EMP" + value;
//    //            }
//    //        }
//    //    }
//    //    public int WorkDay { get; set; }

//    //    private string _id;


//    //    public Employee(string id)
//    //    {
//    //        Id = id;
//    //    }
//    //    public Employee(string id, string fullName, int phoneNumb, string job, int workday) : this(id)
//    //    {
//    //        FullName = fullName;
//    //        PhoneNumb = phoneNumb;
//    //        Job = job;
//    //        Pay = 0;
//    //        WorkDay = workday;
//    //    }
//    //    public void CheckIn()
//    //    {
//    //        Console.WriteLine("Da check in");
//    //    }
//    //    public void CheckOut() { Console.WriteLine("Da check out"); }
//    //    public void Working()
//    //    {
//    //        Console.WriteLine("dang lam viec");
//    //    }
//    //    public void CalSalary()
//    //    {
//    //        double bonus = BaseSalary * 0.2;
//    //        if (WorkDay >= 22)
//    //        {
//    //            Pay = (long)(BaseSalary * WorkDay / 22 + bonus);
//    //        }
//    //        else
//    //        {
//    //            Pay = (long)(BaseSalary * WorkDay / 22);
//    //        }
//    //    }

//    //}
//    //class Programm
//    //{
//    //    static void Main()
//    //    {
//    //        Console.OutputEncoding = Encoding.UTF8;
//    //        Employee[] employees = new Employee[10];
//    //        string key;
//    //        int index = 0;
//    //        bool end = true;
//    //        while (end)
//    //        {
//    //            Console.WriteLine("1) Thêm mới một nhân viên vào danh sách nhân viên.\r\n" +
//    //                "2) Hiển thị danh sách nhân viên ra màn hình.\r\n" +
//    //                "3) Tính lương của các nhân viên trong danh sách.\r\n" +
//    //                "4) Sắp xếp danh sách nhân viên theo mức lương giảm dần.\r\n" +
//    //                "5) Sắp xếp danh sách nhân viên theo số ngày đi làm trong tháng g\r\n" +
//    //                "6) Tìm và hiển thị thông tin nhân viên theo mã nhân viên.\r\n" +
//    //                "7) Cập nhật mức lương cho nhân viên mã x vừa được tăng lương.\r\n" +
//    //                "8) Xóa bỏ nhân viên có mã cho trước.\r\n" +
//    //                "9) Thoát chương trình.");

//    //            Console.Write("Nhap lua chon : ");
//    //            key = Console.ReadLine();
//    //            if (int.TryParse(key, out int newKey) == false)
//    //            {
//    //                Console.Write("Nhap lai : ");
//    //                key = Console.ReadLine();
//    //            }
//    //            switch (newKey)
//    //            {
//    //                case 1:
//    //                    employees[index] = AddEmP();
//    //                    index++;
//    //                    Console.WriteLine("Them thanh cong .");
//    //                    break;
//    //                case 2:
//    //                    ShowEmp(employees);
//    //                    break;
//    //                case 3:
//    //                    TinhLuong(employees);
//    //                    break;
//    //                case 4:
//    //                    SortEmp(employees);
//    //                    break;
//    //                case 5:
//    //                    SortEmpByDay(employees);
//    //                    break;
//    //                case 6:
//    //                    FindEmpById(employees);
//    //                    break;
//    //                case 7:
//    //                    SuaLuongNhanVien(employees);
//    //                    break;
//    //                case 8:
//    //                    XoaNhanVien(employees, ref index);
//    //                    break;
//    //                case 9:
//    //                    end = false;
//    //                    break;
//    //                default:
//    //                    Console.WriteLine("NHẬP SAI LỰA CHỌN");
//    //                    break;

//    //            }
//    //        }
//    //    }

//    //    private static void XoaNhanVien(Employee[] employees, ref int index)
//    //    {
//    //        Console.Write("NHẬP MÃ NHÂN VIÊN : ");
//    //        string id = Console.ReadLine();

//    //        for (int i = 0; i < employees.Length - 1; i++)
//    //        {
//    //            for (int j = i; j < employees.Length; j++)
//    //            {
//    //                if (CheckId(employees[i],employees[j], id) > 0)
//    //                {
//    //                    employees[j] = employees[j + 1];
//    //                }
//    //            }
//    //        }
//    //        index--;
//    //    }

//    //    private static void FindEmpById(Employee[] employees)
//    //    {
//    //        Employee[] employees1 = new Employee[employees.Length];
//    //        Console.Write("NHẬP MÃ NHÂN VIÊN : ");
//    //        string id = Console.ReadLine();
//    //        foreach (var item in employees)
//    //        {
//    //            if (CheckId(item, id) > 0)
//    //            {
//    //                employees1[0] = item;
//    //            }
//    //        }
//    //        ShowEmp(employees1);
//    //    }

//    //    private static int CheckId(Employee employee, string id)
//    //    {
//    //        if (employee == null)
//    //        {
//    //            return 0;
//    //        }
//    //        if (employee.Id == id)
//    //        {
//    //            return 1;
//    //        }
//    //        return 0;
//    //    }
//    //    private static int CheckId(Employee employee,Employee employee1, string id)
//    //    {
//    //        if (employee == null || employee1 == null)  
//    //        {
//    //            return 0;
//    //        }
//    //        if (employee.Id == id)
//    //        {
//    //            return 1;
//    //        }
//    //        return 0;
//    //    }
//    //    private static void SortEmpByDay(Employee[] employees)
//    //    {
//    //        for (int i = 0; i < employees.Length; i++)
//    //        {
//    //            for (int j = i + 1; j < employees.Length; j++)
//    //            {
//    //                if (CheckWorday(employees[i], employees[j]) > 0)
//    //                {
//    //                    Employee tmp = employees[i];
//    //                    employees[i] = employees[j];
//    //                    employees[j] = tmp;
//    //                }
//    //            }
//    //        }
//    //    }

//    //    private static int CheckWorday(Employee employee1, Employee employee2)
//    //    {
//    //        if (employee1 == null || employee2 == null)
//    //        {
//    //            return 0;
//    //        }
//    //        if (employee1.WorkDay - employee2.WorkDay != 0)
//    //        {
//    //            if (employee2.WorkDay > employee1.WorkDay)
//    //            {
//    //                return 1;
//    //            }
//    //            else
//    //            {
//    //                return -1;
//    //            }
//    //        }
//    //        return 0;
//    //    }

//    //    private static void SortEmp(Employee[] employees)
//    //    {
//    //        for (int i = 0; i < employees.Length; i++)
//    //        {
//    //            for (int j = i + 1; j < employees.Length; j++)
//    //            {
//    //                if (CheckPay(employees[i], employees[j]) > 0)
//    //                {
//    //                    Employee tmp = employees[i];

//    //                    employees[i] = employees[j];
//    //                    employees[j] = tmp;
//    //                }
//    //            }
//    //        }
//    //    }

//    //    private static int CheckPay(Employee employee1, Employee employee2)
//    //    {
//    //        if (employee1 == null || employee2 == null)
//    //        {
//    //            return 0;
//    //        }
//    //        if (employee1.Pay - employee2.Pay != 0)
//    //        {
//    //            if (employee2.Pay > employee1.Pay)
//    //            {
//    //                return 1;
//    //            }
//    //            else
//    //            {
//    //                return -1;
//    //            }
//    //        }
//    //        return 0;

//    //    }

//    //    public static void ShowEmp(Employee[] employees)
//    //    {
//    //        var titleId = "MA NHAN VIEN";
//    //        var titleFullName = "HO VA TEN";
//    //        var titlePhoneNumb = "SO DIEN THOAI";
//    //        var titleJob = "VI TRI";
//    //        var titleWorkday = "NGAY LAM VIEC";
//    //        var titlePay = "LUONG NHAN VIEN";
//    //        Console.WriteLine($"{titleId,-20} {titleFullName,-20} {titlePhoneNumb,-20} {titleJob,-20} {titleWorkday,-20} {titlePay,-20}");
//    //        foreach (var item in employees)
//    //        {
//    //            if (item != null)
//    //            {
//    //                Console.WriteLine($"{item.Id,-20} {item.FullName,-20} {item.PhoneNumb,-20} {item.Job,-20} {item.WorkDay,-20} {item.Pay,-20}");
//    //            }
//    //        }
//    //    }

//    //    private static void SuaLuongNhanVien(Employee[] employees)
//    //    {
//    //        Console.Write("NHẬP MÃ NHÂN VIÊN : ");
//    //        string id = Console.ReadLine();
//    //        foreach (var item in employees)
//    //        {
//    //            if (CheckId(item, id) > 0)
//    //            {
//    //                Console.Write("NHẬP LƯƠNG MỚI CỦA NHÂN VIÊN : ");
//    //                long newSal = long.Parse(Console.ReadLine());
//    //                item.BaseSalary += newSal;
//    //            }
//    //        }
//    //    }

//    //    private static void TinhLuong(Employee[] employees)
//    //    {
//    //        foreach (var emp in employees)
//    //        {
//    //            if (emp != null)
//    //            {
//    //                emp.CalSalary();
//    //            }
//    //        }
//    //    }

//    //    private static Employee AddEmP()
//    //    {

//    //        while (true)
//    //        {
//    //            Console.Write("Nhap ten : ");
//    //            string fullName = Console.ReadLine();
//    //            Console.Write("Nhap so dien thoai : ");
//    //            string phoneNumb = Console.ReadLine();
//    //            Console.Write("Nhap job : ");
//    //            string job = Console.ReadLine();
//    //            Console.Write("Nhap so ngay lv : ");
//    //            string workday = Console.ReadLine();
//    //            int newWorkday;
//    //            int newPhoneNumb;
//    //            if (int.TryParse(phoneNumb, out newPhoneNumb) == false || int.TryParse(workday, out newWorkday) == false)
//    //            {
//    //                Console.WriteLine("Nhap sai ");
//    //                continue;
//    //            }
//    //            Employee employee = new Employee(null, fullName, newPhoneNumb, job, newWorkday);

//    //            return employee;


//    //        }



//    //    }
//    //}
//    #endregion
//    #region Bài 2 :
//    //class Bank
//    //{
//    //    private static long idIndex = (long)Math.Pow(10, 13);
//    //    public long Id
//    //    {
//    //        get => _id;
//    //        set
//    //        {
//    //            if (value == 0)
//    //            {
//    //                _id = idIndex++;
//    //            }
//    //            else
//    //            {
//    //                _id = value;
//    //            }
//    //        }
//    //    }
//    //    private long _id;
//    //    public string Name { get; set; }       
//    //    public long Balance { get; set; }
//    //    public string BankName { get; set; }
//    //    public int ValidMonth { get; set; }
//    //    public int ValidYear { get; set; }
//    //    private string _pin;
//    //    public string Pin
//    //    {
//    //        get => _pin;
//    //        set
//    //        {
//    //            if (value.ToString().Length != 6)
//    //            {
//    //                _pin = "000000";
//    //            }
//    //            else
//    //            {
//    //                _pin = value;
//    //            }
//    //        }
//    //    }


//    //    public Bank(long id)
//    //    {
//    //        Id = id;
//    //    }
//    //    public Bank(long id, string name, long balance, string bankName, int validMonth, int validYear, string pin) : this(id)
//    //    {
//    //        Name = name;
//    //        Balance = balance;
//    //        ValidMonth = validMonth;
//    //        ValidYear = validYear;
//    //        Pin = pin;
//    //        BankName = bankName;
//    //    }
//    //    public void NapTiep()
//    //    {
//    //        Console.Write("Nhập số tiền bạn muốn nạp : ");
//    //        long recharge = long.Parse(Console.ReadLine());

//    //        Balance += recharge;
//    //        Console.WriteLine("Nạp tiền thành công.");
//    //    }
//    //    public void RutTien()
//    //    {
//    //        Console.Write("Nhập số tiền bạn muốn rút : ");
//    //        long withdraw = long.Parse(Console.ReadLine());
//    //        if (Balance < withdraw || Balance - withdraw < 50000)
//    //        {
//    //            Console.WriteLine("Không đủ số dư");
//    //        }
//    //        else
//    //        {
//    //            Balance -= withdraw;
//    //            Console.WriteLine("Rút tiền thành công.");
//    //        }
//    //    }
//    //    public void ChuyenTien(Bank transferBank)
//    //    {
//    //        Console.Write("Nhập số tiền bạn muốn chuyển : ");
//    //        long transfer = long.Parse(Console.ReadLine());
//    //        if (Balance < transfer || Balance - transfer < 50000)
//    //        {
//    //            Console.WriteLine("Không đủ số dư");
//    //        }
//    //        else
//    //        {
//    //            Balance -= transfer;
//    //            transferBank.Balance += transfer;
//    //            Console.WriteLine("Chuyển tiền thành công.");
//    //        }
//    //    }
//    //    public void CheckSoDu()
//    //    {
//    //        while (Balance < 50000)
//    //        {
//    //            Console.Write("Hãy thêm số dư lớn hơn 50k : ");
//    //            long balance = long.Parse(Console.ReadLine());
//    //            Balance = balance;
//    //        }
//    //        Console.WriteLine($"Số dư hiện tại của bạn là : {Balance}. ");
//    //    }
//    //}
//    //class Programm
//    //{
//    //    static void Main()
//    //    {
//    //        Console.OutputEncoding = Encoding.UTF8;
//    //        Bank[] bank = new Bank[10];
//    //        int index = 0;
//    //        int key;
//    //        bool end = true;
//    //        while (end)
//    //        {
//    //            Console.WriteLine("1) Tạo mới một tài khoản ngân hàng với đầy đủ thông tin. Lưu vào danh sách tài khoản.\r\n" +
//    //                "2) Kiểm tra số dư của tài khoản bằng cách nhập vào số tài khoản cần kiểm tra.\r\n" +
//    //                "3) Nạp tiền vào tài khoản x bằng cách nhập số tài khoản và số tiền cần nạp.\r\n" +
//    //                "4) Rút tiền từ tài khoản x bằng cách nhập số tài khoản, mã PIN và số tiền cần rút. Việc rút\r\ntiền chỉ thành công khi nhập đúng mã PIN, đúng số tài khoản và số tiền cần rút < số dư\r\nhiện có + 50k VNđ.\r\n" +
//    //                "5) Chuyển tiền từ tài khoản x sang tài khoản y. Để chuyển tiền người dùng cung cấp số tài\r\nkhoản nguồn, số tài khoản đích, số tiền cần chuyển và mã PIN. Việc chuyển tiền chỉ thành\r\ncông khi người dùng nhập đúng tài khoản nguồn, tài khoản đích, đúng mã PIN và số tiền\r\ncần chuyển phải < số dư + 50k VNđ.\r\n" +
//    //                "6) Hiển thị danh sách tài khoản ra màn hình dạng bảng gồm các hàng, cột.\r\n" +
//    //                "7) Kết thúc chương trình.");

//    //            Console.Write("Nhập lựa chọn của bạn : ");
//    //            key = int.Parse(Console.ReadLine());
//    //            switch (key)
//    //            {
//    //                case 1:
//    //                    bank[index++] = AddNewAcc();
//    //                    Console.WriteLine("THÊM TÀI KHOẢN THÀNH CÔNG");
//    //                    break;
//    //                case 2:
//    //                    if (index > 0)
//    //                    {

//    //                        CheckBalance(bank);
//    //                    }
//    //                    else
//    //                    {
//    //                        Console.WriteLine("DANH SÁCH NGÂN HÀNG TRỐNG.");
//    //                    }
//    //                    break;
//    //                case 3:
//    //                    if (index > 0)
//    //                    {

//    //                        Recharge(bank);
//    //                    }
//    //                    else
//    //                    {
//    //                        Console.WriteLine("DANH SÁCH NGÂN HÀNG TRỐNG.");

//    //                    }
//    //                    break;
//    //                case 4:
//    //                    if (index > 0)
//    //                    {

//    //                        Withdraw(bank);
//    //                    }
//    //                    else
//    //                    {
//    //                        Console.WriteLine("DANH SÁCH NGÂN HÀNG TRỐNG.");

//    //                    }
//    //                    break;
//    //                case 5:
//    //                    if (index > 0)
//    //                    {

//    //                        Transfer(bank);
//    //                    }
//    //                    else
//    //                    {
//    //                        Console.WriteLine("DANH SÁCH NGÂN HÀNG TRỐNG.");

//    //                    }
//    //                    break;
//    //                case 6:
//    //                    if (index > 0)
//    //                    {

//    //                        ShowAccList(bank);
//    //                    }
//    //                    else
//    //                    {
//    //                        Console.WriteLine("DANH SÁCH NGÂN HÀNG TRỐNG.");

//    //                    }
//    //                    break;
//    //                case 7:
//    //                    end = false;
//    //                    break;
//    //                default:
//    //                    Console.WriteLine("NHẬP SAI LỰA CHỌN");
//    //                    break;

//    //            }
//    //        }
//    //    }

//    //    private static void ShowAccList(Bank[] bank)
//    //    {
//    //        var titleId = "ID";
//    //        var titleFullname = "HỌ VÀ TÊN";
//    //        var titleBalance = "SỐ DƯ";
//    //        var titleValidmonth = "THÁNG";
//    //        var titleValidyear = "NĂM";
//    //        var titlePin = "PIN";
//    //        var titleBankName = "TÊN NGÂN HÀNG";
//    //        Console.WriteLine($"{titleId,-20} {titleFullname,-20} {titleBalance,-20} {titleBankName,-20} {titleValidmonth + "/" + titleValidyear,-20} {titlePin,-20}");
//    //        foreach (var item in bank)
//    //        {
//    //            if (item != null)
//    //            {
//    //                Console.WriteLine($"{item.Id,-20} {item.Name,-20} {item.Balance,-20} {item.BankName,-20} {item.ValidMonth + "/" + item.ValidYear,-20} {item.Pin,-20}");
//    //            }
//    //        }
//    //    }

//    //    private static void Transfer(Bank[] bank)
//    //    {
//    //        var searchedBank = CheckID(bank);
//    //        var searchedBank1 = CheckID(bank);
//    //        if (CheckNull(searchedBank))
//    //        {
//    //            if (CheckNull(searchedBank1))
//    //            {
//    //                if (CheckPin(searchedBank))
//    //                {
//    //                    searchedBank.ChuyenTien(searchedBank1);
//    //                }
//    //                else
//    //                {
//    //                    Console.WriteLine("Sai ma pin.");
//    //                }
//    //            }
//    //            else
//    //            {
//    //                Console.WriteLine("Khong tim thay ID người nhận.");
//    //            }               
//    //        }
//    //        else
//    //        {
//    //            Console.WriteLine("Khong tim thay ID.");
//    //        }
//    //    }      
//    //    static bool CheckNull(Bank acc)
//    //    {
//    //        if (acc == null)
//    //        {
//    //            return false;
//    //        }
//    //        return true;
//    //    }
//    //    private static void Withdraw(Bank[] bank)
//    //    {
//    //        var searchedBank = CheckID(bank);

//    //        if (CheckNull(searchedBank))
//    //        {
//    //            if (CheckPin(searchedBank))
//    //            {
//    //                searchedBank.RutTien();
//    //            }
//    //            else
//    //            {
//    //                Console.WriteLine("Sai ma pin.");
//    //            }
//    //        }
//    //        else
//    //        {
//    //            Console.WriteLine("Khong tim thay ID.");
//    //        }
//    //    }

//    //    private static bool CheckPin(Bank searchedBank)
//    //    {
//    //        Console.Write("Nhập mã pin của bạn : ");
//    //        string pinCheck = Console.ReadLine();

//    //        if (searchedBank.Pin != pinCheck)
//    //        {
//    //            return false;
//    //        }
//    //        return true;

//    //    }

//    //    public static Bank CheckID(Bank[] bank)
//    //    {
//    //        Console.Write("Nhập ID của bạn : ");
//    //        long id = long.Parse(Console.ReadLine());

//    //        foreach (var item in bank)
//    //        {
//    //            if (item != null && item.Id == id)
//    //            {
//    //                return item;
//    //            }
//    //        }
//    //        return null;

//    //    }
//    //    private static void Recharge(Bank[] bank)
//    //    {
//    //        var searchedBank = CheckID(bank);

//    //        if (searchedBank != null)
//    //        {
//    //            searchedBank.NapTiep();
//    //        }
//    //        else
//    //        {
//    //            Console.WriteLine("Không tìm thấy ID.");
//    //        }

//    //    }

//    //    private static void CheckBalance(Bank[] bank)
//    //    {

//    //        var searchedBank = CheckID(bank);

//    //        if (searchedBank != null)
//    //        {
//    //            searchedBank.CheckSoDu();
//    //        }
//    //        else
//    //        {
//    //            Console.WriteLine("Không tìm thấy ID.");
//    //        }
//    //    }

//    //    private static Bank AddNewAcc()
//    //    {
//    //        while (true)
//    //        {
//    //            Console.Write("Nhap ten : ");
//    //            string fullName = Console.ReadLine();

//    //            Console.Write("Nhap so du : ");
//    //            string balance = Console.ReadLine();

//    //            Console.Write("Nhap ten ngan hang : ");
//    //            string bankName = Console.ReadLine();

//    //            Console.Write("Nhap thang het han : ");
//    //            string validDate = Console.ReadLine();

//    //            Console.Write("Nhap nam het han : ");

//    //            string validYear = Console.ReadLine();

//    //            Console.Write("Nhap ma pin : ");
//    //            string pin = Console.ReadLine();


//    //            if (long.TryParse(balance, out long newbanlance) == false || int.TryParse(validDate, out int newValidDate) == false
//    //                || int.TryParse(validYear, out int newValidyear) == false || int.TryParse(pin, out int newValidpin) == false)
//    //            {
//    //                Console.WriteLine("Nhập không đúng thông tin.");
//    //                continue;
//    //            }
//    //            Bank bank = new Bank(0, fullName, newbanlance, bankName, newValidDate, newValidyear, pin);
//    //            return bank;
//    //        }

//    //    }
//    //}
//    #endregion
//    #region Bài 3 :
//    class Student
//    {
//        private static int Idindex = 1000;

//        public string FirstName { get; set; }
//        public string MiddleName { get; set; }
//        public string LastName { get; set; }
//        public string Address { get; set; }
//        public string Major { get; set; }

//        private double _gpa;
//        public double Gpa
//        {
//            get => _gpa;
//            set
//            {
//                if (value < 0)
//                {
//                    _gpa = 0;
//                }
//                else
//                {
//                    _gpa = value;
//                }
//            }
//        }
//        private string _id;
//        public string Id
//        {
//            get => _id;
//            set
//            {
//                if (string.IsNullOrEmpty(_id))
//                {
//                    _id = "ST" + Idindex++;
//                }
//                else
//                {
//                    _id = "ST" + value;
//                }
//            }
//        }

//        public Student(string id)
//        {
//            Id = id;
//        }
//        public Student(string id, string firstName, string midName, string lastName, string addr, double gpa, string major) : this(id)
//        {
//            FirstName = firstName;
//            MiddleName = midName;
//            LastName = lastName;
//            Address = addr;
//            Gpa = gpa;
//            Major = major;
//        }
//    }
//    class Programm
//    {
//        static void Main()
//        {
//            Console.OutputEncoding = Encoding.UTF8;
//            Student[] students = new Student[10];
//            int index = 0;
//            string key;
//            bool end = true;

//            while (end)
//            {
//                Console.WriteLine("1) Thêm mới một sinh viên vào danh sách.\r\n" +
//                    "2) Hiển thị danh sách sinh viên ra màn hình ở dạng bảng gồm các hàng, cột ngay ngắn. Thông\r\ntin mỗi sinh viên hiển thị trên 1 dòng.\r\n" +
//                    "3) Sắp xếp danh sách sinh viên theo điểm TB giảm dần.\r\n" +
//                    "4) Sắp xếp danh sách sinh viên theo tên tăng dần.\r\n" +
//                    "5) Sắp xếp danh sách sinh viên theo điểm TB giảm dần, tên tăng dần, họ tăng dần.\r\n" +
//                    "6) Tìm sinh viên theo tên. Hiển thị kết quả tìm được.\r\n" +
//                    "7) Tìm sinh viên theo tỉnh. Hiển thị kết quả tìm được.\r\n" +
//                    "8) Xóa sinh viên theo mã cho trước khỏi danh sách.\r\n" +
//                    "9) Liệt kê số lượng sinh viên theo từng tỉnh. Sắp xếp giảm dần theo số lượng.\r\n" +
//                    "10) Sửa điểm TB cho sinh viên theo mã sinh viên.\r\n" +
//                    "11) Kết thúc chương trình");

//                Console.Write("NHẬP LỰA CHỌN : ");
//                key = Console.ReadLine();
//                if (int.TryParse(key, out int newKey) == false)
//                {
//                    Console.WriteLine("LỰA CHỌN KHÔNG PHÙ HỢP !");
//                    continue;
//                }
//                switch (newKey)
//                {
//                    case 1:
//                        students[index++] = AddStudent();
//                        Console.WriteLine("THÊM SINH VIÊN THÀNH CÔNG !");
//                        break;
//                    case 2:
//                        if (index > 0)
//                        {
//                            ShowListStudents(students);
//                        }
//                        else
//                        {
//                            Console.WriteLine("DANH SÁCH SINH VIÊN TRỐNG !");
//                        }
//                        break;
//                    case 3:
//                        if (index > 0)
//                        {
//                            SortStudentByGpa(students);
//                        }
//                        else
//                        {
//                            Console.WriteLine("DANH SÁCH SINH VIÊN TRỐNG !");
//                        }
//                        break;
//                    case 4:
//                        if (index > 0)
//                        {
//                            SortStudentByLastName(students);
//                        }
//                        else
//                        {
//                            Console.WriteLine("DANH SÁCH SINH VIÊN TRỐNG !");
//                        }
//                        break;
//                    case 5:
//                        if (index > 0)
//                        {
//                            SortStudentByAll(students);
//                        }
//                        else
//                        {
//                            Console.WriteLine("DANH SÁCH SINH VIÊN TRỐNG !");
//                        }
//                        break;
//                    case 6:
//                        if (index > 0)
//                        {
//                            FindStudentByName(students);
//                        }
//                        else
//                        {
//                            Console.WriteLine("DANH SÁCH SINH VIÊN TRỐNG !");
//                        }
//                        break;
//                    case 7:
//                        if (index > 0)
//                        {
//                            FindStudentByAddr(students);
//                        }
//                        else
//                        {
//                            Console.WriteLine("DANH SÁCH SINH VIÊN TRỐNG !");
//                        }
//                        break;
//                    case 8:
//                        if (index > 0)
//                        {
//                            DeleteStudentById(students, ref index);
//                        }
//                        else
//                        {
//                            Console.WriteLine("DANH SÁCH SINH VIÊN TRỐNG !");
//                        }
//                        break;
//                    case 9:
//                        if (index > 0)
//                        {
//                            ListStudentsByAddr(students);
//                        }
//                        else
//                        {
//                            Console.WriteLine("DANH SÁCH SINH VIÊN TRỐNG !");
//                        }
//                        break;
//                    case 10:
//                        if (index > 0)
//                        {
//                            ChangeStudentGpa(students);
//                        }
//                        else
//                        {
//                            Console.WriteLine("DANH SÁCH SINH VIÊN TRỐNG !");
//                        }
//                        break;
//                    case 11:
//                        end = false;
//                        break;
//                    default:
//                        Console.WriteLine("NHẬP SAI LỰA CHỌN !");
//                        break;
//                }

//            }
//        }

//        private static void ChangeStudentGpa(Student[] students)
//        {
//            var searchedStu = CheckId(students);

//            if (searchedStu != null)
//            {
//                Console.Write("NHẬP ĐIỂM MỚI CHO SINH VIÊN : ");
//                double newGpa = double.Parse(Console.ReadLine());

//                if (newGpa < 0 || newGpa == searchedStu.Gpa)
//                {
//                    Console.WriteLine("NHẬP ĐIỂM KHÔNG HỢP LỆ !");
//                }
//                else
//                {
//                    searchedStu.Gpa = newGpa;
//                    Console.WriteLine($"SỬA ĐIỂM THÀNH CÔNG ĐIỂM MỚI CỦA SINH VIÊN {searchedStu.Id} là : {searchedStu.Gpa}");
//                }
//            }
//            else
//            {
//                Console.WriteLine("KHÔNG TÌM THẤY MÃ SINH VIÊN.");
//            }
//        }

//        private static void ListStudentsByAddr(Student[] students)
//        {
//            ListAddr[] addrs = new ListAddr[students.Length];
//            int index = 0;
//            int Check(ListAddr[] addr, string address)
//            {
//                for (int i = 0; i < addr.Length; i++)
//                {
//                    if (addr[i] != null && addr[i].Addr.CompareTo(address) == 0)
//                    {
//                        return i;
//                    }
//                }
//                return -1;
//            }
//            for (int i = 0; i < students.Length; i++)
//            {
//                if (students[i] != null)
//                {
//                    var result = Check(addrs, students[i].Address);
//                    if (result != -1)
//                    {
//                        addrs[result].Count++;
//                        continue;
//                    }
//                    else
//                    {
//                        addrs[index] = new ListAddr();
//                        addrs[index].Addr = students[i].Address;
//                        addrs[index].Count = 1;
//                        index++;
//                    }
//                }
                
//            }
//            foreach (var item in addrs)
//            {
//                if (item != null)
//                {
//                    Console.WriteLine($"{item.Addr} : {item.Count}");
//                }
//            }
//        }
           
//        class ListAddr
//        {
//            public string Addr { get; set; }
//            public int Count { get; set; }
//            public ListAddr()
//            {
                
//            }
//            public ListAddr(string addr, int count)
//            {
//                Addr = addr;
//                Count = count;
//            }
//        }

//        private static void DeleteStudentById(Student[] students, ref int index)
//        {
//            var searchedStu = CheckId(students);

//            if (searchedStu != null)
//            {
//                for (int i = 0; i < students.Length; i++)
//                {
//                    if (students[i] != null && students[i] == searchedStu)
//                    {
//                        for (int j = i; j < students.Length - 1; j++)
//                        {
//                            students[j] = students[j + 1];
//                        }
//                    }
//                }
//                index--;
//                Console.WriteLine("XÓA SINH VIÊN THÀNH CÔNG !");
//            }
//            else
//            {
//                Console.WriteLine("KHÔNG TÌM THẤY MÃ SINH VIÊN !");
//            }
//        }

//        private static Student CheckId(Student[] students)
//        {
//            Console.Write("NHẬP MÃ ID CỦA SINH VIÊN : ");
//            string id = Console.ReadLine();
//            foreach (var item in students)
//            {
//                if (item != null && item.Id == id)
//                {
//                    return item;
//                }
//            }
//            return null;
//        }

//        private static void FindStudentByAddr(Student[] students)
//        {
//            Console.Write("NHẬP TỈNH THÀNH CẦN TÌM KIẾM : ");
//            string addr = Console.ReadLine();
//            Student[] searchedAddr = new Student[students.Length];
//            int index = 0;
//            foreach (var item in students)
//            {
//                if (item != null && item.Address == addr)
//                {
//                    searchedAddr[index++] = item;
//                }
//            }
//            if (index > 0)
//            {
//                ShowListStudents(searchedAddr);
//            }
//            else
//            {
//                Console.WriteLine("KHÔNG TÌM THẤY TỈNH THÀNH ! ");
//            }
//        }

//        static void FindStudentByName(Student[] students)
//        {
//            Console.Write("NHẬP TÊN SINH VIÊN CẦN TÌM KIẾM : ");
//            string lastName = Console.ReadLine();
//            Student[] searchedStudents = new Student[students.Length];
//            int index = 0;
//            foreach (var item in students)
//            {
//                if (item != null && item.LastName == lastName)
//                {
//                    searchedStudents[index++] = item;
//                }
//            }
//            if (index > 0)
//            {
//                ShowListStudents(searchedStudents);
//            }
//            else
//            {
//                Console.WriteLine("KHÔNG TÌM THẤY TÊN SINH VIÊN ! ");
//            }

//        }

//        private static void SortStudentByAll(Student[] students)
//        {
//            SortStudentByGpa(students);

//            for (int i = 0; i < students.Length - 1; i++)
//            {
//                for (int j = i + 1; j < students.Length; j++)
//                {
//                    if (SortIfEqual(students[i], students[j]) > 0)
//                    {
//                        Swap(ref students[i], ref students[j]);
//                    }
//                }
//            }
//        }

//        private static int SortIfEqual(Student student1, Student student2)
//        {
//            if (student1 == null || student2 == null)
//            {
//                return 0;
//            }
//            if (student1.Gpa == student2.Gpa && LastNameAscendSort(student1, student2) > 0 || student1.Gpa == student2.Gpa && student1.FirstName.CompareTo(student2.FirstName) > 0)
//            {
//                return 1;
//            }
//            return 0;
//        }

//        private static void SortStudentByLastName(Student[] students)
//        {
//            for (int i = 0; i < students.Length - 1; i++)
//            {
//                for (int j = i + 1; j < students.Length; j++)
//                {
//                    if (LastNameAscendSort(students[i], students[j]) > 0)
//                    {
//                        Swap(ref students[i], ref students[j]);
//                    }
//                }
//            }
//            Console.WriteLine("SẮP XẾP THÀNH CÔNG");
//        }
//        static int LastNameAscendSort(Student student1, Student student2)
//        {
//            if (student1 == null || student2 == null)
//            {
//                return 0;
//            }
//            if (student1.LastName.CompareTo(student2.LastName) > 0)
//            {
//                return 1;
//            }
//            return 0;
//        }

//        static int GpaDescendSort(Student student1, Student student2)
//        {
//            if (student1 == null || student2 == null)
//            {
//                return 0;
//            }
//            if (student1.Gpa < student2.Gpa)
//            {
//                return 1;
//            }
//            return 0;
//        }
//        private static void SortStudentByGpa(Student[] students)
//        {
//            for (int i = 0; i < students.Length - 1; i++)
//            {
//                for (int j = i + 1; j < students.Length; j++)
//                {
//                    if (GpaDescendSort(students[i], students[j]) > 0)
//                    {
//                        Swap(ref students[i], ref students[j]);
//                    }
//                }
//            }
//            Console.WriteLine("SẮP XẾP THÀNH CÔNG");
//        }
      
//        private static void Swap(ref Student student1, ref Student student2)
//        {
//            Student tmp = student1;
//            student1 = student2;
//            student2 = tmp;
//        }

//        private static void ShowListStudents(Student[] students)
//        {
//            var titleId = "MÃ SINH VIÊN";
//            var titleFullName = "HỌ VÀ TÊN";
//            var titleAddr = "ĐỊA CHỈ";
//            var titleGpa = "ĐIỂM TRUNG BÌNH";
//            var titleMajor = "CHUYÊN NGÀNH";
//            Console.WriteLine($"{titleId,-20} {titleFullName,-20} {titleAddr,-20} {titleGpa,-20} {titleMajor,-20}");
//            foreach (var item in students)
//            {
//                if (item != null)
//                {
//                    Console.WriteLine($"{item.Id,-20} {item.FirstName + " " + item.MiddleName + " " + item.LastName,-20} {item.Address,-20} {item.Gpa,-20} {item.Major,-20}");
//                }
//            }
//        }

//        private static Student AddStudent()
//        {
//            while (true)
//            {
//                Console.Write("NHẬP HỌ : ");
//                string firstName = Console.ReadLine();

//                Console.Write("NHẬP TÊN ĐỆM : ");
//                string midName = Console.ReadLine();

//                Console.Write("NHẬP TÊN : ");
//                string lastName = Console.ReadLine();

//                Console.Write("NHẬP ĐỊA CHỈ : ");
//                string addr = Console.ReadLine();

//                Console.Write("NHẬP ĐIỂM TRUNG BÌNH : ");
//                string gpa = Console.ReadLine();

//                Console.Write("NHẬP CHUYÊN NGÀNH : ");
//                string major = Console.ReadLine();

//                if (double.TryParse(gpa, out double newGpa) == false)
//                {
//                    Console.WriteLine("NHẬP SAI ĐỊNH DẠNG !");
//                    continue;
//                }

//                Student student = new Student(null, firstName, midName, lastName, addr, newGpa, major);
//                return student;
//            }
//        }
//    }
//    #endregion
//}
