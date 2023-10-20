using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Chương_5
{
    internal class BTLambda
    {
        static void Main(string[] args)
        {
            #region Bài 1 :
            //    Input(out int[] arr);
            //    int x = int.Parse(Console.ReadLine());
            //    var findX = () =>
            //    {
            //        foreach (var item in arr)
            //        {
            //            if (x == item)
            //            {
            //                return true;
            //            }
            //        }
            //        return false;
            //    };            
            //    if (findX())
            //    {
            //        Console.Write("Yes");
            //        Console.WriteLine();
            //    }
            //    else
            //    {
            //        Console.Write("No");
            //        Console.WriteLine();
            //    }

            //}
            //static void Input(out int[] arr)
            //{
            //    var element = Console.ReadLine().Split(' ');
            //    arr = new int[element.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = int.Parse(element[i]);
            //    }
            //}
            #endregion
            #region Bài 2 :
            //    Input(out int[] arr);
            //    int x = int.Parse(Console.ReadLine());
            //    int y = int.Parse(Console.ReadLine());
            //    var findXY = () =>
            //    {
            //        int count = 0;
            //        foreach (var item in arr)
            //        {
            //            if (item >= x && item <= y)
            //            {
            //                count++;
            //            }
            //        }
            //        return count;
            //    };
            //    Console.Write(findXY());
            //    Console.WriteLine();
            //}
            //private static void Input(out int[] arr)
            //{
            //  var element = Console.ReadLine().Split(' ');
            //    arr = new int[element.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = int.Parse(element[i]);
            //    }
            //}
            #endregion
            #region Bài 3 :
            //    Input(out int[] arr);
            //    int x = int.Parse(Console.ReadLine());
            //    int count = 0;
            //    var countValue = () =>
            //    {
            //        foreach (var item in arr)
            //        {
            //            if (x == item)
            //            {
            //                count++;
            //            }                   
            //        }
            //        return count;
            //    };
            //    Console.Write(countValue());
            //    Console.WriteLine();
            //}
            //private static void Input(out int[] arr)
            //{
            //   var element = Console.ReadLine().Split(' ');
            //    arr = new int[element.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = int.Parse(element[i]);
            //    }
            //}
            #endregion
            #region Bài 4 :
            //    Input(out int[] arr);
            //    int x = int.Parse(Console.ReadLine());
            //    var lastIndex = () =>
            //    {
            //        int count = 0;
            //        for (int i = arr.Length - 1; i > 0; i--)
            //        {
            //            if (arr[i] == x)
            //            {
            //                count = i; break;
            //            }                    
            //        }
            //        return count;
            //    };
            //    Console.Write(lastIndex());
            //    Console.WriteLine();
            //}

            //private static void Input(out int[] arr)
            //{
            //    var element = Console.ReadLine().Split(' ');
            //    arr = new int[element.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = int.Parse(element[i]);
            //    }
            //}
            #endregion
            #region  Bài 5 :
            //    Input(out int[] arr);
            //    FindFirstandLast(arr);
            //}
            //private static void FindFirstandLast(int[] arr)
            //{
            //    int x = int.Parse(Console.ReadLine());
            //    var first = () =>
            //    {
            //        return Array.IndexOf(arr, x);
            //    };
            //    Console.Write(first() + " ");
            //    var last = () =>
            //    {
            //        return Array.LastIndexOf(arr, x);
            //    };
            //    Console.Write(last());
            //    Console.WriteLine();
            //}
            //private static void Input(out int[] arr)
            //{
            //    var element = Console.ReadLine().Split(' ');
            //    arr = new int[element.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = int.Parse(element[i]);
            //    }
            //}
            #endregion
            #region Bài 6 :
            //    Input(out char[] arr);
            //    CountCharacter(arr);
            //}
            //private static void CountCharacter(char[] arr)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        int count = 1;
            //        for (int j = i + 1; j < arr.Length; j++)
            //        {
            //            if (arr[i] == arr[j])
            //            {
            //                count++;
            //            }
            //        }
            //        var element = () =>
            //        {
            //            int current = i;
            //            int v = arr[i];
            //            for (int index = 0; index < current; index++)
            //            {
            //                if (arr[index] == v)
            //                {
            //                    return false;
            //                }
            //            }
            //            return true;
            //        };
            //        if (element())
            //        {
            //            Console.WriteLine(arr[i] + " " + count);
            //        }
            //    }
            //}
            //private static void Input(out char[] arr)
            //{
            //    var element = Console.ReadLine();
            //    arr = new char[element.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = element[i];
            //    }
            //}
            #endregion
            #region Bài 7 :
            //    Input(out int[] arr, out int x);            
            //    var Nearest = () =>
            //    {
            //        int min = Math.Abs(x - arr[0]);
            //        for (int i = 1; i < arr.Length; i++)
            //        {
            //            int tmp = Math.Abs(x - arr[i]);
            //            if (tmp < min)
            //            {
            //                min = tmp;
            //            }
            //        }
            //        for (int i = 0; i < arr.Length; i++)
            //        {
            //            int tmp = Math.Abs(x - arr[i]);
            //            if (tmp == min)
            //            {
            //                Console.Write((arr[i], i));
            //            }
            //        }
            //        Console.WriteLine();
            //    };
            //    Nearest();
            //    var Furthest = () =>
            //    {
            //        int max = Math.Abs(x - arr[0]);
            //        for (int i = 1; i < arr.Length; i++)
            //        {
            //            int tmp = Math.Abs(x - arr[i]);
            //            if (tmp > max)
            //            {
            //                max = tmp;
            //            }
            //        }
            //        for (int i = 0; i < arr.Length; i++)
            //        {
            //            int tmp = Math.Abs(x - arr[i]);
            //            if (tmp == max)
            //            {
            //                Console.Write((arr[i], i));
            //            }
            //        }
            //        Console.WriteLine();
            //    };
            //    Furthest();
            //}
            //private static void Input(out int[] arr, out int x)
            //{
            //    var element = Console.ReadLine().Split(' ');
            //    arr = new int[element.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = int.Parse(element[i]);
            //    }
            //    x = int.Parse(Console.ReadLine());
            //    Array.Sort(arr);
            //}
            #endregion
            #region Bài 8 :
            //    Input(out int[] arr);
            //    var LongestRun = () =>
            //    {
            //        int currentLength = 1;
            //        int maxLength = 1;
            //        int endIndex = 0;
            //        for (int i = 1; i < arr.Length; i++)
            //        {
            //            if (arr[i] > arr[i - 1])
            //            {
            //                currentLength++;
            //            }
            //            else
            //            {
            //                if (currentLength > maxLength)
            //                {
            //                    maxLength = currentLength;
            //                    endIndex = i - 1;   
            //                }
            //                currentLength = 1;
            //            }                  
            //        }
            //        if (currentLength > maxLength)
            //        {
            //            maxLength = currentLength;
            //            endIndex = arr.Length - 1;
            //        }
            //        if (maxLength > 1)
            //        {
            //            for (int i = endIndex - maxLength + 1; i <= endIndex; i++)
            //            {
            //                Console.Write(arr[i] + " ");
            //            }
            //            Console.WriteLine();
            //        }
            //        return maxLength;
            //    };       
            //    LongestRun();
            //}

            //private static void Input(out int[] arr)
            //{
            //    Console.Write("Nhap cac phan tu cua mang : ");
            //    var element = Console.ReadLine().Split(' ');
            //    arr = new int[element.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = int.Parse(element[i]);
            //    }
            //}
            #endregion
            #region Bài 9 :
            //    Input(out int[] arr);
            //    PrimeNumb(arr);
            //}
            //private static void PrimeNumb(int[] arr)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        var CheckPrime = () =>
            //        {
            //            if (arr[i] <= 1)
            //            {
            //                return false;
            //            }
            //            for (int j = 2; j <= Math.Sqrt(arr[i]); j++)
            //            {
            //                if (arr[i] % j == 0)
            //                {
            //                    return false;
            //                }
            //            }
            //            return true;
            //        };
            //        if (CheckPrime())
            //        {
            //            Console.Write((i, arr[i]));
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //private static void Input(out int[] arr)
            //{
            //    Console.Write("Nhap cac phan tu cua mang : ");
            //    var element = Console.ReadLine().Split(' ');
            //    arr = new int[element.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = int.Parse(element[i]);
            //    }
            //}
            #endregion
            #region Bài 10:
            //    Input(out int[] arr);
            //    SoChinhPhuong(arr);
            //}
            //private static void SoChinhPhuong(int[] arr)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        var CheckCP = () =>
            //        {
            //            double tmp = Math.Sqrt(arr[i]);
            //            if (tmp * tmp == arr[i])
            //            {
            //                return true;
            //            }
            //            return false;
            //        };
            //        if (CheckCP())
            //        {
            //            Console.Write((i , arr[i]));
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //private static void Input(out int[] arr)
            //{
            //    Console.Write("Nhap cac phan tu cua mang : ");
            //    var element = Console.ReadLine().Split(' ');
            //    arr = new int[element.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = int.Parse(element[i]);
            //    }
            //}
            #endregion
            #region Bài 11:
            //    Input(out int[] arr);
            //    Semetry(arr);
            //}

            //private static void Semetry(int[] arr)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        int a = Math.Abs(arr[i]);
            //        int c = 0;
            //        var CheckSem = () =>
            //        {
            //            if (Math.Abs(arr[i]) < 10)
            //            {
            //                return false;
            //            }
            //            else
            //            {
            //                while (a > 0)
            //                {
            //                    int tmp = Math.Abs(a % 10);
            //                    c = c * 10 + tmp;
            //                    a /= 10;

            //                }
            //                if (c != Math.Abs(arr[i]))
            //                {
            //                    return false;
            //                }
            //                return true;
            //            }
            //        };
            //        if (CheckSem())
            //        {
            //            Console.Write(arr[i] + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //}

            //private static void Input(out int[] arr)
            //{
            //    Console.Write("Nhap cac phan tu cua mang : ");
            //    var element = Console.ReadLine().Split(' ');
            //    arr = new int[element.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = int.Parse(element[i]);
            //    }
            //}
            #endregion
            #region Bài 12:
            //    Input(out int[] arr);
            //    FindMin(arr);
            //    FindMax(arr);
            //}
            //private static void FindMin(int[] arr)
            //{
            //    int min = arr[0];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        var checkMin = () =>
            //        {
            //            if (arr[i] > min)
            //            {
            //                return false;
            //            }
            //            return true;
            //        };
            //        if (checkMin())
            //        {
            //            min = arr[i];
            //        }
            //    }
            //    Console.Write($"Gia tri min la : {min} ");
            //    Console.WriteLine();
            //}
            //private static void FindMax(int[] arr)
            //{
            //    int max = arr[0];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        var checkMax = () =>
            //        {
            //            if (arr[i] < max)
            //            {
            //                return false;
            //            }
            //            return true;
            //        };
            //        if (checkMax())
            //        {
            //            max = arr[i];
            //        }
            //    }
            //    Console.Write($"Gia tri max la : {max} ");
            //    Console.WriteLine();
            //}
            //private static void Input(out int[] arr)
            //{
            //    Console.Write("Nhap cac phan tu cua mang : ");
            //    var element = Console.ReadLine().Split(' ');
            //    arr = new int[element.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = int.Parse(element[i]);
            //    }
            //}
            #endregion
            #region Bài 13:
            //    Input(out int[] arr);
            //    Array.Sort(arr);
            //    int min = FindMin(arr);
            //    int max = FindMax(arr);
            //    int scdMin = 0;
            //    int scdMax = 0;
            //    for (int i = 1; i < arr.Length; i++)
            //    {
            //        var check = () =>
            //        {
            //            if (arr[i] > min)
            //            {
            //                return true;
            //            }
            //            return false;
            //        };
            //        if (check())
            //        {
            //            scdMin = arr[i];
            //            break;
            //        }
            //    }
            //    Console.Write(scdMin + " ");
            //    for (int i = arr.Length - 1; i > 0 ; i--)
            //    {
            //        var check = () =>
            //        {
            //            if (arr[i] < max)
            //            {
            //                return true;
            //            }
            //            return false;
            //        };
            //        if (check())
            //        {
            //            scdMax = arr[i];
            //            break;
            //        }
            //    }
            //    Console.Write(scdMax + " ");
            //    Console.WriteLine();
            //}
            //private static int FindMin(int[] arr)
            //{
            //    int min = arr[0];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        var checkMin = () =>
            //        {
            //            if (arr[i] > min)
            //            {
            //                return false;
            //            }
            //            return true;
            //        };
            //        if (checkMin())
            //        {
            //            min = arr[i];
            //        }
            //    }
            //    return min;
            //}
            //private static int FindMax(int[] arr)
            //{
            //    int max = arr[0];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        var checkMax = () =>
            //        {
            //            if (arr[i] < max)
            //            {
            //                return false;
            //            }
            //            return true;
            //        };
            //        if (checkMax())
            //        {
            //            max = arr[i];
            //        }
            //    }
            //    return max;
            //}
            //private static void Input(out int[] arr)
            //{
            //    Console.Write("Nhap cac phan tu cua mang : ");
            //    var element = Console.ReadLine().Split(' ');
            //    arr = new int[element.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = int.Parse(element[i]);
            //    }
            //}
            #endregion
            #region Bài 14:
            //    Input(out int[] arr);
            //    ShowArray(arr);           
            //}
            //private static void ShowArray(int[] arr)
            //{
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        var check = () =>
            //        {
            //            for (int j = 0; j < i; j++)
            //            {
            //                if (arr[i] == arr[j])
            //                {
            //                    return false;
            //                }
            //            }
            //            return true;
            //        };
            //        if (check())
            //        {
            //            Console.Write(arr[i] + " ");
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //private static void Input(out int[] arr)
            //{
            //    Console.Write("Nhap cac phan tu cua mang : ");
            //   var element = Console.ReadLine().Split(' ');
            //    arr = new int[element.Length];
            //    for (int i = 0; i < arr.Length; i++)
            //    {
            //        arr[i] = int.Parse(element[i]);
            //    }
            //}
            #endregion
            #region Bài 15:
            //    Input(out int[] arr1, out int[] arr2);
            //    GetNewArray(arr1,arr2);
            //}
            //private static void GetNewArray(int[] arr1, int[] arr2)
            //{
            //    int[] newArr = new int[arr1.Length + arr2.Length];
            //    int index = 0;
            //    var combine = () =>
            //    {
            //        foreach (var item in arr1)
            //        {
            //            newArr[index++] = item;
            //        }
            //        foreach (var item in arr2)
            //        {
            //            newArr[index++] = item;
            //        }
            //    };
            //    combine();
            //    for (int i = 0; i < newArr.Length; i++)
            //    {
            //        for (int j = i + 1; j < newArr.Length; j++)
            //        {
            //            var check = () =>
            //            {
            //                if (newArr[i] < newArr[j])
            //                {
            //                    return false;
            //                }
            //                return true;
            //            };
            //            if(check())
            //            {
            //                int tmp = newArr[i];
            //                newArr[i] = newArr[j];
            //                newArr[j] = tmp;
            //            }
            //        }
            //        Console.Write(newArr[i] + " ");
            //    }
            //    Console.WriteLine();
            //}
            //private static void Input(out int[] arr1, out int[] arr2)
            //{
            //    var element = Console.ReadLine().Split(' ');
            //    arr1 = new int[element.Length];
            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        arr1[i] = int.Parse(element[i]);
            //    }
            //    var element2 = Console.ReadLine().Split(' ');
            //    arr2 = new int[element2.Length];
            //    for (int i = 0; i < arr2.Length; i++)
            //    {
            //        arr2[i] = int.Parse(element2[i]);   
            //    }
            //}
            #endregion
            #region Bài 16:
            //    Input(out string[] arr1, out string[] arr2);
            //    string[] newArr = CombineArray(arr1, arr2);
            //    ShowArray(newArr);          
            //}
            //private static void ShowArray(string[] newArr)
            //{
            //    for (int i = 0; i < newArr.Length; i++)
            //    {
            //        for (int j = i + 1; j < newArr.Length; j++)
            //        {
            //            var check = () =>
            //            {
            //                if (newArr[i].ToLower() != newArr[j].ToLower())
            //                {
            //                    return false;
            //                }
            //                return true;
            //            };
            //            if (check())
            //            {
            //                Console.Write(newArr[i] + " ");
            //            }
            //        }
            //    }
            //    Console.WriteLine();
            //}
            //private static string[] CombineArray(string[] arr1, string[] arr2)
            //{
            //    string[] newArr = new string[arr1.Length + arr2.Length];
            //    int index = 0;
            //    foreach (var item in arr1)
            //    {
            //        newArr[index++] = item;
            //    }
            //    foreach (var item in arr2)
            //    {
            //        newArr[index++] = item;
            //    }
            //    return newArr;
            //}
            //private static void Input(out string[] arr1, out string[] arr2)
            //{
            //    Console.Write("Nhap cac phan tu mang 1 : ");
            //    var element = Console.ReadLine().Split(' ');
            //    arr1 = new string[element.Length];
            //    for (int i = 0; i < arr1.Length; i++)
            //    {
            //        arr1[i] = element[i];
            //    }
            //    Console.Write("Nhap cac phan tu mang 2 : ");
            //    var element2 = Console.ReadLine().Split(' ');
            //    arr2 = new string[element2.Length];
            //    for (int i = 0; i < arr2.Length; i++)
            //    {
            //        arr2[i] = element2[i];
            //    }
            //}
            #endregion
        }
    }
}
