using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class quicksort
    {
        static void Main()
        {
            #region Bài 1 :
            //    //int n = int.Parse(Console.ReadLine());
            //    int[] array = {1,5,0,2,3,2,4,5,9,6,7,4,8 };

            //    QuickSort(array, 0, array.Length - 1);
            //    ShowArray(array);
            //}
            //static void QuickSort(int[] array, int indexLeft, int indexRight)
            //{
            //    if (indexLeft < indexRight)
            //    {
            //        int p = Partion(array, indexLeft, indexRight);
            //        QuickSort(array, indexLeft, p - 1);
            //        QuickSort(array, p + 1, indexRight);
            //    }
            //}
            //static int Partion(int[] array, int indexLeft, int indexRight)
            //{
            //    int pivot = array[indexRight];
            //    int i = indexLeft;
            //    for (int j = indexLeft; j < indexRight; j++)
            //    {
            //        if (array[j] < pivot)
            //        {
            //            int tmp = array[i];
            //            array[i] = array[j];
            //            array[j] = tmp;
            //            i++;
            //        }
            //    }
            //    Swap(ref array[i], ref array[indexRight]);
            //    return i;
            //}
            //static void Swap(ref int a, ref int b)
            //{
            //    int tmp = a;
            //    a = b;
            //    b = tmp;
            //}
            //static void ShowArray(int[] array)
            //{
            //    foreach (var item in array)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Bài 2 :
            //    int n = int.Parse(Console.ReadLine());
            //    int[] array = new int[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap {i} ");
            //        array[i] = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine();
            //    QuickSort(array, 0, array.Length - 1);
            //    ShowArray(array);
            //}
            //static void QuickSort(int[] array, int indexLeft, int indexRight)
            //{
            //    if (indexLeft < indexRight)
            //    {
            //        int p = Partion(array, indexLeft, indexRight);
            //        QuickSort(array, indexLeft, p - 1);
            //        QuickSort(array, p + 1, indexRight);
            //    }
            //}
            //static int Partion(int[] array, int indexLeft, int indexRight)
            //{
            //    int pivot = array[indexRight];
            //    int i = indexLeft;
            //    for (int j = indexLeft; j < indexRight; j++)
            //    {
            //        if (array[j] > pivot)
            //        {
            //            int tmp = array[i];
            //            array[i] = array[j];
            //            array[j] = tmp;
            //            i++;
            //        }
            //    }
            //    Swap(ref array[i], ref array[indexRight]);
            //    return i;
            //}
            //static void Swap(ref int a, ref int b)
            //{
            //    int tmp = a;
            //    a = b;
            //    b = tmp;
            //}
            //static void ShowArray(int[] array)
            //{
            //    foreach (var item in array)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();

            //}
            #endregion
            #region Bài 3 :
            //    int n = int.Parse(Console.ReadLine());
            //    string[] array = new string[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap {i} ");
            //        array[i] = Console.ReadLine();
            //    }
            //    Console.WriteLine();
            //    QuickSort(array, 0, array.Length - 1);
            //    ShowArray(array);
            //}
            //static void QuickSort(string[] array, int indexLeft, int indexRight)
            //{
            //    if (indexLeft < indexRight)
            //    {
            //        int p = Partion(array, indexLeft, indexRight);
            //        QuickSort(array, indexLeft, p - 1);
            //        QuickSort(array, p + 1, indexRight);
            //    }
            //}
            //static int Partion(string[] array, int indexLeft, int indexRight)
            //{
            //    string pivot = array[indexRight];
            //    int i = indexLeft;
            //    for (int j = indexLeft; j < indexRight; j++)
            //    {               
            //        if (array[j].CompareTo(pivot) < 0) // Phương thức so sánh 2 chuỗi string string a.ComapareTo(string b) 
            //        {
            //            string tmp = array[i];
            //            array[i] = array[j];
            //            array[j] = tmp;
            //            i++;
            //        }
            //    }
            //    Swap(ref array[i], ref array[indexRight]);
            //    return i;
            //}
            //static void Swap(ref string a, ref string b)
            //{
            //    string tmp = a;
            //    a = b;
            //    b = tmp;
            //}
            //static void ShowArray(string[] array)
            //{
            //    foreach (var item in array)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Bài 4 :
            //    int n = int.Parse(Console.ReadLine());
            //    string[] array = new string[n];
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap {i} ");
            //        array[i] = Console.ReadLine();
            //    }
            //    Console.WriteLine();
            //    QuickSort(array, 0, array.Length - 1);
            //    ShowArray(array);
            //}
            //static void QuickSort(string[] array, int indexLeft, int indexRight)
            //{
            //    if (indexLeft < indexRight)
            //    {
            //        int p = Partion(array, indexLeft, indexRight);
            //        QuickSort(array, indexLeft, p - 1);
            //        QuickSort(array, p + 1, indexRight);
            //    }
            //}
            //static int Partion(string[] array, int indexLeft, int indexRight)
            //{
            //    string pivot = array[indexRight];
            //    int i = indexLeft;
            //    for (int j = indexLeft; j < indexRight; j++)
            //    {
            //        if (array[j].CompareTo(pivot) > 0) 
            //        {
            //            string tmp = array[i];
            //            array[i] = array[j];
            //            array[j] = tmp;
            //            i++;
            //        }
            //    }
            //    Swap(ref array[i], ref array[indexRight]);
            //    return i;
            //}
            //static void Swap(ref string a, ref string b)
            //{
            //    string tmp = a;
            //    a = b;
            //    b = tmp;
            //}
            //static void ShowArray(string[] array)
            //{
            //    foreach (var item in array)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Bài 5 :
            //    int n = int.Parse(Console.ReadLine());
            //    int[] array = new int[n];
            //    int k = (array.Length - 1) / 2;
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write($"Nhap {i} ");
            //        array[i] = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine();
            //    QuickSort(array, 0, k);
            //    QuickSortReverese(array, k + 1, array.Length - 1);
            //    ShowArray(array);
            //}
            //static void QuickSortReverese(int[] array, int indexLeft, int indexRight)
            //{
            //    if (indexLeft < indexRight)
            //    {
            //        int p = PartionReverse(array, indexLeft, indexRight);
            //        QuickSortReverese(array, indexLeft, p - 1);
            //        QuickSortReverese(array, p + 1, indexRight);
            //    }
            //}
            //static void QuickSort(int[] array, int indexLeft, int indexRight)
            //{
            //    if (indexLeft < indexRight)
            //    {
            //        int p = Partion(array, indexLeft, indexRight);
            //        QuickSort(array, indexLeft, p - 1);
            //        QuickSort(array, p + 1, indexRight);
            //    }
            //}
            //static int PartionReverse(int[] array, int indexLeft, int indexRight)
            //{
            //    int pivot = array[indexRight];
            //    int i = indexLeft;
            //    for (int j = indexLeft; j < indexRight; j++)
            //    {
            //        if (array[j] > pivot)
            //        {
            //            int tmp = array[i];
            //            array[i] = array[j];
            //            array[j] = tmp;
            //            i++;
            //        }
            //    }
            //    Swap(ref array[i], ref array[indexRight]);
            //    return i;
            //}
            //static int Partion(int[] array, int indexLeft, int indexRight)
            //{
            //    int pivot = array[indexRight];
            //    int i = indexLeft;
            //    for (int j = indexLeft; j < indexRight; j++)
            //    {
            //        if (array[j] < pivot)
            //        {
            //            int tmp = array[i];
            //            array[i] = array[j];
            //            array[j] = tmp;
            //            i++;
            //        }
            //    }
            //    Swap(ref array[i], ref array[indexRight]);
            //    return i;
            //}
            //static void Swap(ref int a, ref int b)
            //{
            //    int tmp = a;
            //    a = b;
            //    b = tmp;
            //}
            //static void ShowArray(int[] array)
            //{
            //    foreach (var item in array)
            //    {
            //        Console.Write(item + " ");
            //    }
            //    Console.WriteLine();
            //}
            #endregion
        }
    }
}
