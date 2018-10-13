using System;
//4. Написать программу обмена значениями двух переменных.
//а) с использованием третьей переменной;
//б) * без использования третьей переменной.

namespace Zhiganov
{

    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hi! In this program variables interchanges values.");
            Console.WriteLine("Input X");
            double x = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Y");
            double y = Convert.ToDouble(Console.ReadLine());
            //double z = x;
            //x = y;
            //y = z;
            x = x + y;
            y = x - y;
            x = x - y;
            Console.WriteLine($"Now  X value: {x:f1}, and Y value {y:f1}");
            Console.ReadKey();

        }
    }
}