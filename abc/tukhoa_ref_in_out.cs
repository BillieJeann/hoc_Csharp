using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace abc
{
    internal class tukhoa_ref_in_out
    {
        #region Định nghĩa :
        // Keyword ref : Cho phép phương thức thay đổi giá trị của đối số 
        // Keyword in : Cho phép truyền tham chiếu nhưng không cho phép phương thức thay đổi giá trị của đối số
        // Keyword out : Cho phép truyền tham chiếu trong đó phương thức được gọi phải gán giá trị mới cho đối số
        #endregion
    static void Main(string[] args)
    {
      // Bài tập
      #region Bài 5 :
            Input(out int a, out int b, out int c);
            FindMax(out int Max , a ,b , c);
            FindMin(out int Min , a ,b , c);  
            FindAvrSum(out int avrSum , a , b , c);
            FindscnMaxandMin(out int scdMax, out int scdMin , a , b , c);
            Message(Max, Min, avrSum,scdMax, scdMin);                       
    }
    static void Input(out int a, out int b, out int c)
        {
            a = int.Parse(Console.ReadLine());
            b = int.Parse(Console.ReadLine());
            c = int.Parse(Console.ReadLine());
        }
    static void FindMax(out int Max, int a, int b, int c)
        {
            if (a > b)
            {
                Max = a;
            }
            else if ( b > c)
            {
                Max = b;
            }
            else
            {
                Max = c;
            }            
        }
    static void FindMin(out int min , int a , int b, int c)
        {
            if (a < b)
            {
                min = a ;
            }
            else if (b < c)
            {
                min =  b ;
            }
            else
            {
                min = c;
            }
        }
    static void FindAvrSum(out int avrSum, int a, int b, int c)
        {
            avrSum = (a + b + c) / 3 ;
        }
    static void FindscnMaxandMin(out int scdMax, out int scdMin ,int a, int b, int c)
        {
            scdMax = 0;
            scdMin = 0;
            if(a > b && a < c)
            {
                scdMax = a;
                scdMin = a;
            }
            if (b > a && b < c)
            {
                scdMax = b;
                scdMin = b;
            }
            if (c > a && c < b)
            {
                scdMax = c;
                scdMin = c;
            }
        }
    static void Message(in int message1 , in int message2, in int message3, in int message4, in int message5)
        {
            Console.Write($"Gia tri Max la : {message1}");
            Console.WriteLine();
            Console.Write($"Gia tri Min la : {message2}");
            Console.WriteLine();
            Console.Write($"Trung binh cong la : {message3}");
            Console.WriteLine();
            Console.Write($"So lon thu 2 la : {message4}");
            Console.WriteLine();
            Console.Write($"So nho thu 2 la : {message5}");
            Console.WriteLine();
        }
        #endregion

      
    }

}




