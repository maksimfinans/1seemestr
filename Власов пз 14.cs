using System;
namespace циклы
{
    class Program
    {
        static double[] a = new double[1000];
        static void Main(string[] args)
        {
            int n = InputA();
            Console.WriteLine("сумма_F = {0}", sumF(n));
            Console.WriteLine("сумма_W = {0}", sumW(n));
            Console.WriteLine("сумма_D = {0}", sumD(n));
            Console.WriteLine("произведение_F = {0}", multyF(n));
            Console.WriteLine("произведение_W = {0}", multyW(n));
            Console.WriteLine("произведение_D = {0}", multyD(n));
            Console.ReadKey();
        }
        static int InputA()
        {
            int n;
            Console.Write("Ввести кол-во элементов:");
            n = Convert.ToInt32(Console.ReadLine());




            for (int i = 0; i < n; i++)
            {
                Console.Write("a[{0}]=", i);
                a[i] = Convert.ToDouble(Console.ReadLine());
            }
            return n;
        }
        static double sumF(int n)
        {
            double s = 0;
        for (int k = 0; k < n; k++)
                s = s + a[k];
            return s;
        }
        static double sumW(int n)
        {
            double s = 0;
            int k = 0;
            while (k < n)
            {
                s = s + a[k];
                k++;
            }
            return s;
        }
        static double sumD(int n)
        {
            double s = 0;
            int k = 0;
            do
            {
                s = s + a[k];
                k++;
            } while (k <= n);
            return s;
        }
        static double multyF(int n)
        {
            double p = 1;
            for (int k = 0; k < n; k++)
                p = p * a[k];
            return p;
        }
        static double multyW(int n)
        {
            double p = 1;
            int k = 0;
            while (k < n)
            {
            p = p * a[k];
                k++;
            }
            return p;
        }
        static double multyD(int n)
        {
            double p = 1;
            int k = 0;
            do
            {
                p = p * a[k];
                k++;
            } while (k < n);
            return p;
        }
    }
}
