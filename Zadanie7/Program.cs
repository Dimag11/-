using System;

namespace Zadanie7
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значения для a, B, X0, XK, delX, n соответственно");

            double a = 0, b = 0, X0 = 0, XK = 0, delX = 0, eps = 0.001, n = 0;

            
            while (true)
            {
                Console.Write("Введите значение a: ");
                if (double.TryParse(Console.ReadLine(), out a))
                    break;
                else { Console.WriteLine("Ошибка! Введите число!"); }
            }
            while (true)
            {
                Console.Write("Введите значение B: ");
                if (double.TryParse(Console.ReadLine(), out b))
                    break;
                else { Console.WriteLine("Ошибка! Введите число!"); }
            }
            while (true)
            {
                Console.Write("Введите значение X0: ");
                if (double.TryParse(Console.ReadLine(), out X0))
                    break;
                else { Console.WriteLine("Ошибка! Введите число!"); }
            }
            while (true)
            {
                Console.Write("Введите значение XK: ");
                if (double.TryParse(Console.ReadLine(), out XK))
                    break;
                else { Console.WriteLine("Ошибка! Введите число!"); }
            }
            while (true)
            {
                Console.Write("Введите значение delX: ");
                if (double.TryParse(Console.ReadLine(), out delX))
                    break;
                else { Console.WriteLine("Ошибка! Введите число!"); }
            }
            while (true)
            {
                Console.Write("Введите значение n: ");
                if (double.TryParse(Console.ReadLine(), out n))
                    break;
                else { Console.WriteLine("Ошибка! Введите число!"); }
            }

            Console.WriteLine("\nРезультаты вычислений:");

           
            while (X0 <= XK + eps)
            {
                // Расчёт кубического корня вручную
                double valueForRoot = Math.Pow(a, 2) + b - n;
                double cubeRoot;
                if (valueForRoot >= 0)
                    cubeRoot = Math.Pow(valueForRoot, 1.0 / 3.0); // Корень для положительных чисел
                else
                    cubeRoot = -Math.Pow(Math.Abs(valueForRoot), 1.0 / 3.0); // Корень для отрицательных чисел

                // Остальные вычисления
                double denominatorValue = Math.Tan(cubeRoot);
                double numerator = 0.5 * Math.Cos(a * Math.Pow(X0, a)) + b;

                double j = (numerator / denominatorValue) + Math.Pow(a, 3) * Math.Exp(X0);

                Console.WriteLine($"В точке x={X0:F2} функция равна = {j:F4}");

                X0 += delX;
            }

            Console.WriteLine("Выполнение завершено.");
            Console.ReadKey();
        }
    }
}




