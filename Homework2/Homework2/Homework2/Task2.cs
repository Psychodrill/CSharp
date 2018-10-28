using System;
//2. Написать метод подсчета количества цифр числа.

namespace Zhiganov
{
    partial class Program
    {
        public static int CalcDigits(int a)
        {
            int digits = 0;
            do
            { a = a/ 10;
                digits++;

            } while ( a > 1);
            return digits;

        }
        static void Task2()
        {
            Console.WriteLine("Input some digits number ");
            int sn = Convert.ToInt32(Console.ReadLine());
            int digitcount = CalcDigits(sn);

            Console.WriteLine($"Count of digits is {digitcount}");

        }

    }
    
}