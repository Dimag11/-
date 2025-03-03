using System;


namespace Zadanie7
{
    internal class Program
    {
        // Функция для вычисления кубического корня вручную
        static double CubeRoot(double value)
        {
            if (value >= 0)
                return Math.Pow(value, 1.0 / 3.0); // Обычный корень для положительных
            else
                return -Math.Pow(Math.Abs(value), 1.0 / 3.0); // Корень для отрицательных
        }
    
        static void Main()

        {
            Console.WriteLine("Введите значения для a,B,XO,Xk,delX,n соответственно");
            double a = 0, b = 0, X0 = 0, XK = 0, delX = 0, eps = 0.001, n = 0;
            while (true)
            {
                Console.Write("Введите значение a: ");
                if (double.TryParse(Console.ReadLine(), out a))
                    break;
                else { Console.WriteLine("Ошибка! Введите числа! Попробуйте ещё раз"); }
            }
            while (true)
            {
                Console.Write("Введите значение B: ");
                if (double.TryParse(Console.ReadLine(), out b))
                    break;
                else { Console.WriteLine("Ошибка! Введите числа! Попробуйте ещё раз"); }
            }
            while (true)
            {
                Console.Write("Введите значение X0: ");
                if (double.TryParse(Console.ReadLine(), out X0))
                    break;
                else { Console.WriteLine("Ошибка! Введите числа! Попробуйте ещё раз"); }
            }
            while (true)
            {
                Console.Write("Введите значение XK: ");
                if (double.TryParse(Console.ReadLine(), out XK))
                    break;
                else { Console.WriteLine("Ошибка! Введите числа! Попробуйте ещё раз"); }
            }
            while (true)
            {
                Console.Write("Введите значение delX: ");
                if (double.TryParse(Console.ReadLine(), out delX))
                    break;
                else { Console.WriteLine("Ошибка! Введите числа! Попробуйте ещё раз"); }
            }
            while (true)
            {
                Console.Write("Введите значение n: ");
                if (double.TryParse(Console.ReadLine(), out n))
                    break;
                else { Console.WriteLine("Ошибка! Введите числа! Попробуйте ещё раз"); }

            }

            while (X0 <= XK + eps)
            {
                double denominatorValue = Math.Tan(CubeRoot(Math.Pow(a, 2) + b - n));
                double numerator = 0.5 * Math.Cos(a * Math.Pow(X0, a)) + b;

                double j = (numerator / denominatorValue) + Math.Pow(a, 3) * Math.Exp(X0);

                Console.WriteLine($"В точке x={X0:F2} арифметическое выражение = {j:F4}");

                X0 += delX;
            }

            Console.WriteLine("Выполнение завершено.");
            Console.ReadKey();
        }
    }
}




