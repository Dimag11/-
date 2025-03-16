using System;

namespace Zadanie7
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Введите значения для a, B, X0, XK, delX, n соответственно");

            double a = 0, b = 0, X0 = 0, XK = 0, delX = 0, eps = 0.001, n = 0;
            double valueForRoot;
            double cubeRoot;
            double numerator;
            double denominatorValue;
            double j;

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
                valueForRoot = Math.Pow(a, 2) + b - n;
                 if (valueForRoot >= 0)
                    cubeRoot = Math.Pow(valueForRoot, 1.0 / 3.0); // Корень для положительных чисел
                else
                    cubeRoot = -Math.Pow(Math.Abs(valueForRoot), 1.0 / 3.0); // Корень для отрицательных чисел

                
                denominatorValue = Math.Tan(cubeRoot);

                // Проверка на деление на ноль
                if (denominatorValue == 0)
                {
                    Console.WriteLine($"В точке x={X0:F2} функция не определена (деление на ноль).");
                }
                else
                {
                    numerator = 0.5 * Math.Cos(a * Math.Pow(X0, a)) + b;

                    j = (numerator / denominatorValue) + Math.Pow(a, 3) * Math.Exp(X0);

                    // Проверка на NaN или бесконечность 
                    if (j != j || j == Double.PositiveInfinity || j == Double.NegativeInfinity)
                    {
                        Console.WriteLine($"В точке x={X0:F2} функция равна не число (NaN) или бесконечность.");
                    }
                    else
                    {
                        Console.WriteLine($"В точке x={X0:F2} функция равна = {j:F4}");
                    }
                }
                X0 += delX;
            }

            Console.WriteLine("Выполнение завершено.");
            Console.ReadKey();
        }
    }
}
