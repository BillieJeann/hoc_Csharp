using System;

namespace abc
{
    internal class _2dimArray
    {
        static void Main(string[] args)
        {
            #region Bài 1 :
            //int n = int.Parse(Console.ReadLine());
            //int m = int.Parse(Console.ReadLine());
            //if (m < 0 || n < 0)
            //{
            //    Console.WriteLine("Invalid");
            //}
            //else
            //{
            //    int[,] array = new int[n, m];

            //    Console.WriteLine($"Tong so phan tu: {array.Length}");
            //    for (int i = 0; i < array.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < array.GetLength(1); j++)
            //        {
            //            Console.Write($"Hang {i} , cot{j}: ");
            //            array[i, j] = int.Parse(Console.ReadLine());
            //        }
            //        Console.WriteLine();
            //    }
            //    for (int i = 0; i < array.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < array.GetLength(1); j++)
            //        {
            //            Console.Write(array[i, j] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //}            
            #endregion
            #region Bài 2 :
            //Console.Write("Nhap so hang : ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("Nhap so cot : ");
            //int m = int.Parse(Console.ReadLine());
            //if (m < 0 || n < 0)
            //{
            //    Console.WriteLine("Invalid");
            //}
            //else
            //{
            //    int[,] array = new int[n, m];

            //    for (int i = 0; i < array.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < array.GetLength(1); j++)
            //        {
            //            Console.Write($"Nhap phan tu {i},{j} : ");
            //            array[i, j] = int.Parse(Console.ReadLine());                     
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine("Ma tran goc la :");
            //    for (int i = 0; i < array.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < array.GetLength(1); j++)
            //        {
            //            Console.Write(array[i,j] + " ");
            //        }
            //        Console.WriteLine();
            //    }                                            
            //    Console.WriteLine("Ma tran chuyen vi la : ");
            //    for (int i = 0; i < array.GetLength(1) ; i++)
            //    {
            //        for (int j = 0; j <array.GetLength(0); j++)
            //        {

            //            Console.Write(array[j, i] + " ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Bài 3 :
            //Console.Write("Nhap so hang cua mang 1 : ");
            //int m = int.Parse(Console.ReadLine());
            //Console.Write("Nhap so cot cua mang 1 : ");
            //int n = int.Parse(Console.ReadLine());
            //Console.Write("Nhap so hang cua mang 2 : ");
            //int l = int.Parse(Console.ReadLine());
            //Console.Write("Nhap so cot cua mang 2 : ");
            //int k = int.Parse(Console.ReadLine());
            //int[,] array1 = new int[m, n];
            //int[,] array2 = new int[l, k];
            //Console.WriteLine();
            //Console.WriteLine("Nhap phan tu cua mang 1 :");
            //for (int i = 0; i < array1.GetLength(0) ; i++)
            //{
            //    for (int j = 0; j < array1.GetLength(1); j++)
            //    {
            //        Console.Write($"Nhap phan tu {i} , {j} : ");
            //        array1[i,j] = int.Parse(Console.ReadLine()) ;
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Nhap phan tu cua mang 2 :");
            //for (int i = 0; i < array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        Console.Write($"Nhap phan tu {i} , {j} : ");
            //        array2[i, j] = int.Parse(Console.ReadLine());
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Mang 1 la : ");
            //for (int i = 0; i < array1.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array1.GetLength(1); j++)
            //    {
            //        Console.Write(array1[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine("Mang 2 la : ");
            //for (int i = 0; i < array2.GetLength(0); i++)
            //{
            //    for (int j = 0; j < array2.GetLength(1); j++)
            //    {
            //        Console.Write(array2[i, j] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //int[,] newArray = new int[m, n];
            //for (int i = 0; i < newArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < newArray.GetLength(1); j++)
            //    {
            //        newArray[i, j] = array1[i, j] + array2[i, j];
            //    }               
            //}
            //Console.WriteLine("Tong cua mang 1 va mang 2 la : ");
            //for (int i = 0; i < newArray.GetLength(0); i++)
            //{
            //    for (int j = 0; j < newArray.GetLength(1); j++)
            //    {
            //        Console.Write(newArray[i, j] + " ");

            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Bài 4 :
            //int[,] cross = new int[9, 13];
            //for (int i = 0; i < cross.GetLength(0); i++)
            //{
            //    for (int j = 0; j < cross.GetLength(1); j++)
            //    {
            //        if ((i == 0 && j > 3 && j < 8) || (i == 8 && j > 3 && j < 8 )||
            //            (i < 4 && j == 4)||(i < 4 && j == 7)||( i == 3 && j != 5 && j != 6)||
            //            ( i == 5 && j != 5 && j!= 6)||( i == 4 && j == 0)||(i == 4 && j == 12)||
            //            ( i > 5 && i < 8 && j == 4) || (i > 5 && i < 8 && j == 7))
            //        {
            //            Console.Write(" * ");
            //        }
            //        else
            //        {
            //            Console.Write("   ");
            //        }                   
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Bài 5 :
            //Console.Write("Nhap hang m : ");
            //int m = int.Parse(Console.ReadLine());
            //Console.Write("Nhap cot n : ");
            //int n = int.Parse(Console.ReadLine());           
            //if (n <= 0 || m <= 0)
            //{
            //    Console.WriteLine("ERROR");
            //}
            //else
            //{
            //    int[,] recktangle = new int[m, n];
            //    Console.WriteLine();
            //    for (int i = 0; i < recktangle.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < recktangle.GetLength(1); j++)
            //        {
            //            Console.Write(" * ");
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Bài 6 :
            //Console.Write("Nhap hang m : ");
            //int m = int.Parse(Console.ReadLine());
            //Console.Write("Nhap cot n : ");
            //int n = int.Parse(Console.ReadLine());
            //if (n <= 0 || m <= 0)
            //{
            //    Console.WriteLine("ERROR");
            //}
            //else
            //{
            //    int[,] recktangle = new int[m, n];
            //    Console.WriteLine();
            //    for (int i = 0; i < recktangle.GetLength(0); i++)
            //    {
            //        for (int j = 0; j < recktangle.GetLength(1); j++)
            //        {
            //            if (i > 0 && j == 0 || i > 0 && j == n - 1 || i < m - 1 && j == 0 || i < m - 1 && j == n - 1 || i == 0 || i == m - 1)
            //            {
            //                Console.Write(" * ");
            //            }
            //            else
            //            {
            //                Console.Write("   ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //    Console.WriteLine();
            //}
            #endregion
            #region Bài 7 :
            //Console.Write("Nhap so h : ");
            //int h = int.Parse(Console.ReadLine());
            //if (h <= 0)
            //{
            //    Console.Write("Invalid");
            //}
            //else
            //{
            //    for (int i = 0; i < h; i++)
            //    {
            //        for (int j = 0; j < h; j++)
            //        {
            //            if (i >= j)
            //            {
            //                Console.Write(" * ");
            //            }
            //            else
            //            {
            //                Console.Write("   ");
            //            }
            //        }
            //        Console.WriteLine();
            //    }
            //}
            //Console.WriteLine();
            #endregion

        }
    }
}
