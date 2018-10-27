//Изменить программу вывода функции так, чтобы можно было передавать функции типа double(double,double).
//Продемонстрировать работу на функции с параметром a* x^2.

using System;
namespace Zhiganov

{

    public delegate double Fun2(double a, double x);


    partial class Program
    {
        public static void Table(Fun2 F, double a, double start, double finish, double h)
        {
            Console.WriteLine("----- X ----- Y -----");
            double x = start;
            while (x <= finish)
            {
                Console.WriteLine("|{0,8:0.000} |{1,8:0.000} |", x, F(a, x));
                x += h;
            }
            Console.WriteLine("---------------------");
        }

        public static double MyFunc(double a, double x)
        {
            return a * x * x;//a*x^2
        }

        static void Task1()
        {
            Console.WriteLine("Таблица функции MyFunc:");
            Table(MyFunc, 1, -2, 2, 0.5);//Упрощение(c C# 2.0). Делегат создается автоматически. 
            Console.WriteLine("Таблица функции a*Pow:");
            Table(Math.Pow, 1, -2, 2, 0.5);//Можно передавать уже созданные функции
            Console.WriteLine("Таблица функции a*x^2:");
            //Упрощение(с C# 2.0). Использование анонимного метод
            Table(new Fun2
                (
                    delegate (double a, double x)
                    {
                        return a * x * x;
                    }
                ),
            1, 0, 3, 0.5);

            Table(
            delegate (double a, double x)
            {
                return a * x * x;
            },
            1, 0, 3, 0.5);
            Table(
            (double a, double x) =>//Лямбда выражение
            {
                return a * x * x;
            },
            1, 0, 3, 0.5);

            Table(
            (double a, double x) => a * x * x,
            1, 0, 3, 0.5);

            Table(
            (a, x) => a * x * x,
            1, 0, 3, 0.5);


        }//Поспешил открыть этот пример из lesson6HW, проанализировал и понял, что здесь всё уже сделано...
    }
}