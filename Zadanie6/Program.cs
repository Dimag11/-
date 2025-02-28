using System;
using System.Diagnostics;

namespace Zadanie6
{
    class Program
    {
        static void Main()
        {
            string RomanNumeral;
            Console.WriteLine("Вводится римское число, соответствующее значению часа на циферблате:");
            RomanNumeral = Console.ReadLine();
            switch (RomanNumeral)
            {
                case "XII":
                    Console.Write("Север");
                    break;

                case "III":
                    Console.Write("Восток");
                    break;

                case "VI":
                    Console.Write("Юг");
                    break;

                case "IX":
                    Console.Write("Запад");
                    break;

                case "I":
                    Console.Write("Север-Северо-Восток");
                    break;

                case "II":
                    Console.Write("Северо-Восток");
                    break;

                case "IV":
                    Console.Write("Юго-Восток");
                    break;

                case "V":
                    Console.Write("Юг-Юго-Восток");
                    break;
                case "VII":
                    Console.Write("Юг-Юго-Запад");
                    break;
                case "VIII":
                    Console.Write("Юго-Запад");
                    break;
                case "X":
                    Console.Write("Северо-Запад");
                    break;
                case "XI":
                    Console.Write("Север-Северо-Запад");
                    break;

                default:
                    Console.Write("Неверный символ");
                    break;
            }
            Console.ReadKey(true);
        }
    }
}
