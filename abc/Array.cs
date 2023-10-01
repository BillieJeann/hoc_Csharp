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
        }
    }
    
}

