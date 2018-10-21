using System;
using System.Text.RegularExpressions;

//Разработать статический класс Message, содержащий следующие статические методы для
//обработки текста:
//а) Вывести только те слова сообщения, которые содержат не более n букв.
//б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
//в) Найти самое длинное слово сообщения.
//г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
namespace Zhiganov
{
    public static class Message
    {
         public static void CompareMessage(string text)
         {
            int n = 8;
            text = Console.ReadLine();
            string[] text0 = text.Split(' ');
            char[] separators = new char[] { ' ', ';', '.', ',' };
            string[] text1 = text.Split(separators, StringSplitOptions.RemoveEmptyEntries);
            string[] a = new string[text1.Length];
            for (int i = 0; i < a.Length; i++) a[i] = (text1[i]);
            for (int i = 0; i < a.Length; i++)
            {
               char[] b= a[i].ToCharArray;
            }

            string str = String.Join(" ", a);
            Console.WriteLine(str);

        }

        public static void RemoveWords(string text)
        {


        }

        public static void LongestWord(string text)
        {

        }

        public static void LongestWordString(string text)
        {


        }
    }

    partial class Program
    {

        static void Task2()
        {
            Console.WriteLine("Input some words");
            string s= Console.ReadLine();
            Message.CompareMessage(s);
            Message.RemoveWords(s);
            Message.LongestWord(s);
            Message.LongestWord(s);





        }

    }


}