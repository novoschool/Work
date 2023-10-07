namespace SuperBestImbaProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string? input = Console.ReadLine();
            
            if (double.TryParse(input, out double password))
            {
                Console.WriteLine($"пердун, хаха! тебе аж {password} ");
            }
            else
            {
                Console.WriteLine("АХАХАХ, КРИНЖ ЗАПОСТИЛ)))))");
            }
            Console.WriteLine($"Щас {DateTime.Today.ToLongDateString()}");
            Console.WriteLine($"Щас {DateTime.Today.DayOfWeek}");
            Console.WriteLine($"Щас {DateTime.Today.ToString("dddd")}");
        }
    }
}