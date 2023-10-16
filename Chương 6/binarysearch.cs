using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class binarysearch
    {
        static void Main(string[] args)
        {
            #region Bài 1 :
            //    Input(out int[] array, out int n, out int x);
            //    Console.Write(BinarySearch(array, 0, n - 1, x) ? "Yes" : "No");
            //    Console.WriteLine();
            //}
            //static int[] Input(out int[] array, out int n, out int x)
            //{
            //    Console.Write("Nhap so phan tu cua mang : ");
            //    n = int.Parse(Console.ReadLine());
            //    array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap {i} : ");
            //        array[i] = int.Parse(Console.ReadLine());
            //    }
            //    Array.Sort(array);
            //    Console.Write("Nhap so X : ");
            //    x = int.Parse(Console.ReadLine());
            //    return array;
            //}
            //static bool BinarySearch(int[] array, int left, int right, int x)
            //{
            //    if (left <= right)
            //    {
            //        int mid = left + (right - left) / 2;
            //        if (array[mid] == x)
            //        {
            //            return true;
            //        }
            //        if (array[mid] < x)
            //        {
            //            return BinarySearch(array, mid + 1, right, x);
            //        }
            //        if (array[mid] > x)
            //        {
            //            return BinarySearch(array, left, mid - 1, x);
            //        }
            //    }
            //    return false;
            //}
            #endregion
            #region Bài 2 :
            //    Input(out int[] array, out int n, out int x, out int y);
            //    int a = Check(array, x, y);
            //    Console.Write(a);
            //    Console.WriteLine();
            //}
            //static int[] Input(out int[] array, out int n, out int x, out int y)
            //{
            //    Console.Write("Nhap so phan tu cua mang : ");
            //    n = int.Parse(Console.ReadLine());
            //    Console.Write("Nhap so X : ");
            //    x = int.Parse(Console.ReadLine());
            //    Console.Write("Nhap so Y : ");
            //    y = int.Parse(Console.ReadLine());
            //    array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap phan tu {i} : ");
            //        array[i] = int.Parse(Console.ReadLine());
            //    }           
            //    Array.Sort(array);
            //    return array;
            //}
            //static int Check(int[] array, int x, int y)
            //{
            //    int count = 0;
            //    foreach(int item in array)
            //    {
            //        if (item >= x && item <= y)
            //        {
            //            count++;
            //        }
            //    }
            //    return count;
            //}
            #endregion
            #region  Bài 3 :
            //    Input(out int[] array, out int n, out int x);
            //    int a = Check(array, x);
            //    Console.Write(a);
            //    Console.WriteLine();
            //}
            //static int[] Input(out int[] array, out int n, out int x)
            //{
            //    Console.Write("Nhap so phan tu cua mang : ");
            //    n = int.Parse(Console.ReadLine());
            //    Console.Write("Nhap so X : ");
            //    x = int.Parse(Console.ReadLine());           
            //    array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap phan tu {i} : ");
            //        array[i] = int.Parse(Console.ReadLine());
            //    }
            //    Array.Sort(array);
            //    return array;
            //}
            //static int Check(int[] array, int x)
            //{
            //    int count = 0;
            //    foreach (int item in array)
            //    {
            //        if (item == x)
            //        {
            //            count++;
            //        }
            //    }
            //    return count;
            //}
            #endregion
            #region Bài 4 :
            //    Input(out int[] array, out int n, out int x);
            //    int a = Check(array, x);
            //    Console.Write(a);
            //    Console.WriteLine();
            //}
            //static int[] Input(out int[] array, out int n, out int x)
            //{
            //    Console.Write("Nhap so phan tu cua mang : ");
            //    n = int.Parse(Console.ReadLine());
            //    Console.Write("Nhap so X : ");
            //    x = int.Parse(Console.ReadLine());
            //    array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap phan tu {i} : ");
            //        array[i] = int.Parse(Console.ReadLine());
            //    }
            //    return array;
            //}
            //static int Check(int[] array, int x)
            //{
            //    int count = 0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (x == array[i])
            //        {
            //            count = i;
            //        }
            //    }
            //    return count;
            //}
            #endregion
            #region Bài 5 :
            //    Input(out int[] array, out int n, out int x);
            //    int a = CheckFirst(array, x,out int count );
            //    int b = CheckLast(array, x, count);
            //    Console.Write((a,b));
            //    Console.WriteLine();
            //}
            //static int[] Input(out int[] array, out int n, out int x)
            //{
            //    Console.Write("Nhap so phan tu cua mang : ");
            //    n = int.Parse(Console.ReadLine());
            //    Console.Write("Nhap so X : ");
            //    x = int.Parse(Console.ReadLine());
            //    array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap phan tu {i} : ");
            //        array[i] = int.Parse(Console.ReadLine());
            //    }
            //    return array;
            //}
            //static int CheckFirst(int[] array, int x,out int count)
            //{
            //     count = 0;
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        if (x == array[i])
            //        {
            //            return count = i;                   
            //        }
            //    }
            //    return -1;
            //}
            //static int CheckLast(int[] array, int x , int count1)
            //{
            //    int count = 0;
            //    for (int i = count1; i < array.Length; i++)
            //    {
            //        if (x == array[i])
            //        {
            //           return count = i;
            //        }
            //    }
            //    return -1;
            //}
            #endregion
            #region Bài 6 :
            //    Console.Write("Nhap so phan tu cua mang : ");
            //    string n = Console.ReadLine();
            //    char[] array = n.ToCharArray();

            //    Count(array);
            //}
            //static void Count(char[] array)
            //{
            //    for (int i = 0; i < array.Length; i++)
            //    {
            //        int count = 1;
            //        for (int j = i + 1; j < array.Length; j++)
            //        {
            //            if (array[i] == array[j])
            //            {
            //                count++;
            //            }
            //        }
            //        if (Check(array, i, array[i]))
            //        {
            //            Console.WriteLine((array[i] , count));
            //        }
            //    }
            //}
            //static bool Check(char[] array, int b, char value)
            //{
            //    for (int i = 0; i < b; i++)
            //    {
            //        if (array[i] == value )
            //        {
            //            return false;
            //        }
            //    }
            //    return true;
            //}
            #endregion
                 
        }
    }
}
