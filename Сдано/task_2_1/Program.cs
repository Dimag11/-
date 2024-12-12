using System;
namespace task_2_1
{
    class Program
    {
        public static void Main(string[] args)
        {
            string cnst1 = ",";
            int cnst2 = 1;
            int cnst3 = 2;
            int cnst4 = 3;
            string cnst5 = "Богу";
            string cnst6 = "с";
            string cnst7 = "всем";
            Console.WriteLine("Выводимое константное сообщение...");
            Console.WriteLine("{1} поклон {4}{0} {2} хозяину {5} хозяйкой{0} {3} добрым людям", cnst1, cnst2, cnst3, cnst4, cnst5, cnst6, cnst7);
            Console.WriteLine("Нажмите любую клавишу для завершения");
            Console.ReadKey(true);
        }
    }
}

