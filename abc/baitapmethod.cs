//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Diagnostics.CodeAnalysis;
//using System.Linq;
//using System.Net.Http;
//using System.Net.Http.Headers;
//using System.Runtime.InteropServices;
//using System.Runtime.InteropServices.WindowsRuntime;
//using System.Runtime.Remoting.Messaging;
//using System.Text;
//using System.Threading.Tasks;

//namespace abc
//{
//    internal class baitapmethod
//    {
//        static void Main(string[] args)
//        {
//            /*Bai 1
//              int data = 0;

//              int n = int.Parse(Console.ReadLine());
//              Console.Write("Tong cac gia tri tu 0 den " + n + " = ");
//              if (n < 0 || n >= 100)
//              {
//                  Console.WriteLine("Invalid");
//              }
//              else
//              {
//                  data = total(n);
//                  Message(data);
//              }
//          }
//          static void Message(int message1)
//          {
//              Console.WriteLine("Tong la : " + message1);
//          }
//          static int total(int value)
//          {
//              int sum = 0;
//              for (int i = 0; i <= value; i++)
//              {
//                  if (i == 0)
//                  {
//                      Console.Write(i);
//                  }
//                  else
//                  {
//                      Console.Write(" + " + i);
//                      sum += i;
//                  }
//              }
//              Console.WriteLine();
//              return sum;
//          }*/

//            /*Bai 2 
            
//            int n = int.Parse(Console.ReadLine());
//            int k = int.Parse(Console.ReadLine());           
//            if (n < 0 || n <= k)
//            {
//                Console.WriteLine("Invalid");
//            }
//            else
//            {
//               TotalOdd(n, k);              
//            }          
//        }
     
//        static void TotalOdd(int value1, int value2)
//        {         
//           for (int i = 0; i <= value1; i++)
//            {
//                if (i % 2 == 1)
//                {
//                    Console.WriteLine(i);
//                }
//            }           
//        }*/

//            /*Bai 3
//           int n = int.Parse(Console.ReadLine());

//           if (n < 1)
//           {
//               Console.WriteLine("invalid");
//           }
//           else
//           {
//               double c = Total(n);
//               c = Math.Round(c, 5);
//               Console.WriteLine(c);
//           }
//       }
//       static double Total(int value1)
//       {
//           double sum = 0;
//           for (double i = 1; i <= value1; i++)
//           {
//               sum += 1 / Math.Pow(i, 2);                
//           }
//           return sum;
//       }*/

//            /* Bai 4
//            int n = int.Parse(Console.ReadLine());
            
//            if (n <= 0 || n >= 27)
//            {
//                Console.WriteLine("Invalid");
//            }
//            else
//            {
//                int sum = 0;
//                sum = Total(n);
//                Console.WriteLine(sum);
//            }
//        }
//        static int Total(int value)
//        {
//            int sumfac = 1;
//            for (int i = 1; i <= value; i++)
//            {
//                sumfac += i * (i - 1);
//            }
//            return sumfac;
//        }*/

//            /* Bai 5
//            int n = int.Parse(Console.ReadLine());
//            int k = int.Parse(Console.ReadLine());

//            if (n < 0 || n >= Math.Pow(10,9) || k < 0 || k >= Math.Pow(10,9) || k >= n)
//            {
//                Console.WriteLine("Invalid");
//            }
//            else
//            {               
//                value(n,k);
//                Console.WriteLine();
//            }
//        }
//        static void value(int value1 , int value2)
//        {
//            for (int i = value2; i <= value1; i++)
//            {
//                if (i == value2)
//                {
//                    Console.Write(i);
//                }
//                else if(i % value2 == 0)
//                {
//                Console.Write(" + " + i);
//                }
//            }
            
//        }*/

//            #region Bai 6
//            //    int n = int.Parse(Console.ReadLine());

//            //    if (n < 2)
//            //    {
//            //        Console.WriteLine("Invalid");
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine($"{(isPrimeNumber(n) ? "true" : "false")}");
//            //    }
//            //}
//            //static bool isPrimeNumber(int value)
//            //{
//            //    for (int i = 2; i < value; i++)
//            //    {
//            //        if (value % i == 0)
//            //        {
//            //            return false;
//            //        }
//            //    }
//            //    return true;

//            //int S = int.Parse(Console.ReadLine());

//            //for (int i = 1; i <= S; i++)
//            //{             
//            //    for (int j = 1; j < 2 * S; j++)
//            //    {
//            //        if ( S - j <= i - 1 )
//            //        {                     
//            //            Console.Write(" * ");
//            //        }
//            //        else
//            //        {
//            //            Console.Write("  ");
//            //        }

//            //    }
//            //    Console.WriteLine();
//            #endregion

//            #region Bai 7
//            //     do
//            //     {
//            //         Console.Write("Moi ban nhap so a : ");
//            //         double a = double.Parse(Console.ReadLine());               
//            //         Console.Write("Moi ban nhap so b : ");
//            //         double b = double.Parse(Console.ReadLine());             
//            //         if (a < 0 || b < 0)
//            //         {
//            //             Console.WriteLine("Invalid");
//            //             Console.Write("Nhap yes de tiep tuc : ");
//            //             continue;
//            //         }
//            //         else
//            //         {
//            //             Console.Write("Moi ban nhap phep tinh : ");
//            //             string c = Console.ReadLine();
//            //             Console.Write("Ket qua la : ");
//            //             switch (c)
//            //             {
//            //                 case "+":                           
//            //                     Console.WriteLine(Sum(a, b));                           
//            //                     break;

//            //                 case "-":                        
//            //                     Console.WriteLine(Hieu(a, b));                         
//            //                     break;

//            //                 case "*":
//            //                     Console.WriteLine(Tich(a, b));                         
//            //                     break;

//            //                 case "/":
//            //                     double round = Math.Round(Thuong(a, b), 3);
//            //                     Console.WriteLine(round);
//            //                     break;

//            //                 case "%":
//            //                     round = Math.Round(soDu(a, b) , 3);
//            //                     Console.WriteLine(round);                           
//            //                     break;

//            //                 case "^":
//            //                     Console.WriteLine(Mu(a, b));                            
//            //                     break;

//            //                 default:
//            //                     Console.WriteLine("Ban da nhap sai dinh dang");                            
//            //                     break;                           
//            //             }
//            //             Console.Write("Ban co muon tiep tuc ? " );                   
//            //         }
//            //     }
//            //     while (Console.ReadLine() == "yes");
//            //     Console.WriteLine("Bye");
//            // }
//            // static double Sum( double x , double y )
//            // {
//            //     double sum = 0;
//            //     sum = x + y;
//            //     return sum;
//            // }
//            // static double Hieu(double x, double y)
//            // {
//            //     double hieu = 0;
//            //     hieu = x - y;
//            //     return hieu;
//            // }
//            //static double Tich(double x, double y)
//            // {
//            //     double t = 1;
//            //     t = x * y;
//            //     return t;          
//            // }
//            // static double Thuong(double x, double y)
//            // {
//            //     double t = 1;
//            //     t = x / y ;
//            //     return t;
//            // }
//            // static double Mu(double x, double y)
//            // {
//            //     double mu = 0;
//            //     mu = Math.Pow(x, y);
//            //     return mu;
//            // }
//            // static double soDu(double x, double y)
//            // {
//            //     double du = 0;
//            //     du = x % y;
//            //     return du;
//            // }
//            #endregion

//            #region Bai 8 :
//            do
//            {
//                Console.Write("Nhap so A : ");
//                int a = int.Parse(Console.ReadLine());
//                Console.Write("Nhap so B : ");
//                int b = int.Parse(Console.ReadLine());
//                Console.Write($"Uoc chung lon nhat cua {a} va {b} la : ");
//                Console.Write(uMax(a , b));
//                Console.WriteLine();
//                Console.Write($"Boi chung nho nhat cua {a} va {b} la : ");
//                Console.Write(bMin(a , b));
//                Console.WriteLine();
//                Console.Write("Nhap y de tiep tuc : ");
//            }
//            while (Console.ReadLine() == "y");                                                                           
//        }        
//        static int uMax(int valA, int valB)
//        {
//            int c = 0;
//            int d = 0;
//            int uMax = 0;
//            for (int i = 1; i <= valA || i < valB; i++)
//            {
//                if (valA % i == 0)
//                {
//                    c = i;
//                }
//                if (valB % i == 0)
//                {
//                    d = i;
//                }
//                if (c == d)
//                {
//                    uMax = d;
//                }               
//            }
//            return uMax;           
//        }
//        static int bMin ( int valA, int valB)
//        {           
//            int bMin = 1;
//            int c = 1;
//            int d = 1;
//            for (int i = 1; i <= valA || i <= valB; i++)
//            {
//                if ((valA * i) % valB == 0)
//                {
//                    bMin = valA * i;
//                    break;
//                }                
//            }
//            return bMin;          
//        }
//        #endregion
//    }
//}


