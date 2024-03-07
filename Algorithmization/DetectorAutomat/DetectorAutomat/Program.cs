using DetectorAutomat.Services;

namespace DetectorAutomat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Введите строку: ");
                var input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

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
}