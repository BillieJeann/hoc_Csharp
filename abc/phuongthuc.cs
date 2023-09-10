using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhuongThuc
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int t = int.Parse(Console.ReadLine());

            for (int i = 1; i < t; i++) 
            {
                int n = int.Parse(Console.ReadLine());
                if ( IsPerfectNumber(n) )
                {
                    Console.WriteLine($"Test {i}: YES");
                }
                else
                {
                    Console.WriteLine($"Test {i}: NO");
                }
            
            }
        }
        static bool IsPerfectNumber( int number ) 
        {
            int sum = 0;

            for (int k = 1; k < number; k++) 
            {
                if ( number % k == 0 )
                {
                    sum += k;
                }
            }
            return sum == number;
        }
        

    }
}
