using System;
using System.Linq;
using System.Collections.Concurrent;
using System.Text;
using System.Threading.Tasks;

//1. Написать метод, возвращающий минимальное из трех чисел.
namespace Zhiganov
{
    partial class Program
    {
        public static int Min (int n1, int n2, int n3)
        {
            int minimum = 0;
            if ((n1 <= n2) && (n1 <= n3))
            {
                minimum = n1;
            }
            else if (n2 <= n3)
            {
                minimum = n2;
            }
            else minimum = n3;
            return minimum;

        }
        static void  Task1()
        {
            Console.WriteLine("Input first number");
            int fn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input second number");
            int sn = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Input third number");
            int tn = Convert.ToInt32(Console.ReadLine());
            int min = Min(fn, sn, tn);
            Console.WriteLine($"Minimum number is {min}");

            
        }



    }


}