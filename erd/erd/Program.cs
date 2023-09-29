using System;
using System.Runtime.CompilerServices;

namespace erd
{
    internal class Program
    {
        static void Main()
        {
            

            int first = int.Parse(Console.ReadLine());
            int one = (first/100);
            int two = (first/10%10);
            int three = (first%10);
            if (one!=two&&one!=three&&two!=three)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
            int x = int.Parse(Console.ReadLine());
            if ( x%4==0&&x%100!=0 || x%400 ==0) {
                Console.WriteLine("yes");
            }
            else {
                Console.WriteLine("no");
            }
            var c = Convert.ToInt32(Console.ReadLine());
            var r = Convert.ToInt32(c % 2 == 0);
            bool l = r > 0 ? true : false;
            Console.WriteLine(l);
        }
    }
}