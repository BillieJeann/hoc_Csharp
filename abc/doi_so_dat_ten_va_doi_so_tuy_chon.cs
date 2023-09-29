using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class doi_so_dat_ten_va_doi_so_tuy_chon
    {
        static void Main(string[] args)
        {
            #region Định nghĩa :
            //    // Đối số đặt tên là gán tên của tham số cho đối số vì vậy khi gọi đến đối số thì không cần phải theo thứ tự
            //    // VD : 
            //    input(out string name, out int Stucode, out int age, out string addr, out double gpa);
            //    Mssg(ten:name , msv:Stucode , dc:addr, tuoi:age ,dtb:gpa);
            //}
            //static void input(out string name, out int Stucode, out int age, out string addr, out double gpa)
            //{
            //    name = Console.ReadLine();
            //    Stucode = int.Parse(Console.ReadLine());
            //    age = int.Parse(Console.ReadLine());
            //    addr = Console.ReadLine();
            //    gpa = double.Parse(Console.ReadLine());
            //}
            //static void Mssg(string ten, int msv, int tuoi = 0, string dc = "Ha Noi", double dtb = 0.0) // Đối số tùy chọn : gán giá trị mặc định cho tham số ,
            //                                                                                            //khi gọi đến phương thức mà không có đối số sẽ tự động gán giá trị của tham số cho nó
            //{
            //    Console.WriteLine(ten);
            //    Console.WriteLine(msv);
            //    Console.WriteLine(tuoi);
            //    Console.WriteLine(dc);
            //    Console.WriteLine(dtb);
            //}
            #endregion

            #region Bài 2 :
            //    input(out int a, out int b, out int c);
            //    Sum();
            //    Sum(numb2:b,numb1:a);
            //    Sum(numb1:a, numb2:b, numb3:c);
            //}
            //static void input(out int a, out int b, out int c)
            //{
            //    a = int.Parse(Console.ReadLine());
            //    b = int.Parse(Console.ReadLine());
            //    c = int.Parse(Console.ReadLine());
            //}
            //static void Sum(int numb1 = 0, int numb2 = 0, int numb3 = 0)
            //{
            //    Console.WriteLine(numb1 + numb2 + numb3);
            //}
            #endregion

            #region Bài 3 :
            //    input(out int a, out int b, out int c, out int d);
            //    FindMax();
            //    FindMax(a, b);
            //    FindMax(a,b,c);
            //    FindMax(a,b,c,d);
            //}
            //static void input(out int a, out int b, out int c, out int d)
            //{
            //    a = int.Parse(Console.ReadLine());
            //    b = int.Parse(Console.ReadLine());
            //    c = int.Parse(Console.ReadLine());
            //    d = int.Parse(Console.ReadLine());
            //}
            //static void FindMax(int a = int.MinValue, int b = int.MinValue, int c = int.MinValue, int d = int.MinValue)
            //{
            //    Console.WriteLine(Math.Max(Math.Max(a,b),Math.Max(c,d)));
            //}
            #endregion

        }
    }
}
