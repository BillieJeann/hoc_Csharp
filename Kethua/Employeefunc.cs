using KeThua.Employee;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KeThua.Employee
{
    internal class Employeefunc
    {
        public static Employee CreatEmployee()
        {
            string key;
            while (true)
            {
                Console.Write("" +
               "Bạn muốn tạo đối tượng nhân viên nào . \r\n" +
               "1) Nhân viên.\r\n" +
               "2) Quản lý.\r\n" +
               "3) Giám Đốc.\r\n" +
               "Nhập lựa chọn của bạn : ");
                key = Console.ReadLine();
                if (int.TryParse(key, out int newKey) == false || newKey <= 0 || newKey > 3)
                {
                    Console.WriteLine("Nhập sai định dạng");
                    continue;
                }
                Console.Write("Nhập tên nhân viên : ");
                string fullName = Console.ReadLine();
                Console.Write("Nhập số điện thoại : ");
                string phone = Console.ReadLine();
                Console.Write("Nhập lương cứng : ");
                string wage = Console.ReadLine();
                Console.Write("Nhập số ngày đi làm : ");
                string day = Console.ReadLine();
                if (long.TryParse(phone, out long phonenumber) == false || long.TryParse(wage, out long wageamount) == false || int.TryParse(day, out int workday) == false)
                {
                    Console.WriteLine("Nhập sai định dạng");
                    continue;
                }
                if (newKey == 2)
                {
                    Console.Write("Nhập bộ phận của quản lý : ");
                    string posdescribe = Console.ReadLine();
                    Console.Write("Nhập hệ số thưởng của quản lý : ");
                    string bonus = Console.ReadLine();

                    if (int.TryParse(bonus, out int bonuscoeffecient) == false || bonuscoeffecient > 3)
                    {
                        Console.WriteLine("Nhập sai định dạng");
                        continue;
                    }
                    Employee manager = new Manager(posdescribe, bonuscoeffecient)
                    {
                        Id = null,
                        Name = fullName,
                        PhoneNumber = phonenumber,
                        WageAmount = wageamount,
                        WorkDay = workday,
                        Salary = 0,
                        Position = "Quản lý"
                    };
                    return manager;
                }
                if (newKey == 3)
                {
                    Console.Write("Nhập bộ phận của giám đốc : ");
                    string posdescribe = Console.ReadLine();
                    Console.Write("Nhập ngày nhậm chức : ");
                    string onboard = Console.ReadLine();
                    Console.Write("Nhập doanh thu của công ty trong tháng : ");
                    string monthrev = Console.ReadLine();
                    Console.Write("Nhập hệ số thưởng cho giám đốc : ");
                    string bonus = Console.ReadLine();
                    if (int.TryParse(onboard, out int onboarddate) == false || long.TryParse(monthrev, out long monthRevenue) == false || double.TryParse(bonus, out double bonusPercent) == false)
                    {
                        Console.WriteLine("Nhập sai định dạng");
                        continue;
                    }
                    Employee director = new Director(posdescribe, onboarddate, monthRevenue, bonusPercent)
                    {
                        Id = null,
                        Name = fullName,
                        PhoneNumber = phonenumber,
                        WageAmount = wageamount,
                        WorkDay = workday,
                        Salary = 0,
                        Position = "Giám đốc"
                    };
                    return director;
                }
                return new Employee(null, fullName, phonenumber, wageamount, workday, 0, "Nhân viên");
            }
        }
        public static void ShowEmployeeList(Employee[] employees)
        {
            var titleId = "MÃ NHÂN VIÊN";
            var titleFullname = "HỌ VÀ TÊN";
            var titlePhonenumb = "SỐ ĐIỆN THOẠI";
            var titleWageamount = "LƯƠNG CƠ BẢN";
            var titleWorday = "SỐ NGÀY ĐI LÀM";
            var titlePos = "CHỨC VỤ";
            var titlePosdescribe = "PHÒNG/BAN";
            var titleSalary = "LƯƠNG THỰC LĨNH";
            Console.WriteLine($"{titleId,-15} {titleFullname,-15} {titlePhonenumb,-15} {titleWageamount,-15} {titleWorday,-15} {titlePos,-15} {titleSalary,-5} {titlePosdescribe,15}");
            foreach (var item in employees)
            {
                if (item != null)
                {
                    if (item is Director)
                    {
                        Director director = (Director)item;
                        Console.WriteLine($"{director.Id,-15} {director.Name,-15} {director.PhoneNumber,-15} {director.WageAmount,-15} {director.WorkDay,-15} {director.Position,-15} {director.Salary,-15} {director.DirectorPosition,10}");
                    }
                    else if (item is Manager)
                    {
                        var manager = (Manager)item;
                        Console.WriteLine($"{manager.Id,-15} {manager.Name,-15} {manager.PhoneNumber,-15} {manager.WageAmount,-15} {manager.WorkDay,-15} {manager.Position,-15} {manager.Salary,-15} {manager.ManagerPosition,10}");
                    }
                    else
                    {
                        Console.WriteLine($"{item.Id,-15} {item.Name,-15} {item.PhoneNumber,-15} {item.WageAmount,-15} {item.WorkDay,-15} {item.Position,-15} {item.Salary,-5}");
                    }
                }
            }
        }
        internal static void CalSal(Employee[] employees)
        {
            foreach (var item in employees)
            {
                if (item != null)
                {
                    item.CalSalary();
                }
            }
        }
        internal static void SortbySalary(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (CheckEmpSal(employees[i], employees[j]) > 0)
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
        private static int CheckEmpSal(Employee employee1, Employee employee2)
        {
            if (employee1 == null || employee2 == null)
            {
                return 0;
            }
            if (employee1.Salary < employee2.Salary)
            {
                return 1;
            }
            return -1;
        }

        internal static void SortbyWorkday(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (CheckEmpDay(employees[i], employees[j]) > 0)
                    {
                        Swap(ref employees[i], ref employees[j]);
                    }
                }
            }
        }

        private static int CheckEmpDay(Employee employee1, Employee employee2)
        {
            if (employee1 == null || employee2 == null)
            {
                return 0;
            }
            if (employee1.WorkDay < employee2.WorkDay)
            {
                return 1;
            }
            return -1;
        }

        internal static void FindbyId(Employee[] employees)
        {
            Employee[] searched = new Employee[1];
            Console.Write("Nhập id nhân viên cần tìm kiếm : ");
            string id = Console.ReadLine();
            var searchedEmp = CheckId(employees, id);
            if(searchedEmp != null)
            {
                searched[0] = searchedEmp;
                ShowEmployeeList(searched);
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
                if (item != null && item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        internal static void UpdateWage(Employee[] employees)
        {
            Console.Write("Nhập id nhân viên cần sửa lương : ");
            string id = Console.ReadLine();

            var searched = CheckId(employees, id);
            if(searched != null)
            {
                Console.Write("Nhập lương : ");
                long newWage = long.Parse(Console.ReadLine());
                searched.WageAmount = newWage;
            }
            else
            {
                Console.WriteLine("Không tìm thấy mã nhân viên");
            }
        }

        internal static void Delete(Employee[] employees, ref int index)
        {
            Console.Write("Nhập mã nhân viên cần xóa : ");
            string id = Console.ReadLine();

            var searched = CheckId(employees, id);
            if(searched != null)
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i] != null && employees[i] == searched)
                    {
                        for (int j = i; j < employees.Length -1; j++)
                        {
                            Swap(ref employees[j], ref employees[j + 1]);
                        }
                        index--;
                    }
                }
            }
            else
            {
                Console.WriteLine("Không tìm thấy mã nhân viên");
            }
        }
    }
}
