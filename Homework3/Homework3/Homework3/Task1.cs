using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//1. а) Дописать структуру Complex, добавив метод вычитания комплексных чисел.Продемонстрировать работу структуры;
//б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса
namespace Zhiganov
{
     struct  Complex
     {
        public double a, b;
        public static string ComplexDeduction(Complex z1, Complex z2)
        {
            double a = z1.a - z2.a;
            double b = z1.b - z2.b;
            Complex z3;
            z3.a = a;
            z3.b = b;
            string zs = Convert.ToString(z3.a) + "+" + Convert.ToString(z3.b) + "i";
            return zs;

        }
    }
    class Complexclass
    {
        double im;
        double re;
        public Complexclass()
        {
            im = 0; re = 0;
        }
        public Complexclass(double im, double re)
        {
            this.im = im;
            this.re = re;
        }
        public Complexclass Multiply(Complexclass z2)
        {
            Complexclass z3 = new Complexclass();
            z3.im = im * z2.im - re * z2.re;
            z3.re = re * z2.im + im * z2.re;
            return z3;
        }
        public Complexclass Deduction(Complexclass z2)
        {
            Complexclass z3 = new Complexclass();
            z3.im = z2.im - im;
            z3.re = z2.re - re;
            return z3;

        }
        public double Im
        {
            get { return im; }
            set
            {
                if (value >= 0) im = value;
            }
        }
        public override string ToString()
        {
            return im + "+" + re + "i";
        }
    }
    partial class Program
    {


        static void Main(string[] args)
        {
            Complex z1, z2;
            z1.a = 69;
            z1.b = 51;
            z2.a = 49;
            z2.b = 8;

            
            Console.WriteLine(Complex.ComplexDeduction(z1, z2));
            Console.ReadKey();
            // Описали ссылку на объект.
            Complexclass complex1;
            // Создали объект и сохранили ссылку на него в complex1.
            complex1 = new Complexclass(1, 3);
            // Описали объект и создали его.
            Complexclass complex2 = new Complexclass(2, 8);
            // С помощью свойства Im изменили внутреннее (приватное) поле im.
            complex2.Im = 3;
            // Создали ссылку на объект.
            Complexclass resultd;
            Complexclass resultm;
            // Так как в методе Plus создается новый объект,
            // в result сохраняем ссылку на вновь созданный объект.
            resultd = complex1.Deduction(complex2);
            resultm = complex1.Multiply(complex2);

            Console.WriteLine(resultd.ToString());
            Console.WriteLine(resultm.ToString());
            Console.ReadKey();            Task2();

        }

    }
}
