using System;
using System.Linq;


namespace Zadanie9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            Console.Write("Введите длину массива n: ");
            int n = int.Parse(Console.ReadLine());

            
            double[] array = new double[n];
            Console.WriteLine("Введите элементы массива:");
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Элемент {i + 1}: ");
                array[i] = double.Parse(Console.ReadLine());
            }

            
            double[] oddNumbers = array.Where(x => x % 2 != 0).ToArray();

            
            if (oddNumbers.Length == 0)
            {
                Console.WriteLine("\nВ массиве нет нечётных чисел.");
            }
            else
            {
                
                Array.Sort(oddNumbers);

                
                Console.WriteLine("\nМассив из нечётных чисел, отсортированный по возрастанию:");
                foreach (var num in oddNumbers)
                {
                    Console.WriteLine(num);
                }
            }
        }
    }
}
    
