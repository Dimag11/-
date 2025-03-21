

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
                double exponent;
                double result;
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
                    denominatorValue = Math.Sin(cubeRoot);
                    // Проверка на деление на ноль
                    if (Math.Abs(denominatorValue) < eps)
                    {
                        Console.WriteLine($"В точке x={X0:F2} функция не определена (деление на ноль).");
                    }
                    else
                    {
                        if (X0 < 0 && a % 1 != 0)
                        {
                            Console.WriteLine($"В точке x={X0:F2} возведение в дробную степень не определено.");
                        }
                        
                        else
                        {
                            exponent = Math.Pow(Math.Abs(X0) + eps, a) * Math.Sign(X0);
                            numerator = (0.5 * Math.Cos(exponent) + b) * Math.Cos(cubeRoot);
                            result = (numerator / denominatorValue) + Math.Pow(a, 3) * Math.Exp(X0);
                            Console.WriteLine($"В точке x={X0:F2} функция равна = {result:F4}");
                        }
                    }
                    X0 += delX;
                }
                Console.WriteLine("Выполнение завершено.");
                Console.ReadKey();
            }
        }
    }