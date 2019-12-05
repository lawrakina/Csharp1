using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les3_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Студент Маращук Алексей \n Задание 2 \n подсчет суммы всех нечетных положительных чисел");

            int sum = 0;
            string result = "";
            while (true)
            {
                string s;//начальная строка
                int a; //валидное число
                bool b;//флаг валидного числа

                Console.WriteLine("введите число: ");

                s = Console.ReadLine();
                b = int.TryParse(s, out a);

                if (b)//проверка пройдена число корректное
                {
                    if (a == 0)
                    {
                        Console.WriteLine("Получен 0, ввод чисел прерван");
                        Console.WriteLine($"sum = {sum}, корректные слагаемые суммы: {result}");
                        break;
                    }
                    else if (a % 2 == 0)
                    {
                        Console.WriteLine($"{a} - не подходит");

                    }
                    else if (a > 0)
                    {

                        Console.WriteLine($"{a} - нечетное положительное число");
                        sum += a;
                        result += $" {a}";

                        Console.WriteLine($"sum = {sum}, корректные слагаемые суммы: {result}");

                    }
                }
                else
                {
                    Console.WriteLine("Строка не прошла проверку, продолжаем ввод");
                }


            }
            Console.ReadLine();
        }
    }
}
