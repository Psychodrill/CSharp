using System;
using System.IO;
//а) Дописать класс для работы с одномерным массивом.
//Реализовать конструктор, создающий массив заданной размерности и заполняющий массив числами от начального значения с заданным шагом.
//Создать свойство Sum, которые возвращают сумму элементов массива, метод Inverse, меняющий знаки у всех элементов массива, метод Multi,
//умножающий каждый элемент массива на определенное число, свойство MaxCount, возвращающее количество максимальных элементов.
//В Main продемонстрировать работу класса.б)Добавить конструктор и методы, которые загружают данные из файла и записывают данные в файл.


namespace Zhiganov

{
    class ArrayInit
    {
        int[] array;
        int sum = 0;
        int maxcount = 0;
        public ArrayInit(int size)
        {
            array = new int[size];
        }

        public ArrayInit(int size, int begin, int step) : this(size)
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = begin+step*i;
                sum += array[i];
                if (array[i] > 100)
                {
                    maxcount++;
                }

            }

        }

       
        public int Sum
        {
            get
            {
                return sum;
            }
            set
            {
                sum = value;
            }
        }
        public int MaxCount
        {
            get
            {
                return maxcount;
            }
            set
            {
                maxcount = value;
            }
        }

        public void Inverse()
        {
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = -array[i];

            }
        }
        public void Multy(int mult)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    array[i] *=mult;

                }

            }
        public override string ToString()
        {
            string s = "";
            for (int i = 0; i < array.Length; i++)
            {
                s = s + string.Format("{0,8}", array[i]);

            }
            return s;
        }
        public ArrayInit(string filename)
        {
            StreamReader sr = null;
            sr = new StreamReader(filename);
            int size = int.Parse(sr.ReadLine());
            array = new int[size];
            int i = 0;
            while (!sr.EndOfStream)
            {
                array[i] = int.Parse(sr.ReadLine());
                i++;
            }
            sr.Close();


        }
        public void WriteToFile(string filename)
        {

            StreamWriter sw = null;
            sw = new StreamWriter(filename);
            sw.WriteLine(array.Length);
            foreach (int el in array)
                sw.WriteLine(el);

            sw.Close();
        }

    }
    partial class Program
    {
        static void Task2()
        {
            ArrayInit myar = new ArrayInit(20, -100, 16);
            Console.WriteLine(myar);
            myar.Inverse();
            Console.WriteLine(myar);
            myar.Multy(5);
            Console.WriteLine(myar);
            Console.WriteLine(myar.Sum);
            Console.WriteLine(myar.MaxCount);
            myar.WriteToFile("c:\\temp\\data.txt");
            ArrayInit myarfromfile = new ArrayInit("c:\\temp\\data.txt");
            Console.WriteLine(myar);


        }
    }
}