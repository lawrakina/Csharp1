using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2 \nПодсчет количества цифр числа");
            string str = Console.ReadLine();
            //количество знаков в строке 
            //var s = str.Length;
            var s1 = Int32.Parse(Console.ReadLine());
            
            switch (s1.ToString().Length)
            {
                case 1:
                    Console.WriteLine($"В числе {s1} всего 1 знак");
                    break;
                case 2:
                    Console.WriteLine($"В числе {s1} всего 2 знака");
                    break;
                case 3:
                    Console.WriteLine($"В числе {s1} всего 3 цифры");
                    break;
                case 4:
                    Console.WriteLine($"В числе {s1} всего 4 цифры");
                    break;
                case 5:
                    Console.WriteLine($"В числе {s1} всего 5 цифр");
                    break;
                default:
                    Console.WriteLine($"В числе {s1} больше 5 цифр");
                    break;
            }
            Console.ReadLine();
        }
    }
}
