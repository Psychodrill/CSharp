using System;
//2. Ввести вес и рост человека.Рассчитать и вывести индекс массы тела(ИМТ) по формуле I=m/(h* h); где m — масса тела в килограммах, h — рост в метрах

namespace Zhiganov
{
    class Program
    {
        static void Main()
        {
           Console.WriteLine("Hi! Now we finding your body's mass index. Please Input your weight in kilograms");
           double m = Convert.ToDouble(Console.ReadLine());
           Console.WriteLine("Now input your height in meters");
           double h = Convert.ToDouble(Console.ReadLine());
           double I = m / (h * h);
           Console.WriteLine($"Your body's mass index I={I:G4}");
           Console.ReadKey();


        }
    }
}