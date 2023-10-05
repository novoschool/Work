            namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine();
            Console.WriteLine("Введите первый катет");
            double cathet1 = Convert.ToDouble(Console.ReadLine());
            double cathet2 = Convert.ToDouble(Console.ReadLine());

            double
                cathet_one = Math.Pow(cathet1, 2);
            Console.WriteLine(cathet_one);
            Console.WriteLine("Введите второй катет");
            double
                cathet_tow = Math.Pow(cathet2, 2);
            Console.WriteLine(cathet_tow);
            double hypotenuse;
            if (cathet1 > cathet2)
            {
                hypotenuse = Math.Sqrt(cathet_one - cathet_tow);
                Console.WriteLine("1");
            }
            else
            {
                hypotenuse = Math.Sqrt(cathet_tow - cathet_one);
                Console.WriteLine("2");
            }

            Console.WriteLine($"Гипотенуза: {hypotenuse}*");
        }
    }
}