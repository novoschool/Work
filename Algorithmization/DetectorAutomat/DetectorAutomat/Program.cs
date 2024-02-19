using DetectorAutomat.Services;

namespace DetectorAutomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            var input = Console.ReadLine();

            var detector = new StringDetector();
            if (detector.Detect(input))
            {
                Console.WriteLine("Строка допущена.");
            }
            else
            {
                Console.WriteLine("Строка отвергнута.");
            }
        }
    }
}