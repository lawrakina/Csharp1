using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Les3_Task1
{
    struct Complex
    {
        public double A, B;

        public Complex(double A, double B)
        {
            this.A = A;
            this.B = B;
        }

        public string Print()
        {
            return $"{A}+{B}i";
        }

        //сумма
        public static Complex Sum(Complex N1, Complex N2)
        {
            return new Complex(N1.A + N2.A, N1.B + N2.B);
        }              
        //вычитание
        public static Complex Difference(Complex N1, Complex N2)
        {
            return new Complex(N1.A - N2.A, N1.B - N2.B);
        }
        //произведение
        public static Complex Multiplication(Complex N1, Complex N2)
        {
            return new Complex(
                (N1.A * N2.A)-(N1.B * N2.B), 
                (N1.B * N2.A)+(N1.A * N2.B)
                );
        }
        //деление
        public static Complex Division(Complex N1, Complex N2)
        {
            return new Complex(
                (N1.A * N1.B + N2.A * N2.B) / (N1.B * N1.B + N2.B * N2.B),
                (N2.A * N1.B - N1.A * N2.B) / (N1.B * N1.B + N2.B * N2.B)
                );
        }
    }

    
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Студент Маращук Алексей \n Задание 1 \n операции над комплексными числами");
            Console.WriteLine("x = a + bi");

            Complex N1, N2;

            Console.Write("a1 = "); N1.A = Double.Parse(Console.ReadLine());
            Console.Write("b1 = "); N1.B = Double.Parse(Console.ReadLine());
            Console.Write("a2 = "); N2.A = Double.Parse(Console.ReadLine());
            Console.Write("b2 = "); N2.B = Double.Parse(Console.ReadLine());

            var Nsum = Complex.Sum(N1, N2);
            Console.WriteLine($"N1 + N2 = {Nsum.Print()}");

            var NDifference = Complex.Difference(N1, N2);
            Console.WriteLine($"N1 - N2 = {NDifference.Print()}");

            var NMultiplication = Complex.Multiplication(N1, N2);
            Console.WriteLine($"N1 * N2 = {NMultiplication.Print()}");

            var NDivision = Complex.Division(N1, N2);
            Console.WriteLine($"N1 / N2 = {NDivision.Print()}");



            Console.ReadLine();
        }
    }
}
