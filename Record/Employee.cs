using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Record.Work3
{
    record class Employee(int id , string fullName , int workDay , long baseWage , int lateDay )
    {
        public long Fine => lateDay * 50000;
        public long TempSal => baseWage * workDay / 22;
        public long RealSal => TempSal - Fine;
    }
    class Programm
    {
        static void Main()
        {
            Employee[] employees = new Employee[5];
            int index = 0;
            string key;
            bool end = true;
            Console.OutputEncoding = Encoding.UTF8;

            while (end)
            {
                Console.WriteLine("" +
                    "1) Thêm mới một record vào mảng.\r\n" +
                    "2) Hiển thị danh sách các record ra màn hình.\r\n" +
                    "3) Sắp xếp các record theo thứ tự mức lương giảm dần.\r\n" +
                    "4) Sắp xếp các record theo thứ tự mức phạt giảm dần.\r\n" +
                    "5) Sắp xếp các record theo thứ tự lương thực lĩnh giảm dần.\r\n" +
                    "6) Tìm record theo mã nhân viên.\r\n" +
                    "7) Xóa record khỏi mảng.\r\n" +
                    "8) Kết thúc chương trình.");
                    
                Console.Write("Nhập lưa chọn : ");
                key = Console.ReadLine();
                if (int.TryParse(key, out int newKey) == false)
                {
                    Console.WriteLine("Nhập sai định dạng");
                    continue;
                }
                switch (newKey)
                {
                    case 1:
                        employees[index++] = CreatEmp();
                        break;
                    case 2:
                        ShowEmp(employees);
                        break;
                    case 3:
                        DesendSortBasewage(employees);
                        break;
                    case 4:
                        DesendSortFine(employees);
                        break;
                    case 5:
                        DesendSortRealSal(employees);
                        break;
                    case 6:
                        FindById(employees);
                        break;
                    case 7:
                        DeleteEmp(employees , ref index);
                        break;
                    case 8:
                        end = false;
                        break;
                    default:
                        Console.WriteLine("Nhập sai lựa chọn");
                        break;
                }

            }
        }

        private static void DeleteEmp(Employee[] employees, ref int index)
        {
            Console.Write("Nhập mã nhân viên cần xóa : ");
            int id = int.Parse(Console.ReadLine());
            var searched = CheckId(employees, id);
            if(searched != null)
            {
                for (int i = 0; i < employees.Length; i++)
                {
                    if (employees[i] != null && employees[i] == searched)
                    {
                        for (int j = i; j < employees.Length - 1; j++)
                        {
                            employees[j] = employees[j + 1];
                        }
                        index--;
                    }
                }
                Console.WriteLine("Xóa thành công");
            }
            else
            {
                Console.WriteLine("Không tìm thấy mã nhân viên");
            }
            
        }

        private static void FindById(Employee[] employees)
        {
            Employee[] searched = new Employee[1];
            int index = 0;
            Console.Write("Nhập mã nhân viên : ");
            int id = int.Parse(Console.ReadLine());
            var searchedEmp = CheckId(employees, id);
            
            if(searchedEmp != null)
            {
                searched[index] = searchedEmp;
                ShowEmp(searched);
            }
            else
            {
                Console.WriteLine("Không tìm thấy mã nhân viên");
            }
        }

        private static Employee CheckId(Employee[] employees, int id)
        {
            foreach (var item in employees)
            {
                if (item != null && item.id == id)
                {
                    return item;
                }
            }
            return null;
        }

        private static void DesendSortRealSal(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (Check(employees[i], employees[j]) > 0 && employees[i].RealSal < employees[j].RealSal)
                    {
                        Swap(ref employees[i], ref employees[j]);
                    }
                }
            }
        }

        private static void DesendSortFine(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (Check(employees[i], employees[j]) > 0 && employees[i].Fine < employees[j].Fine)
                    {
                        Swap(ref employees[i], ref employees[j]);
                    }
                }
            }
        }

        private static void DesendSortBasewage(Employee[] employees)
        {
            for (int i = 0; i < employees.Length - 1; i++)
            {
                for (int j = i + 1; j < employees.Length; j++)
                {
                    if (Check(employees[i], employees[j]) > 0 && employees[i].baseWage < employees[j].baseWage)
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

        private static int Check(Employee employee1, Employee employee2)
        {
            if(employee1 == null || employee2 == null)
            {
                return 0;
            }           
            return 1;
        }

        private static void ShowEmp(Employee[] employees)
        {
            var titleId = "MÃ NHÂN VIÊN";
            var titleFullname = "HỌ VÀ TÊN";
            var titleWorkday = "SỐ NGÀY ĐI LÀM";
            var titleBasewage = "LƯƠNG CỨNG";
            var titleLateday = "SỐ NGÀY ĐI MUỘN";
            var titleFine = "TIỀN PHẠT";
            var titleTempSal = "LƯƠNG TẠM TÍNH";
            var titleRealSal = "LƯƠNG THỰC LĨNH";
            Console.WriteLine($"{titleId,-20} {titleFullname,-20} {titleWorkday,-20} {titleBasewage,-20} {titleLateday,-20} {titleFine,-20} {titleTempSal,-20} {titleRealSal,-20}");
            foreach (var item in employees)
            {
                if (item != null)
                {
                    Console.WriteLine($"{item.id,-20} {item.fullName,-20} {item.workDay,-20} {item.baseWage,-20} {item.lateDay,-20} {item.Fine,-20} {item.TempSal,-20} {item.RealSal,-20}");
                }
            }
        }

        private static Employee CreatEmp()
        {
            Console.Write("Nhập mã nhân viên : ");
            int id = int.Parse(Console.ReadLine());

            Console.Write("Nhập tên nhân viên : ");
            string fullName = Console.ReadLine();

            Console.Write("Nhập số ngày đi làm : ");
            int workday = int.Parse(Console.ReadLine());

            Console.Write("Nhập lương cơ bản : ");
            long basewage = int.Parse(Console.ReadLine());

            Console.Write("Nhập số ngày đi làm muộn : ");
            int lateday = int.Parse(Console.ReadLine());

            Console.WriteLine("Thêm nhân viên thành công");
            return new Employee(id, fullName, workday, basewage, lateday);
        }
    }
}
