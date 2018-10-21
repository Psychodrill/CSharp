using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//2. а) С клавиатуры вводятся числа, пока не будет введен 0 (каждое число в новой строке).
//Требуется подсчитать сумму всех нечетных положительных чисел.Сами числа и сумму вывести на экран, используя tryParse;
//б) Добавить обработку исключительных ситуаций на то, что могут быть введены некорректные данные.При возникновении ошибки вывести сообщение.
//Напишите соответствующую функцию;
namespace Zhiganov
{
    partial class Program
    {
        static void Task2()
        {
            double number = 0;
            double sum = 0;
            bool flag;

            do
            {

                flag = double.TryParse(Console.ReadLine(),out number);
                if (flag == false)
                {
                    Console.WriteLine("Repeat input");
                }
                else
               Console.WriteLine("Input some numbers and in end input zero");
                number = Convert.ToDouble(Console.ReadLine());
                if ((number >= 0) && (number % 2 == 1))
                {
                    sum += number;
                }
            } while (number != 0);
            Console.WriteLine($"Positive odd numbers sum is {sum}");

        }


    }


}