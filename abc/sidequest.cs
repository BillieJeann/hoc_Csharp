using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace learncode
{
    internal class LearnCode
    {
        static void Main(string[] args)
        {
            /*Console.Title = "dang nhap facebook";
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("ten dang nhap: ");
              var tendn = Console.ReadLine();
               string password = "";
              Console.Write("enter password: ");
              while (true)
              {
                  ConsoleKeyInfo key = Console.ReadKey(true);
                  if (key.Key == ConsoleKey.Enter)
                      break;
                  password += key.KeyChar;
                  Console.Write("*");
              }
          Console.Read();*/
         
            #region Cấu trúc lặp cơ bản trong C#
            // Khái niệm : 1 vòng lặp là 1 chuỗi các sự kiện lặp đi lặp lại đến khi thỏa mãn điều kiện dừng của nó
            //Có 5 cách lặp trong C#:
            //     -Goto
            //     - For
            //     - While
            //     - Do While
            //     - Foreach
            //     - Các vòng lặp không chính qui.

            #endregion

            #region Vòng lặp goto:
            // Khái niệm : goto có thể tạo ra 1 vòng lặp bản thân nó không phải 1 cấu trúc lặp. Sử dụng goto để đi đến 1 Lable 
            // Ví dụ 1 :
            //BuiQuangHuy: // Lable là BuiQuangHuy

            //    Console.WriteLine("Di hoc ");

            //    goto BuiQuangHuy;

            //     // goto đi đến Lable Bùi Quang Huy để thực hiện vòng lặp " Di hoc " nó sẽ chỉ thực hiện những gì ở trong Lable nếu ở ngoài Lable thì sẽ bị i

            //    Console.WriteLine("Hoc code ");


            // Vi du 2 :
            //int a = int.Parse(Console.ReadLine());
            //switch (a)
            //{
            //    case 1: // lable case 1 
            //        Console.WriteLine("case 1");
            //    break;
            //    case 2: // lable case 1 
            //        Console.WriteLine("case 2");
            //    goto case 1; // dịch chuyển tới lable case 1
            //    break;      // Đoạn Code này thừa vì sẽ không được thực thi vì khi giá trị nhập vào từ bàn phím
            //                // bằng 2 thì lệnh go to sẽ nhảy về case 1 và thực hiện các lệnh trong case này.

            //    case 3:     // Lable case 3
            //        Console.WriteLine("case 3");
            //    break;
            //    default:
            //        Console.WriteLine("Error");
            //    break;
            //}
            // Ví dụ 3 :

            //    int a = int.Parse(Console.ReadLine());

            //    if(a == 2) 
            //    {
            //        goto a_Is_2;
            //    }       

            //    Console.WriteLine("A == 1 ");

            //a_Is_2:

            //    Console.WriteLine("A == 2 ");

            // Ví dụ 4 : Vòng lặp không giới hạn

            //    int a = int.Parse(Console.ReadLine());

            //InfinityLoop:

            // if (a == 2) 
            // {
            //   goto a_Is_2;

            // }

            //    Console.WriteLine("A == 1");

            //a_Is_2:

            //   Console.WriteLine("A == 2");

            //    goto InfinityLoop;

            // Ví dụ 5 : Vòng lặp có giới hạn

            // Ví dụ muốn lặp "Bui Quang Huy" 10 lần
            //    string a = "bui quang huy";
            //    int count = 0; // khai báo biến đếm do kiểu dữ liệu string không thể tăng thêm đơn vị 
            //loop:

            //    Console.WriteLine(a); // xuất ra màn hình biến chuỗi a 

            //    count++; // với mỗi lần biến a xuất ra màn hình thì biến count + 1 đơn vị

            //    if (count < 10) // điều kiện 
            //    {
            //        goto loop; // nếu điều kiện thỏa mãn thì lặp lại trình tự trong lable loop
            //    }
            //    Console.WriteLine("end"); // nếu điều kiện 0 thỏa mãn thì xuất ra màn hình 

            #endregion       

            #region

            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
                for (int i = 0; i < length; i++)
                {
                    for (int j = 0; j <= width; j++)
                    {
                        if (j == width / 2)
                        {
                            Console.Write("*");
                        }
                        else
                        {
                            Console.Write(" ");
                        }
                    }
                }
            #endregion
        }
    }
}
    

