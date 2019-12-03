using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les2_Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Задание 1 \nРасчет наименьшего из 3 чисел");
            int v1 = Int32.Parse(Console.ReadLine());
            int v2 = Int32.Parse(Console.ReadLine());
            int v3 = Int32.Parse(Console.ReadLine());

            int result = v3;

            if (v1 < v2 && v1 < v3) {
                result = v1;
            } else if (v2 < v3 && v2 < v1)
            {
                result = v2;
            }

            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}
