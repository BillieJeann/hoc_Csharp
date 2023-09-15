using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace abc
{
    internal class luyenmethod
    {
        static void Main(string[] args)
        {
            Console.Write("Nhap gioi han : "); 
            int bound = int.Parse(Console.ReadLine());
            Console.WriteLine();
            for (int i = 1; i < bound; i++)
            {
                Console.Write("Nhap so nguyen : ");                
                int integer = int.Parse(Console.ReadLine());               
                Console.Write($"Test {i} : ");
                evenNumber(integer);
                Console.WriteLine();
            }
        }
        static int evenNumber(int value)
        {
            int v = 0;
            for (int j = 1; j <= value; j++)
            {
                if (j % 2 == 0)
                {
                    v = j;
                    Console.Write(" " + v );                   
                }
            }
            Console.WriteLine();
            return v = value;
        }       
    }
}
