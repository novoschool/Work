using System;

namespace erd
{
    internal class Program
    {
        static void Main()
        {
            int a = 5;
            int stepen = 2;
            Console.WriteLine(Math.Pow(a, stepen));

            int q = 25;
            int w = 52;
            int e = w / q;
            Console.WriteLine(e);

            int c = int.Parse(Console.ReadLine());
            Console.WriteLine(c + 1);
            Console.WriteLine(c + 2);

            Console.WriteLine("Цена 1");
            int t = int.Parse(Console.ReadLine());
            Console.WriteLine("Цена 2");
            int y = int.Parse(Console.ReadLine());
            Console.WriteLine("Цена 3");
            int u = int.Parse(Console.ReadLine());
            int x = (t + y + u);
            Console.WriteLine(x);

            int d = int.Parse(Console.ReadLine());
            Console.WriteLine((d * 9/5) + 32);

            double num1 = +5.5e-2;
            float num2 = 7.8f;
            short num3 = 0;
            long num4 = 2000000000000L;
            Console.WriteLine(num1);
            Console.WriteLine(num2);
            Console.WriteLine(num3);
            Console.WriteLine(num4);

            double g = double.Parse(Console.ReadLine());
            double l = Math.Pow(2, 13);
            Console.WriteLine(g / l);
        }
    }
}