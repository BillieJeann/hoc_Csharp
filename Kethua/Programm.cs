using KeThua.Employee;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kethua
{
    internal class Programm
    {
        static void Main()
        {
            #region Bài 1
            //Employee[] employees = new Employee[10];
            //int index = 0;
            //string key;
            //bool run = true;
            //Console.OutputEncoding = Encoding.UTF8;

            //while (run)
            //{
            //    Console.WriteLine("" +
            //        "1) Thêm mới một nhân viên vào danh sách nhân viên.\r\n" +
            //        "2) Hiển thị danh sách nhân viên ra màn hình.\r\n" +
            //        "3) Tính lương của các nhân viên trong danh sách.\r\n" +
            //        "4) Sắp xếp danh sách nhân viên theo mức lương thực lĩnh giảm dần.\r\n" +
            //        "5) Sắp xếp danh sách nhân viên theo số ngày đi làm trong tháng giảm dần.\r\n" +
            //        "6) Tìm và hiển thị thông tin nhân viên theo mã nhân viên.\r\n" +
            //        "7) Cập nhật mức lương cho nhân viên mã x vừa được tăng lương.\r\n" +
            //        "8) Xóa bỏ nhân viên có mã cho trước.\r\n" +
            //        "9) Thoát chương trình.");
            //    Console.Write("Nhập lựa chọn : ");
            //    key = Console.ReadLine();
            //    if(int.TryParse(key, out int newKey) == false )
            //    {
            //        Console.WriteLine("Nhập sai định dạng");
            //        continue;
            //    }
            //    switch (newKey)
            //    {
            //        case 1:
            //            employees[index++] = Employeefunc.CreatEmployee();
            //            break;
            //        case 2:
            //            Employeefunc.ShowEmployeeList(employees);
            //            break;
            //        case 3:
            //            Employeefunc.CalSal(employees);
            //            break;
            //        case 4:
            //            Employeefunc.SortbySalary(employees);
            //            break;
            //        case 5:
            //            Employeefunc.SortbyWorkday(employees);
            //            break;
            //        case 6:
            //            Employeefunc.FindbyId(employees);
            //            break;
            //        case 7:
            //            Employeefunc.UpdateWage(employees);
            //            break;
            //        case 8:
            //            Employeefunc.Delete(employees, ref index);
            //            break;
            //        case 9:
            //            run = false;
            //            break;
            //        default:
            //            Console.WriteLine("Nhập sai lựa chọn");
            //            break;
            //    }
            //}
            #endregion
            #region Bài 2 :
            //Bank[] banks = new Bank[10];
            //int index = 0;
            //string key;
            //bool run = true;
            //Console.OutputEncoding = Encoding.UTF8;
            //while (run)
            //{
            //    Console.WriteLine("" +
            //    "1) Tạo mới một tài khoản ngân hàng với đầy đủ thông tin. Lưu vào danh sách tài khoản.\r\n" +
            //    "2) Kiểm tra số dư của tài khoản bằng cách nhập vào số tài khoản cần kiểm tra.\r\n" +
            //    "3) Nạp tiền vào tài khoản x bằng cách nhập số tài khoản và số tiền cần nạp.\r\n" +
            //    "4) Rút tiền từ tài khoản x bằng cách nhập số tài khoản, mã PIN và số tiền cần rút. Việc rút\r\ntiền chỉ thành công khi nhập đúng mã PIN, đúng số tài khoản và số tiền cần rút < số dư\r\nhiện có + 50k VNđ.\r\n" +
            //    "5) Chuyển tiền từ tài khoản x sang tài khoản y. Để chuyển tiền người dùng cung cấp số tài\r\nkhoản nguồn, số tài khoản đích, số tiền cần chuyển và mã PIN. Việc chuyển tiền chỉ thành\r\ncông khi người dùng nhập đúng tài khoản nguồn, tài khoản đích, đúng mã PIN và số tiền\r\ncần chuyển phải < số dư + 70k VNđ.\r\n" +
            //    "6) Hiển thị danh sách tài khoản ra màn hình dạng bảng gồm các hàng, cột.\r\n" +
            //    "7) Sắp xếp danh sách tài khoản theo số dư giảm dần.\r\n" +
            //    "8) Tìm tài khoản theo 4 số cuối của số tài khoản.\r\n" +
            //    "9) Kết thúc chương trình.");
            //    Console.Write("Nhập lựa chọn : ");
            //    key = Console.ReadLine();
            //    if (int.TryParse(key, out int newKey) == false)
            //    {
            //        Console.WriteLine("Sai định dạng lựa chọn");
            //        continue;
            //    }
            //    switch (newKey)
            //    {
            //        case 1:
            //            banks[index++] = Bankfunc.CreatAccount();
            //            break;
            //        case 2:
            //            Bankfunc.CheckBalanceById(banks);
            //            break;
            //        case 3:
            //            Bankfunc.RechargeById(banks);
            //            break;
            //        case 4:
            //            Bankfunc.WithdrawById(banks);
            //            break;
            //        case 5:
            //            Bankfunc.Transfers(banks);
            //            break;
            //        case 6:
            //            Bankfunc.ShowListBank(banks);
            //            break;
            //        case 7:
            //            Bankfunc.SortByBalance(banks);
            //            break;
            //        case 8:
            //            Bankfunc.FindAccByLastIdDigits(banks);
            //            break;
            //        case 9:
            //            run = false;
            //            break;
            //        default:
            //            Console.WriteLine("Nhập sai lựa chọn");
            //            break;
            //    }
            //}
            #endregion
            #region Bài 3 :
            Student[] students = new Student[10];
            int index = 0;
            string key;
            bool run = true;
            Console.OutputEncoding = Encoding.UTF8;
            while (run)
            {
                Console.WriteLine("" +
                    "1) Thêm mới một sinh viên vào danh sách.\r\n" +
                    "2) Hiển thị danh sách sinh viên ra màn hình ở dạng bảng gồm các hàng, cột ngay ngắn. Thông\r\ntin mỗi sinh viên hiển thị trên 1 dòng.\r\n" +
                    "3) Sắp xếp danh sách sinh viên theo điểm TB giảm dần.\r\n" +
                    "4) Sắp xếp danh sách sinh viên theo tên tăng dần.\r\n" +
                    "5) Sắp xếp danh sách sinh viên theo điểm TB giảm dần, tên tăng dần, họ tăng dần.\r\n" +
                    "6) Tìm sinh viên theo tên. Hiển thị kết quả tìm được.\r\n" +
                    "7) Tìm sinh viên theo tỉnh. Hiển thị kết quả tìm được.\r\n" +
                    "8) Xóa sinh viên theo mã cho trước khỏi danh sách.\r\n" +
                    "9) Liệt kê số lượng sinh viên theo từng tỉnh. Sắp xếp giảm dần theo số lượng.\r\n" +
                    "10) Liệt kê số lượng sinh viên theo đầu điểm môn tiếng anh giảm dần.\r\n" +
                    "11) Sửa điểm TB cho sinh viên theo mã sinh viên.\r\n" +
                    "12) Kết thúc chương trình.");
                Console.Write("Nhập lựa chọn : ");
                key = Console.ReadLine();
                if(int.TryParse(key , out int newKey) == false )
                {
                    Console.WriteLine("Nhập sai định dạng : ");
                    continue;
                }
                switch (newKey)
                {
                    case 1:
                        students[index++] = Studentfunc.CreatStudent();
                        break;
                    case 2:
                        Studentfunc.ShowListStudents(students);
                        break;
                    case 3:
                        Studentfunc.SortByGpa(students);
                        break;
                    case 4:
                        Studentfunc.SortByName(students);
                        break;
                    case 5:
                        Studentfunc.SortAll(students);
                        break;
                    case 6:
                        Studentfunc.FindByName(students);
                        break;
                    case 7:
                        Studentfunc.FindByCity(students);
                        break;
                    case 8:
                        Studentfunc.Delete(students,ref index);
                        break;
                    case 9:
                        Studentfunc.ListofAddress(students);
                        break;
                    case 10:
                        Studentfunc.ListofEngGrade(students);
                        break;
                    case 11:
                        Studentfunc.FixGpa(students);
                        break;
                    case 12:
                        run = false; break;
                    default:
                        Console.WriteLine("Nhập sai lựa chọn");
                        break;
                }
            }
            #endregion
        }
    }
}
