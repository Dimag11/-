using System;


namespace Zadanie5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double m, b, u, a, numerator, denominator, Z;
            
            Console.Write("Введите значение m: ");
             m = double.Parse(Console.ReadLine());

            Console.Write("Введите значение b: ");
             b = double.Parse(Console.ReadLine());

            
            
            if (m > 5)
            {
                u = Math.Pow(b, 2);
            }
            else
            {
                u = Math.Pow(b, 2) - m;
            }

            
            
            if (m < 10)
            {
                a = Math.Pow(m, 2) + 5;
            }
            else if (m == 10)
            {
                a = Math.Pow(m, 2) - Math.Cos(m);
            }
            else 
            {
                a = Math.Cos(Math.Pow(m, 2));
            }

            
             numerator = a * Math.Tan(a) - Math.Pow(m, 2); 
             denominator = Math.Cos(u) + u * b;           

            Z = numerator / denominator;

           
            Console.WriteLine($"Результат вычисления Z: {Z}");
        }
    }
}
    
