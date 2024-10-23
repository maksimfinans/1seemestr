using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ5
{
    internal class Задание3
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("решение уравнения");
            int x = 9;
            double z = 2 * x * x + 3 * Math.Round(Math.Pow(x, 1 / 3), 2);
            Console.WriteLine(z);
        }
    }
}
