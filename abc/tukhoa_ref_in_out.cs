//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;
//using System.Xml.Schema;

//namespace abc
//{
//    internal class tukhoa_ref_in_out
//    {
//        #region Định nghĩa :
//        // Keyword ref : Cho phép phương thức thay đổi giá trị của đối số 
//        // Keyword in : Cho phép truyền tham chiếu nhưng không cho phép phương thức thay đổi giá trị của đối số
//        // Keyword out : Cho phép truyền tham chiếu trong đó phương thức được gọi phải gán giá trị mới cho đối số
//        #endregion
//        static void Main(string[] args)
//        {
//            // Bài tập
//            #region Bài 5 :

//            //    Input(out int a, out int b, out int c);
//            //    FindMax(out int Max, a, b, c);
//            //    FindMin(out int Min, a, b, c);
//            //    FindAvrSum(out double avrSum, a, b, c);
//            //    FindscnMaxandMin(out int scdMax, out int scdMin, a, b, c);
//            //    Message(Max, Min, Math.Round(avrSum ,3), scdMax, scdMin);
//            //}
//            //static void Input(out int a, out int b, out int c)
//            //{
//            //    a = int.Parse(Console.ReadLine());
//            //    b = int.Parse(Console.ReadLine());
//            //    c = int.Parse(Console.ReadLine());
//            //}
//            //static void FindMax(out int Max, int a, int b, int c)
//            //{
//            //    if (a > b)
//            //    {
//            //        Max = a;
//            //    }
//            //    else if (b > c)
//            //    {
//            //        Max = b;
//            //    }
//            //    else
//            //    {
//            //        Max = c;
//            //    }
//            //}
//            //static void FindMin(out int min, int a, int b, int c)
//            //{
//            //    if (a < b)
//            //    {
//            //        min = a;
//            //    }
//            //    else if (b < c)
//            //    {
//            //        min = b;
//            //    }
//            //    else
//            //    {
//            //        min = c;
//            //    }
//            //}
//            //static void FindAvrSum(out double avrSum, int a, int b, int c)
//            //{
//            //    avrSum = (double)(a + b + c) / 3;
//            //}
//            //static void FindscnMaxandMin(out int scdMax, out int scdMin, int a, int b, int c)
//            //{
//            //    scdMax = 0;
//            //    scdMin = 0;
//            //    if (a > b && a < c)
//            //    {
//            //        scdMax = a;
//            //        scdMin = a;
//            //    }
//            //    if (b > a && b < c)
//            //    {
//            //        scdMax = b;
//            //        scdMin = b;
//            //    }
//            //    if (c > a && c < b)
//            //    {
//            //        scdMax = c;
//            //        scdMin = c;
//            //    }
//            //}
//            //static void Message(in int message1, in int message2, in double message3, in int message4, in int message5)
//            //{
//            //    Console.Write($"Gia tri Max la : {message1}");
//            //    Console.WriteLine();
//            //    Console.Write($"Gia tri Min la : {message2}");
//            //    Console.WriteLine();
//            //    Console.Write($"Trung binh cong la : {message3}");
//            //    Console.WriteLine();
//            //    Console.Write($"So lon thu 2 la : {message4}");
//            //    Console.WriteLine();
//            //    Console.Write($"So nho thu 2 la : {message5}");
//            //    Console.WriteLine();
//            //}
//            #endregion

//            #region Bài 6 :
//            //        Input(out int n, out int k);
//            //        FindMax(out int max, n, k);
//            //        FindMin(out int min, n, k);
//            //        Mssg(max, min);
//            //    }

//            //    static void Input(out int n, out int k)
//            //    {
//            //        n = int.Parse(Console.ReadLine());
//            //        k = int.Parse(Console.ReadLine());
//            //        if (n < 0 || k < 0)
//            //        {
//            //            Console.WriteLine("Invalid");
//            //        }
//            //    }
//            //    static void FindMax(out int max, int n, int k)
//            //    {
//            //        max = 0;
//            //        for (int i = 0; i < n; i++)
//            //        {
//            //            if (i % k == 0)
//            //            {
//            //                max = i;
//            //            }
//            //        }
//            //    }
//            //    static void FindMin(out int min, int n, int k)
//            //    {
//            //        min = 0;
//            //        for (int i = n; i <= k; i++)
//            //        {
//            //            if (i % k == 0)
//            //            {
//            //                min = i;
//            //                break;
//            //            }
//            //        }
//            //    }
//            //    static void Mssg(in int mssg1, in int mssg2)
//            //    {
//            //        Console.WriteLine($"Gia tri max la : {mssg1}");
//            //        Console.WriteLine($"Gia tri min la : {mssg2}");
//            //    }
//            //}
//            #endregion

//            #region Bài 7 :
//            //    Input(out int a, out int b);
//            //    FindUMaxandUmin(out int uMax, out int uMin, a, b);
//            //    Mssg(uMax, uMin);
//            //}
//            //static void Input(out int a, out int b)
//            //{
//            //    a = int.Parse(Console.ReadLine());
//            //    b = int.Parse(Console.ReadLine());                     
//            //}
//            //static void FindUMaxandUmin(out int uMax, out int Umin,int a, int b)
//            //{
//            //    int c = 0;
//            //    int d = 0;
//            //    uMax = 0;
//            //    Umin = 0;
//            //   for (int i = 1; i < b || i < a; i++)
//            //    {
//            //        if (a % i == 0)
//            //        {
//            //            c = i;
//            //        }
//            //        if ( b % i == 0)
//            //        {
//            //            d = i;
//            //        }
//            //        if (c == d)
//            //        {
//            //            uMax = c;
//            //        }               
//            //    }
//            //   for (int i = 1; i < b || i < a; i++)
//            //    {
//            //        if ((a * i) % b == 0)
//            //        {
//            //            c = a * i;
//            //        }
//            //        if ((b * i) % a == 0)
//            //        {
//            //            d = b * i;
//            //        }
//            //        if (c == d)
//            //        {
//            //            Umin = c;
//            //        }
//            //    }
//            //}
//            //static void Mssg(in int mssg, in int mssg2)
//            //{
//            //    Console.WriteLine($"Gia tri max la : {mssg}");
//            //    Console.WriteLine($"Gia tri min la : {mssg2}");
//            //}
//            #endregion
//        }
//    }   
//}





