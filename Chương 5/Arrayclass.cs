//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime;
//using System.Text;
//using System.Text.RegularExpressions;
//using System.Threading.Tasks;

//namespace Chương_5
//{
//    internal class Arrayclass
//    {
//        static void Main(string[] args)
//        {
//            #region Bài 1 :
//            //    do
//            //    {
//            //        Input(out int[] arr, out int n);
//            //        FindMaxMin(arr, out int max, out int min);
//            //        Mssg(max, min);
//            //        Console.Write("Nhap yes de tiep tuc : ");
//            //    }
//            //    while (Console.ReadLine().ToLower() == "yes");
//            //}
//            //private static void Mssg(int max, int min)
//            //{
//            //    if (max != min)
//            //    {
//            //        Console.Write($"Gia tri max la : {max} ");
//            //        Console.WriteLine();
//            //        Console.Write($"Gia tri min la : {min} ");
//            //        Console.WriteLine();
//            //    }
//            //    else
//            //    {
//            //        Console.WriteLine("Khong co gia tri max min ");
//            //    }
//            //}
//            //private static void FindMaxMin(int[] arr, out int max, out int min)
//            //{
//            //    Array.Sort(arr);
//            //    max = arr[arr.Length - 1];
//            //    min = arr[0];
//            //}
//            //private static void Input(out int[] arr, out int n)
//            //{
//            //    Console.Write("Nhap so phan tu cua mang : ");
//            //    n = int.Parse(Console.ReadLine());
//            //    arr = new int[n];
//            //    for (int i = 0; i < n; i++)
//            //    {
//            //        Console.Write($"Nhap {i} : ");
//            //        arr[i] = int.Parse(Console.ReadLine());
//            //    }
//            //    Array.Sort(arr);
//            //}
//            #endregion
//            #region Bài 2 :
//            //    do
//            //    {
//            //        Input(out int[] arr);
//            //        Find2ndMaxMin(arr, out int scdMax, out int scdMin);
//            //        Mssg(scdMin, scdMax);
//            //        Console.Write("Nhap yes de tiep tuc : ");
//            //    }
//            //    while (Console.ReadLine().ToLower() == "yes");
//            //}
//            //private static void Mssg(int scdMin, int scdMax)
//            //{
//            //    if (scdMax == scdMin)
//            //    {
//            //        Console.WriteLine("Khong co gia tri max & min ");
//            //    }
//            //    else
//            //    {
//            //        Console.Write($"Gia tri 2ndMax la : {scdMax}");
//            //        Console.WriteLine();
//            //        Console.Write($"Gia tri 2ndMin la : {scdMin}");
//            //        Console.WriteLine();
//            //    }
//            //}
//            //private static void Find2ndMaxMin(int[] arr, out int scdMax, out int scdMin)
//            //{
//            //    scdMax = 0;
//            //    scdMin = 0;
//            //    Array.Sort(arr);
//            //    for (int i = arr.Length - 1; i > 0; i--)
//            //    {
//            //        if (arr[i] > arr[0])
//            //        {
//            //            scdMin = arr[i];
//            //        }
//            //    }
//            //    for (int i = 0; i < arr.Length; i++)
//            //    {
//            //        if (arr[i] < arr[arr.Length - 1])
//            //        {
//            //            scdMax = arr[i];
//            //        }
//            //    }
//            //}
//            //private static void Input(out int[] arr)
//            //{
//            //    int n = int.Parse(Console.ReadLine());
//            //    arr = new int[n];
//            //    for (int i = 0; i < n; i++)
//            //    {
//            //        Console.Write($"Nhap {i} : ");
//            //        arr[i] = int.Parse(Console.ReadLine());
//            //    }
//            //}
//            #endregion
//            #region Bài 3 : 
//            //    do
//            //    {
//            //        Input(out int[] arr, out int n, out int x);
//            //        int a = (CountAppearence(arr, x));
//            //        Mssg(a);
//            //        Console.Write("Nhap yes de tiep tuc : ");
//            //    }
//            //    while (Console.ReadLine().ToLower() == "yes");
//            //}

//            //private static void Mssg(int x)
//            //{
//            //    Console.Write(x == 0 ? "No value" : "So lan xuat hien cua x la : " + x);
//            //    Console.WriteLine();
//            //}

//            //private static int CountAppearence(int[] arr, int x)
//            //{
//            //    int count = 0;
//            //    foreach (var item in arr)
//            //    {
//            //        if (x == item)
//            //        {
//            //            count++;
//            //        }
//            //    }
//            //    return count;
//            //}

//            //private static void Input(out int[] arr, out int n, out int x)
//            //{
//            //    Console.Write("Nhap so phan tu cua mang : ");
//            //    n = int.Parse(Console.ReadLine());
//            //    arr = new int[n];
//            //    for (int i = 0; i < n; i++)
//            //    {
//            //        Console.Write($"Nhap {i} : ");
//            //        arr[i] = int.Parse(Console.ReadLine());
//            //    }
//            //    Console.Write("Nhap so X : ");
//            //    x = int.Parse(Console.ReadLine());
//            //}
//            #endregion
//            #region Bài 4 :
//            //    do
//            //    {
//            //        Input(out int[] arr);
//            //        SortArray(arr);
//            //        ShowArray(arr);
//            //        Console.Write("Nhap yes de tiep tuc : ");
//            //    }
//            //    while (Console.ReadLine().ToLower() == "yes");

//            //}
//            //private static void ShowArray(int[] arr)
//            //{
//            //    Console.Write("Mang sau khi sap xep la : ");
//            //    foreach (var item in arr)
//            //    {
//            //        Console.Write(item + " ");
//            //    }
//            //    Console.WriteLine();
//            //}
//            //private static void SortArray(int[] arr)
//            //{
//            //    Array.Sort(arr);
//            //}
//            //private static void Input(out int[] arr)
//            //{
//            //    Console.Write("Nhap cac phan tu cua mang : ");
//            //    var element = Console.ReadLine().Split(' ');
//            //    arr = new int[element.Length];
//            //    for (int i = 0; i < arr.Length; i++)
//            //    {
//            //        arr[i] = int.Parse(element[i]);
//            //    }
//            //}
//            #endregion
//            #region Bài 5 :
//            //    do
//            //    {
//            //        Input(out int[] arr);
//            //        ReverseArray(arr);
//            //        ShowArray(arr);
//            //        Console.Write("Nhap yes de tiep tuc : ");
//            //    }
//            //    while (Console.ReadLine().ToLower() == "yes");

//            //}
//            //private static void ShowArray(int[] arr)
//            //{
//            //    Console.Write("Mang sau khi sap xep la : ");
//            //    foreach (var item in arr)
//            //    {
//            //        Console.Write(item + " ");
//            //    }
//            //    Console.WriteLine();
//            //}
//            //private static void ReverseArray(int[] arr)
//            //{
//            //    Array.Sort(arr);
//            //    Array.Reverse(arr);
//            //}
//            //private static void Input(out int[] arr)
//            //{
//            //    Console.Write("Nhap cac phan tu cua mang : ");
//            //    var element = Console.ReadLine().Split(' ');
//            //    arr = new int[element.Length];
//            //    for (int i = 0; i < arr.Length; i++)
//            //    {
//            //        arr[i] = int.Parse(element[i]);
//            //    }
//            //}
//            #endregion
//            #region Bài 6 :
//            //    do
//            //    {
//            //        Input(out int[] arr);
//            //        ShowArray(arr);
//            //        Console.Write("Nhap yes de tiep tuc : ");
//            //    }
//            //    while (Console.ReadLine().ToLower() == "yes");

//            //}
//            //private static void ShowArray(int[] arr)
//            //{
//            //    for (int i = 0; i < arr.Length; i++)
//            //    {
//            //        if (CheckArray(arr, i, arr[i]))
//            //        {
//            //            Console.Write(arr[i] + " ");
//            //        }
//            //    }
//            //    Console.WriteLine();
//            //}
//            //private static bool CheckArray(int[] arr, int current, int v)
//            //{
//            //    for (int i = 0; i < current; i++)
//            //    {
//            //        if (v == arr[i])
//            //        {
//            //            return false;
//            //        }
//            //    }
//            //    return true;
//            //}
//            //private static void Input(out int[] arr)
//            //{
//            //    Console.Write("Nhap cac phan tu trong mang : ");
//            //    var element = Console.ReadLine().Split(' ');
//            //    arr = new int[element.Length];
//            //    for (int i = 0; i < arr.Length; i++)
//            //    {
//            //        arr[i] = int.Parse(element[i]);
//            //    }
//            //}
//            #endregion
//            #region Bài 7 :
//            //    do
//            //    {
//            //        Input(out int[] arr);
//            //        CountApearence(arr);
//            //        Console.Write("Nhap yes de tiep tuc : ");
//            //    }
//            //    while (Console.ReadLine().ToLower() == "yes");

//            //}
//            //private static void CountApearence(int[] arr)
//            //{
//            //    for (int i = 0; i < arr.Length; i++)
//            //    {
//            //        int count = 0;
//            //        for (int j = 0; j < arr.Length; j++)
//            //        {
//            //            if (arr[i] == arr[j])
//            //            {
//            //                count++;
//            //            }
//            //        }
//            //        if (CheckArray(arr, i, arr[i]))
//            //        {
//            //            Console.WriteLine(($"{arr[i]} : {count} "));
//            //        }
//            //    }
//            //}
//            //private static bool CheckArray(int[] arr, int current, int v)
//            //{
//            //    for (int i = 0; i < current; i++)
//            //    {
//            //        if (v == arr[i])
//            //        {
//            //            return false;
//            //        }
//            //    }
//            //    return true;
//            //}
//            //private static void Input(out int[] arr)
//            //{
//            //    Console.Write("Nhap cac phan tu trong mang : ");
//            //    var element = Console.ReadLine().Split(' ');
//            //    arr = new int[element.Length];
//            //    for (int i = 0; i < arr.Length; i++)
//            //    {
//            //        arr[i] = int.Parse(element[i]);
//            //    }
//            //}
//            #endregion
//            #region Bài 8 :
//            //    do
//            //    {
//            //        Input(out int[] arr1, out int[] arr2);
//            //        Console.Write("Nhap yes de tiep tuc : ");
//            //    }
//            //    while (Console.ReadLine().ToLower() == "yes");

//            //}
//            //private static void Input(out int[] arr1, out int[] arr2)
//            //{
//            //    Console.Write("Nhap mang 1 : ");
//            //    var element1 = Console.ReadLine().Split();
//            //    arr1 = new int[element1.Length];
//            //    for (int i = 0; i < arr1.Length; i++)
//            //    {
//            //        arr1[i] = int.Parse(element1[i]);
//            //    }
//            //    Console.Write("Nhap mang 2 : ");
//            //    var element2 = Console.ReadLine().Split();
//            //    arr2 = new int[element2.Length];
//            //    for (int i = 0; i < arr2.Length; i++)
//            //    {
//            //        arr2[i] = int.Parse(element2[i]);
//            //    }
//            //    int index = 0;
//            //    foreach (var item in arr1)
//            //    {
//            //        arr1[index++] = item;
//            //    }
//            //    Array.Resize(ref arr1, arr1.Length + arr2.Length);
//            //    foreach (var item in arr2)
//            //    {
//            //        arr1[index++] = item;
//            //    }
//            //    for (int i = 0; i < arr1.Length; i++)
//            //    {
//            //        Console.Write(arr1[i] + " ");
//            //    }
//            //    Console.WriteLine();
//            //}
//            #endregion
//            #region Bài 9 :
//            //    do
//            //    {
//            //        Input(out int[] arr1, out int[] arr2);
//            //        NewCopyArray(out int[] newarr, arr1, arr2);
//            //        ShowArray(newarr);
//            //        Console.Write("Nhap yes de tiep tuc : ");
//            //    }
//            //    while (Console.ReadLine().ToLower() == "yes");

//            //}

//            //private static void ShowArray(int[] newarr)
//            //{
//            //    foreach (var item in newarr)
//            //    {
//            //        Console.Write(item + " ");
//            //    }
//            //    Console.WriteLine();
//            //}

//            //private static void NewCopyArray(out int[] newarr, int[] arr1, int[] arr2)
//            //{
//            //    newarr = new int[arr1.Length + arr2.Length];
//            //    arr1.CopyTo(newarr, 0);
//            //    arr2.CopyTo(newarr, arr1.Length);
//            //    Array.Sort(newarr);
//            //}

//            //private static void Input(out int[] arr1, out int[] arr2)
//            //{
//            //    Console.Write("Nhap mang 1 : ");
//            //    var element1 = Console.ReadLine().Split();
//            //    arr1 = new int[element1.Length];
//            //    for (int i = 0; i < arr1.Length; i++)
//            //    {
//            //        arr1[i] = int.Parse(element1[i]);
//            //    }
//            //    Console.Write("Nhap mang 2 : ");
//            //    var element2 = Console.ReadLine().Split();
//            //    arr2 = new int[element2.Length];
//            //    for (int i = 0; i < arr2.Length; i++)
//            //    {
//            //        arr2[i] = int.Parse(element2[i]);
//            //    }
//            //}
//            #endregion
//            #region Bài 10:
//            //    do
//            //    {
//            //        Input(out string[] arr);
//            //        SortAlphabet(arr);
//            //        Console.Write("Nhap yes de tiep tuc : ");
//            //    }
//            //    while (Console.ReadLine().ToLower() == "yes");         
//            //}

//            //private static void SortAlphabet(string[] arr)
//            //{
//            //    Array.Sort(arr);
//            //    foreach (var item in arr)
//            //    {
//            //        Console.Write(item + " ");
//            //    }
//            //    Console.WriteLine();
//            //}

//            //private static void Input(out string[] arr)
//            //{
//            //    Console.Write("Nhap phan tu mang : ");
//            //    var element = Console.ReadLine().Split(' ');
//            //    arr = new string[element.Length];
//            //    for (int i = 0; i < arr.Length; i++)
//            //    {
//            //        arr[i] = element[i];
//            //    }
//            //}
//            #endregion
//            #region Bài 11:
//            //    do
//            //    {
//            //        Input(out string[] arr);
//            //        LengthSort(arr);
//            //        ShowArray(arr);
//            //        Console.Write("Ban co muon tiep tuc ? : ");                             
//            //    }
//            //    while (Console.ReadLine() == "yes");
//            //}
//            //private static void ShowArray(string[] arr)
//            //{
//            //    foreach (var item in arr)
//            //    {
//            //        Console.Write(item + " ");
//            //    }
//            //    Console.WriteLine();
//            //}

//            //private static void LengthSort(string[] arr)
//            //{
//            //    for (int i = 0; i < arr.Length - 1; i++)
//            //    {
//            //        for (int j = i + 1; j < arr.Length; j++)
//            //        {
//            //            char[] m = arr[i].ToCharArray();
//            //            char[] n = arr[j].ToCharArray();
//            //            if (m.Length > n.Length)
//            //            {
//            //                string tmp = arr[i];
//            //                arr[i] = arr[j];
//            //                arr[j] = tmp;
//            //            }
//            //        }
//            //    }
//            //}

//            //private static void Input(out string[] arr)
//            //{
//            //    Console.Write("Nhap cac phan tu mang : ");
//            //   var element = Console.ReadLine().Split(' ');
//            //    arr = new string[element.Length];
//            //    for (int i = 0; i < arr.Length; i++)
//            //    {
//            //        arr[i] = element[i];
//            //    }
//            //}
//            #endregion
//        }
//    }
//}
