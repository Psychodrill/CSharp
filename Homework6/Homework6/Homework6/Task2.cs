using System;
using System.IO;

//2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
//а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
//б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
//в) * Переделайте функцию Load, чтобы она возвращала массив считанных значений.Пусть она возвращает минимум через параметр.
namespace Zhiganov
{
    partial class Program
{
     public delegate double D1(double x);

                   

    public static double F(double x)
    {
        return x * x - 50 * x + 10;
    }
        public static double F1(double x)
        {
            return Math.Cos(x);
        }
        public static double F2(double x)
        {
            return Math.Pow(Math.E, x);
        }
    public static void SaveFunc(D1 D, string fileName, double a, double b, double h)

    {

        FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
        BinaryWriter bw = new BinaryWriter(fs);
        double x = a;
        while (x <= b)
        {
            bw.Write(D(x));
            x += h;// x=x+h;
        }
        bw.Close();
        fs.Close();
    }
    public static double Load(string fileName)
    {
        FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
        BinaryReader bw = new BinaryReader(fs);
        double min = double.MaxValue;
        double d;
        for (int i = 0; i < fs.Length / sizeof(double); i++)
        {
            // Считываем значение и переходим к следующему
            d = bw.ReadDouble();
            if (d < min) min = d;
        }
        bw.Close();
        fs.Close();
        return min;
    }

    static void Task2()
    {


            Console.WriteLine("Здравствуйте, Вас приветствует программа нахождения минимума функции, выберите функцию");
            Console.WriteLine("1 - y=x*x-50*x+10");
            Console.WriteLine("2 - y=cos(x)");
            Console.WriteLine("3 - y=e^x");

            Console.WriteLine("0 - Exit");

            ConsoleKeyInfo key = Console.ReadKey();
            Console.WriteLine("Введите начальное значение интервала");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите конечное значение интервала");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите шаг");
            double h = Convert.ToDouble(Console.ReadLine());
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:

                    SaveFunc(F, "data.bin", a, b, h);
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    SaveFunc(F1, "data.bin", a, b, h);
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    SaveFunc(F1, "data.bin", a, b, h);
                    break;

                case ConsoleKey.D0:
                case ConsoleKey.Escape:
                    Console.WriteLine("Bye-bye");
                    return;
                default:
                    Console.WriteLine("Wrong select!");
                    break;
            }
            Console.ReadKey();

            Console.WriteLine($"Минимум функции {Load("data.bin")}");
        Console.ReadKey();
    }
}
}