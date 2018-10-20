using System;
//4. Реализовать метод проверки логина и пароля.На вход подается логин и пароль.
//На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains).
//Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, программа пропускает его дальше или не пропускает.
//С помощью цикла do while ограничить ввод пароля тремя попытками.

namespace Zhiganov
{
    partial class Program
    {
        public static bool Autorization(string log, string pass)
        {

            if ((log == "root") && (pass == "GeekBrains")) return true;
            else return false;

        }

        static void Task4()
        {
            Console.WriteLine("Hello, user!");
            int trycount = 0;
            bool a = false;
            do
            {
                Console.WriteLine("Input your login ");
                string login = (Console.ReadLine());
                Console.WriteLine("Input your password ");
                string password = (Console.ReadLine());
                a = Autorization(login, password);
                trycount++;
                if (a == true) break;
                else if (trycount == 3) break;
                else Console.WriteLine("Autorization failed, try again, press enter for continue ");
                Console.ReadKey();
            } while (trycount <3);

            switch (a)
            {
                case true: Console.WriteLine("Wellcome username "); 
                    break;
                case false: Console.WriteLine("Autorization failed, your trycount is over, try it next time...");
                    break;
            }

        }
    }
}