using System;
//1. Написать программу «Анкета». Последовательно задаются вопросы(имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку.
//а) используя склеивание;
//б) используя форматированный вывод;
//в) * используя вывод со знаком $

namespace Zhiganov
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello, lets talk about you! Press any key!");
            Console.ReadKey();
            Console.WriteLine("What's your firstname?");
            var firstname =Console.ReadLine();
            Console.WriteLine("What's your lastname?");
            var lastname = Console.ReadLine();
            Console.WriteLine("How old are you full years?");
            var age = Console.ReadLine();
            Console.WriteLine("How tall are you in meters?");
            double tall = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("What's your weight in kilograms?");
            double weight = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Check your data:"+firstname+"; "+lastname+"; "+age+" years; "+tall+" meters; "+weight+" kg.");
            Console.WriteLine("Check your data:{0:F2}; {1:E4}; {2:G2} years; {3:E1} meters; {4:G3} kg.", firstname, lastname, age, tall, weight);
            Console.WriteLine($"Check your data:{firstname:F2}; {lastname:E4}; {age:G2} years; {tall:E2} meters; {weight:G4} kg.");
            Console.ReadKey();







        }



    }



}

