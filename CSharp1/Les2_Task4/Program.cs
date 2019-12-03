using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2_Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 4 \nпроверка логина и пароля");

            //количество попыток
            int i = 3;
            do
            {
                Console.WriteLine("Введите логин");
                string login = Console.ReadLine();
                Console.WriteLine("Введите пароль");
                string pass = Console.ReadLine();

                if (login == "root" && pass == "GeekBrains" && i > 0)
                {
                    Console.WriteLine("Авторизация пройдена!");
                    break;
                }
                else
                {
                    i--;
                    Console.WriteLine("Ошибка2");
                }

            } while (i > 0);


            Console.ReadLine();
        }
    }
}
