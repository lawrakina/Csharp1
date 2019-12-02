using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les1_Task1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Задание 1 \nАнкета, введите свои данные");
            Console.WriteLine("Имя?");
            string firstName = Console.ReadLine();
            Console.WriteLine("Фамилия?");
            string lastName = Console.ReadLine();
            Console.WriteLine("Возраст?");
            string age = Console.ReadLine();
            Console.WriteLine("Вес?");
            string weight = Console.ReadLine();

            Console.WriteLine("Задание 1 пункт 1");
            Console.WriteLine("Добрый день, " + firstName + " " + lastName + ", ваш возраст: " + age + ", ваш вес: " + weight);


            Console.WriteLine("Задание 1 пункт 2");
            Console.WriteLine("Добрый день, {0} {1}, ваш возраст: {2}, ваш вес: {3}", firstName, lastName, age, weight);

            Console.WriteLine("Задание 1 пункт 3");
            Console.WriteLine($"Добрый день, {firstName} {lastName}, ваш возраст: {age}, ваш вес: {weight}");

            Console.ReadKey();
        }
    }
}
