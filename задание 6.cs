using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ5
{
    internal class Задание6
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("решите уравнение");
            double a = 6.00;
            double b = 10.00;
            double f = (a / (54 * b) + 4.89);
            double c = f / (-7.86 - Math.Sqrt(1024) + Math.Pow(a, 2));
            Console.WriteLine(c);
        }
    }
}