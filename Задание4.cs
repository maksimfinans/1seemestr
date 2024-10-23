using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПЗ5
{
    internal class Задание4
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("введите поочередно длины двух катетов");
            int x = 4;
            double z = (5 * Math.Pow(x, 2) - 12 * x + 4) / (6 - 15 * x);
            Console.WriteLine(z);
        }
    }
}
