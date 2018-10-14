using System;
//3.
//а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 по формуле r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2).Вывести результат, используя спецификатор формата .2f(с двумя знаками после запятой);
//б) * Выполните предыдущее задание, оформив вычисления расстояния между точками в виде метода;
namespace Zhiganov
{
    class Program
    {
        static double Calc(double x1, double y1, double x2, double y2)
        {
            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
            return r;
        }
         static void Main()
        {
            Console.WriteLine("Hi! This program calculate distance between two dots.");
            Console.WriteLine("Input X1");
            double x1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input X2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Input Y2");
            double y2 = Convert.ToDouble(Console.ReadLine());

            double R= Calc(x1, y1, x2, y2);
            Console.WriteLine($"Distance between two dots: {R:f2}");
            Console.ReadKey();


        }
    }

}