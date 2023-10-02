using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class Array
    {
        static void Main(string[] args)
        {
            #region Bài 1 :
            //    input(out int[] array , out int n);
            //    Mssg(AvrgSum(array));
            //}
            //static int[] input(out int[] array , out  int n)
            //{
            //    Console.Write("Nhap gioi han cua mang : ");
            //    n = int.Parse(Console.ReadLine());
            //    array = new int[n];
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.Write("Nhap gia tri phan tu : ");
            //        array[i] = int.Parse(Console.ReadLine());
            //        AvrgSum(array);
            //    }
            //    return array;
            //}
            //static int AvrgSum(int[] avrgSum)
            //{
            //    int sum = 0;
            //    for (int i = 0; i < avrgSum.Length; i++)
            //    {
            //        sum += avrgSum[i];
            //    }
            //    return sum / avrgSum.Length;
            //}
            //static void Mssg(int a)
            //{
            //    Console.WriteLine($"Trung binh cong cac phan tu la : {a}");
            //}
            #endregion
            #region Bài 2 :
            //     int[] a = input();
            //     int msg = SumArray(a);
            //     Mssg(msg);
            // }
            //static int[] input()
            // {
            //     Console.Write("Nhap gioi han mang : " );
            //     int n = int.Parse(Console.ReadLine());
            //     int[] array = new int[n];
            //     for (int i = 0; i < n; i++)
            //     {
            //         Console.Write($"Nhap gia tri {i} : ");
            //         array[i] = int.Parse(Console.ReadLine());
            //         SumArray(array);
            //     }
            //     return array;
            // }
            // static int SumArray(int[] b)
            // {
            //     int sum = 0;
            //     for (int i = 0;i < b.Length;i++)
            //     {
            //         if (b[i] == 0)
            //         {
            //             break;
            //         }
            //         sum += b[i];
            //     }
            //     return sum;
            // }
            // static void Mssg(int mssg)
            // {
            //     Console.WriteLine($"Tong cac gia tri trong mang la : {mssg}");
            // }
            #endregion
            #region Bài 3 : 
            //    int[] a = input();           
            //}
            //static int[] input()
            //{
            //    int n = int.Parse(Console.ReadLine());
            //    int[] array= new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        array[i] = int.Parse(Console.ReadLine());
            //        PrimeNumb(array);
            //    }
            //    return array;
            //}
            //static void PrimeNumb(int[] d)
            //{
            //    for (int i = 0; i < d.Length; i++)
            //    {
            //        if (isPrimeNumb(d[i]))
            //        {
            //            Console.WriteLine((i, d[i]));
            //        }
            //    }
            //}
            //static bool isPrimeNumb(int c)
            //{
            //    if (c < 2)
            //    {
            //        return false;
            //    }
            //    for (int i = 2; i < Math.Sqrt(c); i++)
            //    {
            //        if (c % i == 0)
            //        {
            //            return false;
            //        }
            //    }
            //    return true;
            //}
            #endregion
            #region Bài 4 :
            //    int[] a = input();
            //    int b = SumEvenNumb(a);
            //    Console.Write($"Trung binh cong cac so chan trong mang la : {b} ");
            //    Console.WriteLine();
            //}
            //static int[] input()
            //{
            //    Console.Write("Nhap so luong phan tu : ");
            //    int n = int.Parse(Console.ReadLine());
            //    int[] array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap phan tu {i} : ");
            //        array[i] = int.Parse(Console.ReadLine());
            //        SumEvenNumb(array);
            //    }
            //    return array;
            //}
            //static int SumEvenNumb(int[] array)
            //{
            //    int sum = 0;
            //    int count = 0;
            //    for ( int i = 0; i < array.Length; i++ )
            //    {
            //        if (isEvenNumb(array[i]))
            //        {
            //            sum += array[i];
            //            count++;
            //        }
            //    }
            //    return sum / count;
            //}
            //static bool isEvenNumb(int c)
            //{
            //    if (c % 2 == 1)
            //    {
            //        return false;
            //    }
            //    return true;
            //}
            #endregion
            #region Bài 5 :
            //    int[] a = input();
            //}
            //static int[] input()
            //{
            //    Console.Write("Nhap gioi han cua mang : ");
            //    int n = int.Parse(Console.ReadLine());
            //    int[] array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap phan tu {i} : ");
            //        array[i] = int.Parse(Console.ReadLine());
            //        if (isSoChinhPhuong(array[i]))
            //        {
            //            Console.WriteLine($"Tai vi tri {i} co phan tu {array[i]} la so chinh phuong.");
            //        }
            //    }
            //    return array;
            //}
            //static bool isSoChinhPhuong(double array)
            //{
            //    double d = Math.Sqrt(array);
            //    if (d * d != array)
            //    {
            //        return false;
            //    }
            //    return true;
            //}
            #endregion
            #region Bài 6 :
            //    int[] b = input();
            //    int a = SoThuanNghich(b);
            //    Mssg(a);
            //}
            //static int[] input()
            //{
            //    Console.Write("Nhap gioi han cua mang : ");
            //    int n = int.Parse(Console.ReadLine());
            //    int[] array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap phan tu {i} : ");
            //        array[i] = int.Parse(Console.ReadLine());              
            //    }
            //    return array;
            //}
            //static int SoThuanNghich(int[] array)
            //{
            //    int soThuanNgich = 0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (isSoThuanNghic(array[i]))
            //        {
            //            soThuanNgich = array[i];
            //        }
            //    }  
            //    return soThuanNgich;
            //}
            //static bool isSoThuanNghic(int n)
            //{
            //    int a = n;
            //    int b = 0;
            //    if (n < 10)
            //    {
            //        return false;
            //    }
            //    while (a > 0)
            //    {
            //        b = b * 10 + a % 10;
            //        a /= 10;
            //    }
            //    return b == n;
            //}
            //static void Mssg(int msg)
            //{
            //    Console.Write($"So thuan nghich trong mang la : {msg} ");
            //    Console.WriteLine();
            //}
            #endregion
            #region Bài 7 :
            int[] a = input();
            int b = max(a);
            int c = min(a);
            if (Check(a))
            {
                mssg(b, c);
            }
            else
            {
                Console.WriteLine("Khong co gia tri max or min");
            }
        }
        static int[] input()
        {
            Console.Write("nhap gioi han cua mang : ");
            int n = int.Parse(Console.ReadLine());
            int[] array = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write($"nhap phan tu {i} : ");
                array[i] = int.Parse(Console.ReadLine());
            }                     
            max(array);
            min(array);                           
            return array;
        }
        static int max(int[] array)
        {
            int max = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                   max = array[i];
                }
            }          
            return max;
        }
        static int min(int[] array)
        {
            int min = array[0];
            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
            }
            return min;
        }
        static void mssg(int msgMax, int msgMin)
        {
            Console.Write($"gia tri lon nhat trong mang la : {msgMax}");
            Console.WriteLine();
            Console.Write($"Gia tri nho nhat cua mang la : {msgMin}");
            Console.WriteLine();
        }
        static bool Check(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (array[0] != array[i])
                {
                    return true;
                }
            }
            return false;
        }
        #endregion
    }
    
}

