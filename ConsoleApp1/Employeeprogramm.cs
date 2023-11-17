using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Partialclass.Emp
{
    class Empfunc
    {
        public static Employee CreatEmp()
        {
            Console.Write("Nhập tên nhân viên : ");
            string? fullName = Console.ReadLine();

            Console.Write("Nhập số điện thoại của nhân viên : ");
            long phoneNumb = long.Parse(Console.ReadLine());

            Console.Write("Nhập chức vụ của nhân viên : ");
            string? pos = Console.ReadLine();

            Console.Write("Nhập số ngày đi làm trong tháng của nhân viên : ");
            int workDay = int.Parse(Console.ReadLine());

            return new Employee(null, fullName, phoneNumb, pos, 0, workDay);

        }
        public static void ShowEmplist(Employee[] employees)
        {
            var titleId = "MÃ NHÂN VIÊN";
            var titleFullname = "HỌ VÀ TÊN";
            var titlePhonenumb = "SỐ ĐIỆN THOẠI";
            var titlePosition = "CHỨC VỤ";
            var titleWorkday = "SỐ NGÀY LÀM VIỆC";
            var titleSalary = "LƯƠNG";
            Console.WriteLine($"{titleId,-20} {titleFullname,-20} {titlePhonenumb,-20} {titlePosition,-20} {titleWorkday,-20} {titleSalary,-20}");
            foreach (var item in employees)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.Id,-20} {item.FullName,-20} {item.PhoneNumber,-20} {item.Position,-20} {item.WorkDay,-20} {item.Salary,-20}");
                }
            }
        }
        public static void CalSalary(Employee[] employees)
        {
            for (int i = 0; i < employees.Length; i++)
            {
                if (employees[i] != null)
                {
                    employees[i].SalCount();
                }
            }
            Console.WriteLine("TÍNH LƯƠNG NHÂN VIÊN THÀNH CÔNG !");
        }
        public static void SortSalary(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (CheckSal(employees[i], employees[j]) > 0)
                    {
                        Swap(ref employees[i], ref employees[j]);
                    }
                }
            }
        }
        public static void WorkDaySort(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (CheckWorkDay(employees[i], employees[j]) > 0)
                    {
                        Swap(ref employees[i], ref employees[j]);
                    }
                }
            }
        }
        public static void FindEmployee(Employee[] employees)
        {
            Employee[] searchedEmp = new Employee[1];
            var searched = CheckId(employees);
            if (searched != null)
            {
                searchedEmp[0] = searched;
                ShowEmplist(searchedEmp);
            }
            else
            {
                Console.WriteLine("Không tìm thấy mã nhân viên !");
            }
        }

        private static Employee CheckId(Employee[] employees)
        {
            Console.Write("Nhập mã nhân viên : ");
            string id = Console.ReadLine();

            foreach (var item in employees)
            {
                if (item != null && item.Id == id)
                {
                    return item;
                }
            }
            return null;
        }

        private static int CheckWorkDay(Employee employee1, Employee employee2)
        {
            if (employee1 == null || employee2 == null)
            {
                return 0;
            }
            if (employee1.WorkDay < employee2.WorkDay)
            {
                return 1;
            }
            return 0;
        }
        private static int CheckSal(Employee employee1, Employee employee2)
        {
            if (employee1 == null || employee2 == null)
            {
                return 0;
            }
            if (employee1.Salary < employee2.Salary)
            {
                return 1;
            }
            return 0;
        }
        private static void Swap(ref Employee employee1, ref Employee employee2)
        {
            Employee tmp = employee1;
            employee1 = employee2;
            employee2 = tmp;
        }

        internal static void RaiseSalary(Employee[] employees)
        {
            var searchedEmp = CheckId(employees);
            if (searchedEmp != null)
            {
                Console.Write("Nhập tiền lương tăng của nhân viên : ");
                long bonus = long.Parse(Console.ReadLine());
                searchedEmp.GroundPay += bonus;
            }
            else
            {
                Console.WriteLine("Không tìm thấy mã nhân viên.");
            }
        }

        internal static void DeleteEmp(Employee[] employees, ref int index)
        {
            var searchedEmp = CheckId(employees);
            if (searchedEmp != null)
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if (CheckEmp(employees[i], searchedEmp) > 0)
                    {
                        for (int j = i; j < employees.Length - 1; j++)
                        {
                            employees[j] = employees[j + 1];
                        }
                    }
                }
                index--;
            }
            else
            {
                Console.WriteLine("KHÔNG TÌM THẤY MÃ SINH VIÊN !");
            }
        }

        private static int CheckEmp(Employee employee1, Employee searchedEmp)
        {
            if (employee1 == null && employee1 != searchedEmp)
            {
                return 0;
            }
            else
            {
                return 1;
            }
        }
    }
    class Programm
    {
        /*static void Main()
        {
            Employee[] employees = new Employee[10];
            int index = 0;
            bool end = true;
            int key;
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
                    "7) Cập nhật mức lương cho nhân viên mã x vừa được tăng lương.\r\n" +
                    "8) Xóa bỏ nhân viên có mã cho trước.\r\n" +
                    "9) Thoát chương trình.");

                Console.WriteLine("Nhập lựa chọn của bạn : ");
                key = int.Parse(Console.ReadLine());
                switch (key)
                {
                    case 1:
                        employees[index++] = Empfunc.CreatEmp();
                        break;
                    case 2:
                        Empfunc.ShowEmplist(employees);
                        break;
                    case 3:
                        Empfunc.CalSalary(employees);
                        break;
                    case 4:
                        Empfunc.SortSalary(employees);
                        break;
                    case 5:
                        Empfunc.WorkDaySort(employees);
                        break;
                    case 6:
                        Empfunc.FindEmployee(employees);
                        break;
                    case 7:
                        Empfunc.RaiseSalary(employees);
                        break;
                    case 8:
                        Empfunc.DeleteEmp(employees, ref index);
                        break;
                    case 9:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("NHẬP SAI LỰA CHỌN !");
                        break;
                }
            }
        }*/
    }
}
