using System;


namespace Zadanie3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите первое значение:");
            int min = int.Parse(Console.ReadLine()); 
            Console.WriteLine("Введите второе значение:");
            int value = int.Parse(Console.ReadLine());
            Math.Min(min, value);
            min = value;
            Console.WriteLine("Введите третье значение:");
            value = int.Parse(Console.ReadLine());
            Math.Min(min, value);
            min = value;
            Console.WriteLine("Введите четвёртое значение:");
            value = int.Parse(Console.ReadLine());
            Math.Min(min, value);
            min = value;
            Console.WriteLine("Введите пятое значение:");
            value = int.Parse(Console.ReadLine());
            Math.Min(min, value);
            min = value;
            Console.WriteLine("Введите шестое значение:");
            value = int.Parse(Console.ReadLine());
            Math.Min(min, value);
            min = value;
            Console.WriteLine("Введите седьмое значение:");
            value = int.Parse(Console.ReadLine());
            Math.Min(min, value);
            min = value;
            Console.WriteLine("Введите восьмое значение:");
            value = int.Parse(Console.ReadLine());
            Math.Min(min, value);
            min = value;
            Console.WriteLine("Введите девятое значение:");
            value = int.Parse(Console.ReadLine());
            Math.Min(min,  value);
            min = value;
            Console.WriteLine("Введите десятое значение:");
            value = int.Parse(Console.ReadLine());
            Math.Min(min, value);
            min = value;







            double x = 0, y = 0;
                Console.WriteLine("Введите значение x: ");
             double.TryParse(Console.ReadLine(), out x) ;

            Console.WriteLine("Введите значение y: ");
             double.TryParse(Console.ReadLine(), out y) ;

            Console.WriteLine("Исследование функций модуля Math");
            Console.WriteLine("Введённые данные будут использованы для вычисления всех функций модуля Math");
            Console.WriteLine("------------------------------------------------------------------------------");


            double abs = Math.Abs(x);
            double sin = Math.Sin(x);
            double cos = Math.Cos(x);
            double tan = Math.Tan(x);
            double acos =Math.Acos(x);
            double asin =Math.Asin(x);
            double atan = Math.Atan(x);
            double atan2 = Math.Atan2(x, y);
            long bigMul = Math.BigMul((int)x, (int)y);
            double ceiling = Math.Ceiling(x);
            double floor = Math.Floor(x);
            double sqrt = Math.Sqrt(x);
            double log = Math.Log(x);
            double log10 =Math.Log10(x);
            double exp = Math.Exp(x);
            double max = Math.Max(x, y);
            double Min = Math.Min(x, y);
            double pow = Math.Pow(x, y);
            double round = Math.Round(x);
            int sign = Math.Sign(x);
            double sinh = Math.Sinh(x);
            double cosh = Math.Cosh(x);
            double tanh = Math.Tanh(x);
            double truncate = Math.Truncate(x);
            

            Console.WriteLine("Нажмите любую клавишу для начала работы...");
            Console.ReadKey();
            Console.WriteLine("------------------------------------------------------------------------------");
            Console.WriteLine($"Модуль числа: Math.Abs({x}) = {abs}");
            Console.WriteLine($"Арккосинус: Math.Acos({x}) = {acos}");
            Console.WriteLine($"Арксинус: Math.Asin({x}) = {asin}");
            Console.WriteLine($"Арктангенс: Math.Atan({x}) = {atan}");
            Console.WriteLine($"Арктангенс: Math.Atan2({y}) = {atan2}");
            Console.WriteLine($",большее: Math.BigMul({x}) = {bigMul}");
            Console.WriteLine($"Округление вверх: Math.Ceiling({x}) = {ceiling}");
            Console.WriteLine($"Косинус: Math.Cos({x}) = {cos}");
            Console.WriteLine($"гип кос числа: Math.Cosh({x}) = {cosh}");
            Console.WriteLine($"Math.E = {Math.E}");
            Console.WriteLine($"Math.Exp = {exp}");
            Console.WriteLine($"Округление вниз: Math.Floor({x}) = {floor}");
            Console.WriteLine($"логарифм: Math.Log({x}) = {log}");
            Console.WriteLine($"логарифм10: Math.Log10({x}) = {log10}");
            Console.WriteLine($"Максимум (x, y): Math.Max({x}, {y}) = {max}");
            Console.WriteLine($"Минимум (x, y): Math.Min({x}, {y}) = {Min}");
            Console.WriteLine($"пи: Math.PI = {Math.PI}");
            Console.WriteLine($"степень: Math.Pow({x}) = {pow}");
            Console.WriteLine($"округление: Math.Round({x}) = {round}");
            Console.WriteLine($"знак числа: Math.Sign({x}) = {sign}");
            Console.WriteLine($"Синус: Math.Sin({x}) = {sin}");
            Console.WriteLine($"гип Синус числа: Math.Sinh({x}) = {sinh}");
            Console.WriteLine($"Квадратный корень: Math.Sqrt({x}) = {sqrt}");
            Console.WriteLine($"Тангенс: Math.Tan({x}) = {tan}");
            Console.WriteLine($"гип Тангенс числа: Math.Tanh({x}) = {tanh}");
            Console.WriteLine($"удаление строк: Math.Truncate({x}) = {truncate}");
            Console.WriteLine($"Минимальное значение: {min}");
        }
    }
}
    