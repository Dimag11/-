using System;

namespace Zadanie7
{
    class Program
    {
        static void Main()
        {
                double alpha, beta, n, x0, xk, xd;

                // Ввод данных с проверками
                alpha = ReadDouble("Введите A (A неравен 0): ", v => v != 0);
                beta = ReadDouble("Введите B: ");
                n = ReadDouble("Введите n: ");
                x0 = ReadDouble("Введите x0: ");
                xk = ReadDouble("Введите xk (xk > x0): ", v => v > x0);
                xd = ReadDouble("Введите xd (xd > 0): ", v => v > 0);

                // Вычисление и вывод значений функции J
                Console.WriteLine("\nРезультаты:");
                for (double x = x0; x <= xk; x += xd)
                {
                    double denominatorValue = Math.Pow((Math.Pow(alpha, 2) + beta - n), 1.0 / 3.0);

                    // Проверяем, что аргумент тангенса не ведет к бесконечности
                    if (Math.Tan(denominatorValue) == 0)
                    {
                        Console.WriteLine($"J({x}) не определено (деление на ноль)");
                        continue;
                    }

                    double numerator = 0.5 * Math.Cos(alpha * Math.Pow(x, alpha)) + beta;
                    double denominator = Math.Tan(denominatorValue);
                    double j = (numerator / denominator) + Math.Pow(alpha, 3) * Math.Exp(x);

                    Console.WriteLine($"J({x}) = {j}");
                }
            }

            // Метод для безопасного ввода числа с условием
            static double ReadDouble(string message, Func<double, bool> condition = null)
            {
                double value;
                while (true)
                {
                    Console.Write(message);
                    if (double.TryParse(Console.ReadLine(), out value) && (condition == null || condition(value)))
                    {
                        return value;
                    }
                    Console.WriteLine("Ошибка! Введите корректное значение.");
                } 
            }
        }
    }







