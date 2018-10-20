using System;
//Дан целочисленный массив из 20 элементов.Элементы массива могут принимать целые значения от –10 000 до 10 000 включительно.
//Заполнить случайными числами.Написать программу, позволяющую найти и вывести количество пар элементов массива, в которых хотя бы одно число делится на 3.
//В данной задаче под парой подразумевается два подряд идущих элемента массива.


namespace Zhiganov

{
    class MyArray
    {
        int[] ar;
        public MyArray(int size)
        {
            ar = new int[size];
        }

        public MyArray(int size, int min, int max):this(size)
        {

            Random rnd = new Random();
            for (int i=0;i<ar.Length; i++)
            {
                ar[i] = rnd.Next(min, max + 1);
            }

        }
        public int CalcPairs()
        {
            int count = 0;
            for (int i = 1; i < ar.Length; i++)
            {
                if ((ar[i]%3 == 0) | (ar[i -1] % 3 == 0))
                {
                    count++;
                    //Console.WriteLine($"{ar[i]} и {ar[i + 1]} это {count} пара чисел");
                    //Console.ReadLine();
                }

            }return count;


        }
        public override string ToString()
        {
            string s = "";
            for (int i=0; i<ar.Length; i++)
            {
                s = s + string.Format("{0,8}", ar[i]);
                
            }
            return s;
        }

    }
    partial class Program
    {
        static void Task1()
        {
            MyArray myar = new MyArray(20, -10000, 10000);
            int countP = myar.CalcPairs();
            Console.WriteLine(myar);
            Console.WriteLine(countP);

        }
    }
}