using System;
using System.Globalization;

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            double a = 1.0, b = -3.0, c = -4.0;

            /*Math.Pow pega variavel e eleva ao numero, ex b ao quadrado (2)*/
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;

            /*Math.Sqrt raiz quadrada*/
            double x1 = (-b + Math.Sqrt(delta)) / (2.0 * a);

            Console.WriteLine(delta);
            Console.WriteLine(x1);

        }
    }
}
