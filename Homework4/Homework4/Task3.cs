using System;
using System.IO;
//3. Решить задачу с логинами из предыдущего урока, только логины и пароли считать из файла в массив.
//    Создайте структуру Account, содержащую Login и Password


namespace Zhiganov

{
    struct Account
    {
        public string Login;
        public string Password;
    }
    class StringArray
    {
        string[] array;

        public StringArray(string login, string password)
        {
            array = new string[2];
            array[0] = login;
            array[1] = password;
        }
        public StringArray(string filename)
        {
            StreamReader sr = null;
            sr = new StreamReader(filename);
            int size = int.Parse(sr.ReadLine());
            array = new string[size];
            int i = 0;
            while (!sr.EndOfStream)
            {
                array[i] = sr.ReadLine();
                i++;
            }
            sr.Close();
        }


        public void WriteToFile(string filename)
        {

            StreamWriter sw = null;
            sw = new StreamWriter(filename);
            sw.WriteLine(array.Length);
            foreach (string el in array)
                sw.WriteLine(el);

            sw.Close();
        }

        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < array.Length; i++)
            {
                s = s + string.Format("{0,20}", array[i]);

            }
            return s;

        }
    }
    partial class Program
    {
        static void Task3()
        {

            Account A;
            Console.WriteLine("Input your login ");
            A.Login = Console.ReadLine();
            Console.WriteLine("Input your password ");
            A.Password = Console.ReadLine();
            StringArray myar = new StringArray (A.Login,A.Password);
            myar.WriteToFile("c:\\temp\\data.txt");
            StringArray myarfromfile = new StringArray("c:\\temp\\data.txt");
            Console.WriteLine(myarfromfile);


        }
    }
}