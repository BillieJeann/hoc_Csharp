using System;
using System.Runtime.CompilerServices;
using System.Text;

namespace Nestedclass.Employee
{
    class Employee
    {
        public class FullName
        {
            public string FirstName { get; set; }
            public string MiddleName { get; set; }
            public string LastName { get; set; }
        }
        private static int idindex = 1000;
        private string _id;
        public string Id
        {
            get => _id;
            set
            {
                if (value == null)
                {
                    _id = "EMP" + idindex++;
                }
                else
                {
                    _id = value;
                }
            }
        }
        private int[] _phoneNumb = new int[6];
        public int Index;
        public int PhoneNumber
        {
            set
            {
                _phoneNumb[Index++] = value;
            }
        }
        public int GetPhone(int number)
        {
            for (int i = 0; i < _phoneNumb.Length; i++)
            {
                if (_phoneNumb[i] != null && i == number)
                {
                    return _phoneNumb[i];
                }
            }
            return 0;
        }
        public int WorkDay { get; set; }
        public string Position { get; set; }
        public long GroundPay { get; set; }
        private long _salary;
        public long Salary
        {
            get => _salary;
            set
            {
                int max = 10000000;
                if (value > max)
                {
                    _salary = max;
                }
                else
                {
                    _salary = value;
                }
            }
        }
        public string Full
        {
            get => $"{fullname.FirstName} {fullname.MiddleName} {fullname.LastName}";
            set
            {
                fullname = new FullName();
                var name = value.Split(' ');
                fullname.FirstName = name[0];
                fullname.LastName = name[name.Length - 1];
                var mid = "";
                for (int i = 1; i < name.Length - 1; i++)
                {
                    mid += " " + name[i];
                }
                fullname.MiddleName = mid;
            }
        }
        public FullName fullname;

        public Employee(string id)
        {
            Id = id;
        }
        public Employee(string id, string fullname, int phoneNumb, string pos, int workDay, long salary, long groundPay) : this(id)
        {
            Index = 0;
            Full = fullname;
            PhoneNumber = phoneNumb;
            Position = pos;
            Salary = salary;
            WorkDay = workDay;
            GroundPay = groundPay;
        }
        public void CheckIn()
        {
            Console.WriteLine($"Nhân viên {Id} đã check in lúc 7h30");
        }
        public void CheckOut()
        {
            Console.WriteLine($"Nhân viên {Id} đã check out lúc 17h30");
        }
        public void Working()
        {
            Console.WriteLine($"Nhân viên {Id} dang làm việc");
        }
        public void SalCount()
        {
            long bonus = GroundPay * 20 / 100;
            if (WorkDay >= 22)
            {
                Salary = GroundPay * WorkDay / 22 + bonus;
            }
            else
            {
                Salary = GroundPay * WorkDay / 22;
            }
        }
    }
    class Programm
    {
        /*static void Main()
        {
            Employee[] employees = new Employee[10];
            int index = 0;
            string key;
            bool end = true;
            Console.OutputEncoding = Encoding.UTF8;
            while (end)
            {
                Console.WriteLine("" +
                    "1) Thêm mới một nhân viên vào danh sách nhân viên.\r\n" +
                    "2) Hiển thị danh sách nhân viên ra màn hình.\r\n" +
                    "3) Tính lương của các nhân viên trong danh sách.\r\n" +
                    "4) Sắp xếp danh sách nhân viên theo mức lương giảm dần.\r\n" +
                    "5) Sắp xếp danh sách nhân viên theo số ngày đi làm trong tháng giảm dần.\r\n" +
                    "6) Tìm và hiển thị thông tin nhân viên theo mã nhân viên.\r\n" +
                    "7) Tìm và hiển thị thông tin nhân viên theo mức lương cho trước nhập vào từ bàn phím.\r\n" +
                    "8) Cập nhật mức lương cho nhân viên mã x vừa được tăng lương.\r\n" +
                    "9) Xóa bỏ nhân viên có mã cho trước.\r\n" +
                    "10) Tính tổng lương của tất cả các nhân viên hiện có trong danh sách.\r\n" +
                    "11) Thoát chương trình");

                Console.Write("Nhập lựa chọn : ");
                key = Console.ReadLine();
                if (int.TryParse(key, out int newKey) == false)
                {
                    Console.WriteLine("Nhập sai định dạng");
                    continue;
                }
                switch (newKey)
                {
                    case 1:
                        employees[index++] = CreatEmployee();
                        break;
                    case 2:
                        ShowEmployeelist(employees);
                        break;
                    case 3:
                        Calsalary(employees);
                        break;
                    case 4:
                        SalarySortDescend(employees);
                        break;
                    case 5:
                        WorkdaySortDescend(employees);
                        break;
                    case 6:
                        FindEmployeeById(employees);
                        break;
                    case 7:
                        FindEmployeeByGroundPay(employees);
                        break;
                    case 8:
                        UpdateEmployeePay(employees);
                        break;
                    case 9:
                        DeleteEmployee(employees , ref index);
                        break;
                    case 10:
                        SumofAllEmpSalary(employees);
                        break;
                    case 11:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Nhập sai lựa chọn");
                        break;
                }
            }
        }

        private static void SumofAllEmpSalary(Employee[] employees)
        {
            long sum = 0;
            foreach (var item in employees)
            {
                if (item != null)
                {
                    sum += item.Salary;
                }
            }
            Console.WriteLine($"Tổng lương của tất cả nhân viên trong danh sách là {sum}");
        }

        private static void DeleteEmployee(Employee[] employees, ref int index)
        {
            Console.Write("Nhập mã nhân viên cần xóa : ");
            string id = Console.ReadLine();
            var searched = CheckId(employees, id);
            if (searched != null)
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i] != null && employees[i].Id.CompareTo(searched.Id) == 0)
                    {
                        for (int j = i; j < employees.Length - 1; j++)
                        {
                            employees[j] = employees[i + 1];
                        }
                        index--;
                    }
                }
                Console.WriteLine("Xóa sinh viên thành công");
            }
            else
            {
                Console.WriteLine("Không tìm thấy nhân viên");
            }

        }

        private static void UpdateEmployeePay(Employee[] employees)
        {
            Console.Write("Nhập mã nhân viên : ");
            string id = Console.ReadLine();
            var searched = CheckId(employees, id);
            if (searched != null)
            {
                Console.Write("Nhập lương mới cho nhân viên : ");
                long newPay = long.Parse(Console.ReadLine());
                if (newPay < 0)
                {
                    Console.WriteLine("Lương mới không hợp lệ");
                }
                if (newPay == searched.GroundPay)
                {
                    Console.WriteLine("Lới mới bằng lương cũ");
                }
                else
                {
                    searched.GroundPay = newPay;
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy nhân viên");
            }
        }

        private static void FindEmployeeByGroundPay(Employee[] employees)
        {
            Employee[] searchedEmployee = new Employee[1];
            Console.Write("Nhập mã nhân viên : ");
            long groundPay = long.Parse(Console.ReadLine());
            var searched = CheckPay(employees, groundPay);
            if (searched != null)
            {
                searchedEmployee[0] = searched;
                ShowEmployeelist(searchedEmployee);
            }
            else
            {
                Console.WriteLine($"Không tìm thấy nhân viên có mức lương cơ bản là : {groundPay}");
            }
        }

        private static Employee CheckPay(Employee[] employees, long groundPay)
        {
            foreach (var item in employees)
            {
                if (item != null && item.GroundPay == groundPay)
                {
                    return item;
                }
            }
            return null;
        }

        private static void FindEmployeeById(Employee[] employees)
        {
            Employee[] searchedEmployee = new Employee[1];
            Console.Write("Nhập mã nhân viên : ");
            string id = Console.ReadLine();
            var searched = CheckId(employees, id);
            if (searched != null)
            {
                searchedEmployee[0] = searched;
                ShowEmployeelist(searchedEmployee);
            }
            else
            {
                Console.WriteLine("Không tìm thấy mã nhân viên");
            }
        }

        private static Employee CheckId(Employee[] employees, string id)
        {
            foreach (var item in employees)
            {
                if (item != null && item.Id.CompareTo(id) == 0)
                {
                    return item;
                }
            }
            return null;
        }

        private static void WorkdaySortDescend(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (CheckEmployee(employees[i], employees[j]) > 0)
                    {
                        Swap(ref employees[i], ref employees[j]);
                    }
                }
            }
        }

        private static void SalarySortDescend(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (CheckEmployee(employees[i], employees[j]) > 0)
                    {
                        Swap(ref employees[i], ref employees[j]);
                    }
                }
            }
        }

        private static void Swap(ref Employee employee1, ref Employee employee2)
        {
            Employee tmp = employee1;
            employee1 = employee2;
            employee2 = tmp;
        }

        private static int CheckEmployee(Employee employee1, Employee employee2)
        {
            if (employee1 == null || employee2 == null)
            {
                return 0;
            }
            if (employee1.Salary < employee2.Salary || employee1.WorkDay < employee2.WorkDay)
            {
                return 1;
            }
            return 0;
        }

        private static void Calsalary(Employee[] employees)
        {
            foreach (var item in employees)
            {
                if (item != null)
                {
                    item.SalCount();
                }
            }
        }

        private static void ShowEmployeelist(Employee[] employees)
        {
            var titleId = "MÃ NHÂN VIÊN";
            var titleFullName = "HỌ VÀ TÊN";
            var titlePhonenumber = "SỐ ĐIỆN THOẠI";
            var titlePosition = "CHỨC VỤ";
            var titleWorkday = "SỐ NGÀY LÀM VIỆC";
            var titleSalary = "LƯƠNG";
            Console.WriteLine($"{titleId,-20} {titleFullName,-20} {titlePhonenumber,-20} {titlePosition,-20} {titleWorkday,-20} {titleSalary,-20}");

            foreach (var item in employees)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id,-20} {item.Full,-20} {item.GetPhone(0),-20} {item.Position,-20} {item.WorkDay,-20} {item.Salary,-20}");
                }
            }
        }

        private static Employee CreatEmployee()
        {
            while (true)
            {
                Console.Write("Nhập họ và tên : ");
                string fullName = Console.ReadLine();

                Console.Write("Nhập số điện thoại của nhân viên : ");
                int phone = int.Parse(Console.ReadLine());

                Console.Write("Nhập số ngày làm việc của nhân viên : ");
                string day = Console.ReadLine();

                Console.Write("Nhập chức vụ của nhân viên : ");
                string position = Console.ReadLine();

                Console.Write("Nhập mức lương cơ bản cho nhân viên : ");
                string ground = Console.ReadLine();

                if (int.TryParse(day, out int workDay) == false || long.TryParse(ground, out long groundPay) == false)
                {
                    Console.WriteLine("Nhập sai định dạng");
                    continue;
                }
                return new Employee(null, fullName, phone, position, workDay, 0, groundPay);
            }
        }
    }*/
    }
}