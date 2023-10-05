namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите длину первого катета");
            double a = double.Parse(Console.ReadLine());

            Console.Write("Введите длину второго катета");
            double b = double.Parse(Console.ReadLine());

            double c = Math.Sqrt(a * a + b * b);

            Console.WriteLine($"Гипотенуза треугольника{c}");
        }
    }
}