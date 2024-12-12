using System;
namespace task_2_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string and = "И";
            string on = "на";
            string sewer = "швец";
            string reaper = "жнец";
            char comma = ',';
            string and_s = "и";
            string duda = "дуде";
            string igretz = "игрец";
            char dot = '.';
            Console.WriteLine("Выводимое константное сообщение...");
            Console.WriteLine(and + " " + sewer + " " + comma + " " + and_s + " " + reaper + " " + comma + " " + and_s + " " + on + " " + duda + " " + igretz + " " + dot);
            Console.WriteLine("Нажмите любую клавишу для завершения.");
            Console.ReadKey(true);
        }
    }
}