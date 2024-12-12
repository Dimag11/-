using System;
namespace task_2_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string a = "ни";
            char dorogoy = '-';
            string I = "За";
            int kazhdiy = 2;
            int poezd = 1;
            string poshel = "зайцами";
            string svoey = "поймаешь";
            string svoeyu = "погонишься";
            string ushel = "не";
            Console.WriteLine("Выводимое константное сообщение:");
            Console.WriteLine($"{I} {kazhdiy} {poshel} {svoeyu} {dorogoy} {a} {poezd} {ushel} {svoey}");
            Console.WriteLine("Нажмите любую клавишу для завершения");
        }
    }
}