using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3 \nожидание ввода определенного числа");
            while (true)
            {
                string s1 = Console.ReadLine();
                if (s1 == "0")
                {
                    Console.WriteLine("Вы ввели 0, бесконечный цикл прерван");
                    break;
                }
                else
                {
                    Console.WriteLine($"Вы ввели {s1}, цикл продолжается");
                }
            }

            Console.ReadLine();
        }
    }
}
