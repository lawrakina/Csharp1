using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les1_Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 3 \nРасчет растояния между 2 точками координат");
            Console.WriteLine("При вводе данных следуйте 2 правилам: \n *допускается не целое значение \n *разделитель дробной части запятая \",\"");

            Console.WriteLine("Координата Х1:");
            float x1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Координата Y1:");
            float y1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Координата Х2:");
            float x2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Координата Y2:");
            float y2 = float.Parse(Console.ReadLine());

            var result = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));


            Console.WriteLine($"Растояние между точками 1({x1},{y1}) и 2({x2},{y2}) равно: {result.ToString("#.##")}");

            Console.ReadKey();
        }
    }
}
