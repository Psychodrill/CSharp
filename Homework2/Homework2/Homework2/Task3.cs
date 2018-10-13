using System;
//3. С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.

namespace Zhiganov
{
    partial class Program
    {

        static void Task3()
        {
            double number = 0;
            double sum = 0;
            do
            {
                Console.WriteLine("Input some numbers and in end input zero");
                number = Convert.ToDouble(Console.ReadLine());
                if ((number >= 0)&&(number % 2 == 1)){
                    sum += number;
                }
            } while (number !=0);
            Console.WriteLine($"Positive odd numbers sum is {sum}");

        }

    }

}