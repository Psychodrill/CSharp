using System;
using System.Text.RegularExpressions;

//1. Создать программу, которая будет проверять корректность ввода логина.
//Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, при этом цифра не может быть первой:
//а) без использования регулярных выражений;
//б) ** с использованием регулярных выражений.

namespace Zhiganov
{
    partial class Program
    {
            
        static void Task1()
        {
            Console.WriteLine("Input login");
            string s = Console.ReadLine();


            char[] b = s.ToCharArray();
            if (b.Length<2)
            {
                Console.WriteLine("Login too little");
            }
            else if (b.Length > 10)
            {
                Console.WriteLine("Login too long");
            }
            else if (((b[0]>='\u0041')&&(b[0] <= '\u005A'))|| ((b[0] >= '\u0061') && (b[0] <= '\u007A')))
            {
                for (int i = 1; i < b.Length; i++)
                {
                    if ((((b[i] >= '\u0041') && (b[i] <= '\u005A')) || ((b[i] >= '\u0061') && (b[i] <= '\u007A'))) || ((b[i] >= '\u0030') && (b[i] <= '\u0039'))) Console.WriteLine("Correct Login!");

                }

            }
            else Console.WriteLine("Login incorrect");

            Regex regexs = new Regex(@"\b\w\w\w?\w?\w?\w?\w?\w?\w?\w?\b");
            if (regexs.IsMatch(s)) Console.WriteLine("Correct"); else Console.WriteLine("Incorrect");
            Console.ReadKey();
            


        }

    }


}