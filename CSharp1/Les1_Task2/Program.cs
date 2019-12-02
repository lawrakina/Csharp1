using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les1_Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 2 \nРасчет индекса массы тела");
            Console.WriteLine("При вводе данных следуйте 2 правилам: \n *допускается не целое значение \n *разделитель дробной части запятая \",\"");
            Console.WriteLine("Введите массу тела в киллограмах:");
            float weight = float.Parse(Console.ReadLine());
            Console.WriteLine("Введите рост в метрах:");
            float height = float.Parse(Console.ReadLine());

            float result = weight / (height * height);
            Console.WriteLine($"Индекс массы тела при росте {height} и весе {weight} равен: {result.ToString("#.##")}");

            Console.ReadKey();
        }
    }
}
