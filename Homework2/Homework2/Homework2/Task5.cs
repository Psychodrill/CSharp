using System;

//5. а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или все в норме;
//б) * Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
namespace Zhiganov
{


    partial class Program
    {
        public static double CalcBMI(double mass, double h)
        {
            double I = mass / (h * h);
            return I;

        }
        public static double CompareBMI(double BMI)
        {
            if (BMI <= 16) Console.WriteLine($"You have severe body mass deficiency");
            else if ((BMI > 16) && (BMI <= 18.5)) Console.WriteLine($"You have underweight");
            else if ((BMI > 18.5) && (BMI <= 24.99)) Console.WriteLine($"Your body mass is norm");
            else if ((BMI > 24.99) && (BMI <= 30)) Console.WriteLine($"You have overweight");
            else if ((BMI > 30) && (BMI <= 35)) Console.WriteLine($"You have obesity");
            else if ((BMI > 35) && (BMI <= 40)) Console.WriteLine($"You have sharp obesity");
            else if (BMI > 40)  Console.WriteLine($"You have very sharp obesity");
            return BMI;
            

        }
        public static double Recom(double BMI,double h)
        {

            string action;
            if (BMI < 18.5)
            {
                action = "to gain weight";
                double differenceBMI = (18.5 - BMI);
                double differenceMass = differenceBMI * (h * h);
                Console.WriteLine($"You should {action} {differenceMass:f2} kgs");
            }
            else if (BMI > 24.99)
            {

                action = "lose weight";
                action = "to gain weight";
                double differenceBMI = (BMI - 24.99);
                double differenceMass = differenceBMI * (h * h);
                Console.WriteLine($"You should {action} {differenceMass:f2}kgs");
            }
            return BMI;


        }

        static void Task5()
        {
            Console.WriteLine("Hi! Now we finding your body mass index. Please Input your weight in kilograms");
            double m = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Now input your height in meters");
            double h = Convert.ToDouble(Console.ReadLine());
            double BMI = CalcBMI(m, h);
            Console.WriteLine($"Your body mass index I={BMI:G4}");
            CompareBMI(BMI);
            Recom(BMI,h);

        }

    }
}
    

