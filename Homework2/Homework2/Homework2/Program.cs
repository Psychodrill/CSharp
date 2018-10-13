using System;

namespace Zhiganov

{
    partial class Program
    {


        static void Menu()
        {

            Console.WriteLine("1 - Task 1");
            Console.WriteLine("2 - Task 2");
            Console.WriteLine("3 - Task 3");
            Console.WriteLine("4 - Task 4");
            Console.WriteLine("5 - Task 5");
            Console.WriteLine("6 - Task 6");
            Console.WriteLine("0 - Exit");
            ConsoleKeyInfo key = Console.ReadKey();
            switch (key.Key)
            {
                case ConsoleKey.D1:
                case ConsoleKey.NumPad1:
                    Program.Task1();
                    break;
                case ConsoleKey.D2:
                case ConsoleKey.NumPad2:
                    Program.Task2();
                    break;
                case ConsoleKey.D3:
                case ConsoleKey.NumPad3:
                    Program.Task3();
                    break;
                case ConsoleKey.D4:
                case ConsoleKey.NumPad4:
                    Program.Task4();
                    break;
                case ConsoleKey.D5:
                case ConsoleKey.NumPad5:
                    Program.Task5();
                    break;
                case ConsoleKey.D6:
                case ConsoleKey.NumPad6:
                    Program.Task6();
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
        }

        static void Main(string[] args)
        {
            Menu();
        }
    }
}