using System;
//5.
//а) Написать программу, которая выводит на экран ваше имя, фамилию и город проживания.
//б) Сделать задание, только вывод организуйте в центре экрана
//в) * Сделать задание б с использованием собственных методов(например, Print(string ms, int x, int y)
namespace Zhiganov
{
    class Program
    {
        static void Print(string ms, int x, int y)
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(ms);

        } 
        static void Main()
        {
            Console.SetWindowSize(100, 45);
            Console.SetBufferSize(200, 100);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Print("Zhiganov Taras, Samara", 20, 20);
            Console.ReadKey();

        }
    }
}