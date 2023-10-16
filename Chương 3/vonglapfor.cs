//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace abc
//{
//    internal class vonglapfor
//    {
//        static void Main(string[] args)
//        {
//            #region Vòng lặp for
//            //Console.WriteLine("Nhap so");
//            //int c = int.Parse(Console.ReadLine()); // Biến nhập vào từ bàn phím
//            //Console.WriteLine("Nhap so");
//            //int b = int.Parse(Console.ReadLine()); // Biến nhập vào từ bàn phím
//            //int s = 0; // Biến lưu trữ tổng
//            //Console.WriteLine("cac so nam trong khoang tu : " + (c) + " den " + (b) +  " la :");
//            //for (int i = c + 1 ; i < b; i++) 
//            //{             
//            //    Console.WriteLine(i);
//            //    s += i;

//            //}
//            //Console.WriteLine("Tong cua cac so trong khoang " + (c) + " den " + (b) + " la : ");
//            //Console.WriteLine(s);
//            #endregion

//            /* Bài tập vòng lặp for
//             */

//            #region Bài 1 : Nhập 1 số n vào từ bàn phím xác định các giá trị chẵn trong khoảng từ [0;n]
//            // 
//            //Console.Write(" Nhap so nguyen n : ");
//            //int n = int.Parse(Console.ReadLine());
//            //if (n < 0 || n >= 100)
//            //{
//            //    Console.WriteLine("No result");
//            //}
//            //else
//            //{
//            //    Console.Write(" Gia tri cua i la :");
//            //    for (int i = 0; i <= n; i++)
//            //    {
//            //        if (i % 2 == 0)
//            //        {
//            //            Console.Write(" " +  i);                                             
//            //        }
//            //    }
//            //}
//            #endregion

//            #region Bài 2 : Nhập 2 số n và k vào từ bàn phím xác định tất cả các giá trị lẻ trong khoảng từ [k;n]
//            //Console.WriteLine(" Tim cac gia tri le trong khoang [k;n]");
//            //Console.Write(" Nhap so nguyen n : ");
//            //int n = int.Parse(Console.ReadLine());
//            //Console.Write(" Nhap so nguyen k : ");
//            //int k = int.Parse(Console.ReadLine());
//            //if (n <= 0 || k > n)
//            //{
//            //    Console.WriteLine(" No result");
//            //}
//            //else
//            //    Console.Write("Cac so le trong khoang tu " + k + " den " + n + " la :");
//            //{
//            //    for (int i = k ; i < n; i++)
//            //    {
//            //        if (i % 2 == 1)
//            //        {
//            //            Console.Write(" " + i);
//            //        }
//            //    }
//            //}
//            //Console.ReadLine();
//            #endregion

//            #region Bài 3 : Tính tổng các giá trị trong đoạn từ [1;n]
//            //Console.Write("Nhap so nguyen n : ");
//            //int n = int.Parse(Console.ReadLine());
//            //int Tongi = 0; // Biến để lưu trữ giá trị tổng của i qua mỗi lần lặp
//            //if (n <= 0 || n >= 100)
//            //{
//            //    Console.WriteLine("INVALID");
//            //}
//            //else
//            //{
//            //    Console.Write("Cac so trong khoang [1;n] la :");

//            //    for (int i = 1; i <= n; i++)
//            //    {                  
//            //        Console.Write(" " + i);                    
//            //        Tongi += i;
//            //    }
//            //    Console.WriteLine();
//            //    Console.WriteLine("Tong cac so trong khoang tu 1 den " + n + " la : " + Tongi);
//            //}
//            #endregion

//            #region Bài 4 : Tìm tổng các giá trị trong khoảng [1;1/n] 
//            //Console.Write("Nhap so n : ");
//            //double n = double.Parse(Console.ReadLine());
//            //double a = 0;           

//            //if (n <= 0 || n > 100) 
//            //{
//            //    Console.WriteLine("INVALID");
//            //}
//            //else
//            //{
//            //    Console.Write("Cac gia tri trong khoang [1;1/" + n + "]" + " la :");
//            //    for (double i = 1; i <= n; i++ )
//            //    {
//            //        Console.Write(" "+Math.Round((1/i),3)+" ,");
//            //        a += 1 / i ;                   
//            //    }
//            //    Console.WriteLine();
//            //    Console.Write("Tong cac gia tri tren la : ");
//            //    Console.WriteLine( Math.Round( a , 3 ) );
//            //}           
//            #endregion

//            #region Bài 5 : Tìm các giá trị trong khoảng [1;n] chia hết cho k
//            //Console.Write("Nhap so n : ");
//            //int n = int.Parse(Console.ReadLine());
//            //Console.WriteLine();
//            //Console.Write("Nhap so k : ");
//            //int k = int.Parse(Console.ReadLine());
//            //Console.WriteLine();
//            //double d = Math.Pow(10, 9);

//            //if (n < 0 || k < 0 || n >= d || k >= d)
//            //{
//            //    Console.WriteLine("Invalid");
//            //}           
//            //else
//            //{              
//            //    Console.Write("Gia tri cua i la :");
//            //    for (int i = 1; i <= n; i++)
//            //    {
//            //        Console.Write(i + " , ");                    
//            //    }
//            //    Console.WriteLine();
//            //    Console.WriteLine();
//            //    Console.Write("Cac gia tri chia het cho " + k + " la : ");               
//            //    for (int i = 1; i <= n; i++)
//            //    {
//            //        if (i % k == 0)
//            //        {                        
//            //            Console.Write(i + " , ");                       
//            //        }                   
//            //    }
//            //}
//            //Console.WriteLine();
//            //Console.WriteLine();
//            #endregion

//            #region Bài 6 : Lồng vòng lặp.

//            //int length = int.Parse(Console.ReadLine());
//            //int width = int.Parse(Console.ReadLine());

//            //for (int i = 0; i <= length; i++)
//            //{
//            //    for (int j = 0; j <= width; j++)
//            //    {
//            //        if (i == 0 || j == 0 || j == width || i == length)
//            //        {
//            //            Console.Write(" *");
//            //        }
//            //        else
//            //        {
//            //            Console.Write("  ");
//            //        }
//            //    }
//            //    Console.WriteLine();
//            //}

//            #endregion
//        }
//    }
//}
