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
            //    while (true)
            //    {
            //        int[] a = input();
            //        int b = max(a);
            //        int c = min(a);
            //        if (Check(a))
            //        {
            //            max(a);
            //            min(a);
            //            mssg(b, c);
            //            Console.WriteLine();
            //        }
            //        else
            //        {
            //            Console.WriteLine("Khong co gia tri max or min");
            //            Console.WriteLine();
            //        }
            //    }
            //}         
            //static int[] input()
            //{
            //    Console.Write("nhap gioi han cua mang : ");
            //    int n = int.Parse(Console.ReadLine());
            //    int[] array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"nhap phan tu {i} : ");
            //        array[i] = int.Parse(Console.ReadLine());
            //    }                                                          
            //    return array;
            //}
            //static int max(int[] array)
            //{
            //    int max = array[0];
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] > max)
            //        {
            //           max = array[i];
            //        }
            //    }          
            //    return max;
            //}
            //static int min(int[] array)
            //{
            //    int min = array[0];
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (min > array[i])
            //        {
            //            min = array[i];
            //        }
            //    }
            //    return min;
            //}
            //static void mssg(int msgMax, int msgMin)
            //{
            //    Console.Write($"gia tri lon nhat trong mang la : {msgMax}");
            //    Console.WriteLine();
            //    Console.Write($"Gia tri nho nhat cua mang la : {msgMin}");
            //    Console.WriteLine();
            //}
            //static bool Check(int[] array)
            //{
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[0] != array[i])
            //        {
            //            return true;
            //        }
            //    }
            //    return false;
            //}
            #endregion
            #region Bài 8 :
            //    int[] a = input();
            //    int b = FindMax(a);
            //    int c = FindMin(a);
            //    scdMaxandMin(a, b ,c);            
            //}
            //static int[] input()
            //{
            //    Console.Write("Nhap gioi han mang : ");
            //    int n = int.Parse(Console.ReadLine());
            //    int[] array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap phan tu {i} : ");
            //        array[i] = int.Parse(Console.ReadLine());
            //    }
            //    return array;
            //}
            //static int FindMax(int[] array)
            //{
            //    int max = array[0];
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] > max)
            //        {
            //            max = array[i];
            //        }
            //    }
            //    return max;
            //}
            //static int FindMin(int[] array)
            //{
            //    int min = array[0];
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] < min)
            //        {
            //            min = array[i];
            //        }
            //    }
            //    return min;
            //}
            //static void scdMaxandMin(int[] array,  int max,  int min)
            //{          
            //    int scdMax = min;
            //    int scdMin = max;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if ((array[i] != max) && array[i] > scdMax)
            //        {
            //            scdMax = array[i];
            //        }
            //        if (array[i] != min && array[i] < scdMin)
            //        {
            //            scdMin = array[i];
            //        }                              
            //    }
            //    Console.Write($"So lon thu 2 trong mang la : {scdMax}");
            //    Console.WriteLine();
            //    Console.Write($"So nho thu 2 trong mang la : {scdMin}");
            //    Console.WriteLine();
            //}
            #endregion
            #region Bài 9 :
            //    input(out int[] array,out int n, out int x);           
            //    Mssg(Appearence(array, x));
            //}
            //static int[] input(out int[] array,out int n , out int x)
            //{
            //     Console.Write("Nhap gioi han mang : ");
            //     n = int.Parse(Console.ReadLine());
            //     Console.Write("Nhap so x : ");
            //     x = int.Parse(Console.ReadLine());
            //     array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap phan tu {i} : ");
            //        array[i] = int.Parse(Console.ReadLine());
            //    }
            //    return array;
            //}
            //static int Appearence(int[] array, int x)
            //{
            //    int count = 0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] == x)
            //        {
            //            count++;
            //        }
            //    }
            //    return count;
            //}
            //static void Mssg(int msg)
            //{
            //    Console.WriteLine($"So lan xuat hien cua x trong mang la : {msg}");
            //}
            #endregion
            #region Bài 10:
            //    input(out int[] array, out int n, out int k);
            //    Mssg(EvenOutk(array, k));
            //}
            //static int[] input(out int[] array, out int n, out int k)
            //{
            //    Console.Write("Nhap so phan tu trong mang : ");
            //    n = int.Parse(Console.ReadLine());
            //    Console.Write("Nhap so k : ");
            //    k = int.Parse(Console.ReadLine());
            //    if (n < 0 || k == 0)
            //    {
            //        Console.Write("Invalid");
            //    }          
            //    array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap phan tu {i} : ");
            //        array[i] = int.Parse(Console.ReadLine());   
            //    }
            //    return array;
            //}
            //static int EvenOutk(int[] array, int k)
            //{
            //    int count = 0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] % k == 0)
            //        {
            //            count++;
            //        }
            //    }
            //    return count;
            //}
            //static void Mssg(int msg)
            //{
            //    Console.Write($"Co {msg} phan tu chia het cho k ");
            //    Console.WriteLine();
            //}
            #endregion
            #region Bài 11:
            //    input(out int[] array, out int n);
            //    if (isSemetryArray(array))
            //    {
            //        Console.Write("Yes");
            //    }
            //    else
            //    {
            //        Console.Write("No");
            //    }
            //    Console.WriteLine();
            //}
            //static int[] input(out int[] array, out int n)
            //{
            //    Console.Write("Nhap so phan tu cua mang : ");
            //    n = Convert.ToInt32(Console.ReadLine());
            //    array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap phan tu {i} : ");
            //        array[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    return array;
            //}
            //static bool isSemetryArray(int[] array)
            //{
            //    for (int i = 0; i < array.Length / 2; i++)
            //    {
            //        if (array[i] != array[array.Length - 1 - i])
            //        {
            //            return false;
            //        }
            //    }
            //    return true;
            //}
            #endregion
            #region Bài 12:
            //    input(out int[] array, out int n);
            //    SortArrayIncrease(array);          
            //}
            //static int[] input(out int[] array , out int n)
            //{
            //     Console.Write("Nhap so phan tu cua mang : ");
            //     n = Convert.ToInt32(Console.ReadLine());
            //     array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap phan tu {i} : ");
            //        array[i] = Convert.ToInt32(Console.ReadLine());              
            //    }
            //    Console.Write("Mang truoc khi sap xep la :");
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.Write(" " + array[i]);
            //    }
            //    Console.WriteLine();
            //    return array;
            //}
            //static int[] SortArrayIncrease(int[] array)
            //{          
            //    for (int i = 0; i < array.Length - 1; i++)
            //    {
            //        for (int j = i + 1; j < array.Length; j++)
            //        {
            //            if (array[i] > array[j])
            //            {
            //                int newPos = array[i]; // Tạo biến để lưu trữ giá trị hiện tại của array[i]
            //                array[i] = array[j]; // Gán array[i] = giá trị của array[j]
            //                array[j] = newPos; // Gán giá trị trước đó của array[i] cho array[j]
            //            }
            //        }
            //    }
            //    Console.Write("Mang sau sap xep la : ");
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.Write(array[i] + " ");
            //    }
            //    Console.WriteLine();
            //    return array;
            //}
            #endregion
            #region Bài 13: 
            //    input(out double[] array, out int n);
            //    SortArrayDecrease(array);
            //}
            //static double[] input(out double[] array, out int n)
            //{
            //    Console.Write("Nhap so phan tu trong mang : ");
            //    n = Convert.ToInt32(Console.ReadLine());
            //    array = new double[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap phan tu {i} : ");
            //        array[i] = Convert.ToDouble(Console.ReadLine());
            //    }
            //    Console.Write("Mang truoc khi sap xep la : ");
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write(array[i] + " ");
            //    }
            //    Console.WriteLine();
            //    return array;
            //}
            //static double[] SortArrayDecrease(double[] array)
            //{
            //    for (int i = 0; i < array.Length - 1; i++)
            //    {
            //        for (int j = i + 1; j < array.Length; j++)
            //        {
            //            if (array[i] < array[j])
            //            {
            //                double newPos = array[i];
            //                array[i] = array[j];
            //                array[j] = newPos;
            //            }
            //        }
            //    }
            //    Console.Write("Mang sau sap xep la : ");
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        Console.Write(array[i] + " ");
            //    }
            //    Console.WriteLine();
            //    return array;
            //}
            #endregion
            #region Bài 14:
            //    input(out int[] array, out int n);
            //    ShowOnce(array);
            //}
            //static int[] input(out int[] array, out int n)
            //{
            //    Console.Write("Nhap so phan tu trong mang : ");
            //    n = Convert.ToInt32(Console.ReadLine());
            //    array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap phan tu {i} : ");
            //        array[i] = Convert.ToInt32(Console.ReadLine());
            //    }
            //    Console.Write("Cac gia tri trong mang la : ");
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write(array[i] + " ");
            //    }
            //    Console.WriteLine();
            //    return array;
            //}
            //static int[] ShowOnce(int[] array)
            //{
            //    for (int i = 0; i < array.Length - 1; i++)
            //    {
            //        for (int j = i + 1; j < array.Length; j++)
            //        {
            //            if (Check(array[i], array[j]))
            //            {
            //                int value = -1;
            //                array[i] = array[j];
            //                array[j] = value;
            //            }
            //        }
            //    }
            //    Console.Write("Mang new : ");
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (array[i] < 0)
            //        {
            //            Console.Write("");
            //        }
            //        else
            //        {
            //            Console.Write(array[i] + " ");                   
            //        }
            //    }
            //    Console.WriteLine();
            //    return array;
            //}
            //static bool Check(int arrayi, int arrayj)
            //{
            //    if (arrayi != arrayj)
            //    {
            //        return false;
            //    }
            //    return true;
            //}
            #endregion
        }
    }
}





