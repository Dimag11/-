using System;

namespace task_2_4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "Тр_пинка, зап__х, жур__вли, д__лёкая, _сенние, схв__тил, д_лина";
            string result = text
           .Replace("__", "/")
           .Replace("_", "o")
           .Replace("/", "a");
            Console.WriteLine("Исходная строка: " + text);
            Console.WriteLine("Результат: " + result);
            Console.ReadKey(true);
        }

    }
}
