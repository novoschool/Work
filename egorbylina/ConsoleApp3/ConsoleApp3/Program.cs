namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //{
            //    Console.WriteLine("Hello, World!");
            //    Console.WriteLine("введите первый катет");            
            //    double a = Convert.ToDouble(Console.ReadLine());
            //    Console.WriteLine("введите второй катет");           
            //    double b = Convert.ToDouble(Console.ReadLine());
            //    double c = Math.Sqrt(a* a + b * b);            
            //    Console.WriteLine($"гипотенуза:{c}");
            //}



            {
                Console.WriteLine("введите четырех число");
                    int number = int.Parse(Console.ReadLine()); 
                int digit1 = number / 1000;
                int digit2 = (number / 100) % 100; 
                int digit3 = (number / 100) % 100;
                int digit4 = number / 1000;
                if (digit1 == digit4 && digit2 == digit3)
                {
                    Console.WriteLine("yes");
                }
                else
                {
                    Console.WriteLine("no");
                }
            }







        }
    }
}