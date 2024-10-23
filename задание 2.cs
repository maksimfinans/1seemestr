using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class задание_2
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("введите поочередно длины двух катетов");
            int x = Convert.ToInt32(Console.ReadLine());
            int y = Convert.ToInt32(Console.ReadLine());
            double z = Math.Sqrt(x * x + y * y);
            Console.WriteLine(z);
        }
    }
}

