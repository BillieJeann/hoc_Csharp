//using System;
//using System.Collections.Generic;
//using System.Data;
//using System.Diagnostics.CodeAnalysis;
//using System.Dynamic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace abc
//{
//    internal class ham_cuc_bo
//    {

//        static void Main(string[] args)
//        {
//            #region Bài 1 :
//            //    Input(out int a , out int b);
//            //    EvenNumb(a , b);
//            //}
//            //static void Input(out int a, out int b)
//            //{
//            //    a = int.Parse(Console.ReadLine());
//            //    b = int.Parse(Console.ReadLine());
//            //}
//            //static void EvenNumb(int a,int b)
//            //{
//            //    for (int i = 0; i <= a; i++)
//            //    {
//            //        if (FindEvenNumb(i))
//            //        {
//            //            Console.WriteLine(i);
//            //        }
//            //    }
//            //    bool FindEvenNumb(int i)
//            //    {
//            //       return i % 2 == 0;
//            //    }
//            //}
//            #endregion
//            #region Bài 2:
//            //    input(out int a ,out int b);
//            //    FindPower(a,b);          
//            //}
//            //static void input(out int a, out int b)
//            //{
//            //    a = int.Parse(Console.ReadLine());
//            //    b = int.Parse(Console.ReadLine());
//            //}
//            //static void FindPower(int a, int b)
//            //{
//            //    for (int i = b; i < Math.Sqrt(a); i++)
//            //    {
//            //        Console.WriteLine(Power(i));
//            //    }
//            //    int Power(int c)
//            //    {
//            //        return c *= c;
//            //    }          
//            //}
//            #endregion
//            #region Bài 3:
//            //    input(out int a);
//            //   Console.WriteLine(IsPerFectNumb(a));                              
//            //}
//            //static void input(out int a)
//            //{
//            //    a = int.Parse(Console.ReadLine());
//            //}
//            //static bool IsPerFectNumb(int a)
//            //{
//            //    int sum = 0;
//            //    for (int i = 1; i < a; i++)
//            //    {
//            //        if (check(i))
//            //        {
//            //            sum += i;
//            //        }
//            //    }
//            //    return sum == a;
//            //    bool check(int c)
//            //    {
//            //       return a % c == 0;
//            //    }          
//            //}
//            #endregion
//            #region Bài 4 :
//            //    input(out double a, out double b, out double c);
//            //    isTriangle(a, b, c);
//            //}
//            //static void input(out double a, out double b, out double c)
//            //{
//            //    a = double.Parse(Console.ReadLine());
//            //    b = double.Parse(Console.ReadLine());
//            //    c = double.Parse(Console.ReadLine());
//            //}
//            //static void isTriangle(double a, double b, double c)
//            //{
//            //    Console.WriteLine(ifTriangle() ? "true" : "false");

//            //    bool ifTriangle()
//            //    {
//            //        if (a + b + c > 0 && a > 0 && b > 0 && c > 0)
//            //        {
//            //            return true;
//            //        }
//            //       return false;
//            //    }
//            //}
//            #endregion
//            #region Bài 5:
//            //    input(out int a, out int b);
//            //    PrimeNumb(a ,b);
//            //}
//            //static void input(out int a , out int b)
//            //{
//            //    a =int.Parse(Console.ReadLine());
//            //    b =int.Parse(Console.ReadLine());
//            //}
//            //static void PrimeNumb(int a , int b)
//            //{
//            //    for(int i = 2; i < a; i++)
//            //    {
//            //        if (IsPrimeNumb(i))
//            //        {
//            //            Console.WriteLine(i);
//            //        }
//            //    }
//            //    bool IsPrimeNumb(int c)
//            //    {
//            //        for (int i = 2; i <= Math.Sqrt(c); i++)
//            //        {
//            //            if (c < 2)
//            //            {
//            //                return false;
//            //            }
//            //            if (c % i == 0)
//            //            {
//            //                return false;
//            //            }
//            //        }
//            //        return true;
//            //    }
//            //}
//            #endregion
//        }
//    }
//}
