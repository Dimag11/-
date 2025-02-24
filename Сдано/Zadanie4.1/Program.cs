using System;


namespace Zadanie4._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, a1, a2, b, c, c1, d, e, f, g, h, i, j, k, result1, result2, bracket1;
            #region Присвоение значений переменным для первого из заданий
            a = 2.7 - 0.8;
            a1 = Math.Pow(Math.Sqrt(2.33), 0.33);
            b = Math.Sqrt(a * a1);
            c = ((5.2 - 1.4) * 7.0) / 3.0;
            c1 = (b / c);
            bracket1 = Math.Pow(c1, 0.2);
            a2 = 8.0 * (9.0 / 11.0);
            d = (bracket1 + a2);
            e = 7.0;
            f = (30.0 - 93.0 * (5.0 / 18.0));
            g = (e / f + 95.0) * 2.25;
            h = Math.Pow(2.0, 1.2);
            i = g / h;
            j = Math.Pow(Math.Sqrt(Math.PI), 0.16);
            k = (2.0 * Math.PI) / 3.0;
            #endregion
            #region Вычисление результатов для двух заданий
            result1 = d + i + j + k;
            result2 = (((Math.Pow(Math.Sqrt((2.7 - 0.8) * (Math.Pow(Math.Sqrt(2.33), 0.33))) / (((5.2 - 1.4) * 7.0) / 3.0), 0.2)) + (8.0 * (9.0 / 11.0))) + ((7.0 / (30.0 - 93.0 * (5.0 / 18.0)) + 95.0) * 2.25) / (Math.Pow(2.0, 1.2)) + (((Math.Pow(Math.Sqrt(Math.PI), 0.16)) + (2.0 * Math.PI / 3.0))));
            #endregion

            Console.WriteLine("Выражение, посчитанное присвоением нескольким переменным: " + result1);
            Console.WriteLine("Выражение, посчитанное присвоением одной переменной: " + result2);
            Console.ReadKey(true);
        }

    }
}
       
