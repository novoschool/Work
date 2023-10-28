using System.Text;

namespace StandardTypes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Strings();
            UsingDateTime();
        }

        static void UsingDateTime()
        {
            var now = DateTime.Now;
            //Console.WriteLine(now.ToLongDateString());
            //Console.WriteLine(now.ToShortDateString());
            //Console.WriteLine(now.ToLongTimeString());
            //Console.WriteLine(now.ToShortTimeString());
            Console.WriteLine(now.ToString("d.MM.yyyy dddd H:mm:ss"));

            var yesterday = now.AddDays(-1).Date;
            Console.WriteLine($"Вчера: {yesterday.ToLongDateString()}");

            var nowTime = now.TimeOfDay;
            Console.WriteLine(nowTime.ToString(@"h\:mm\:ss"));

            var inHour = now + new TimeSpan(1, 0, 0);
            Console.WriteLine($"Через час: {inHour.ToLongTimeString()}");
        }

        static void Strings()
        {
            string s = "Hello!";
            Console.WriteLine(s);

            //Console.Write("Введите ваше имя: ");
            //string name = Console.ReadLine();
            //Console.WriteLine("Приветствую, {0}!", name);
            //var greeting = string.Format("Приветствую, {0}!", name);
            // Конкатенация
            //var greeting = "Приветствую, " + name + "!";
            // Интерполяция
            //var greeting = $"Приветствую, {name}!";
            //            var greeting = string.Format(@"
            //Приветствую, {0}!
            //Привет!", name);
            //            var greeting = @$"
            //Приветствую, {name}!
            //Привет!";
            //            Console.WriteLine(greeting);

            var array = new[] { 3, 6, 1, 9, 3, 7, 2, 6 };
            //string report = string.Empty;
            //foreach (var item in array)
            //{
            //    report += item.ToString() + ", ";
            //}

            //if (!string.IsNullOrEmpty(report))
            //{
            //    report = report.Substring(0, report.Length - 2);
            //}

            //Console.WriteLine(report);

            //var builder = new StringBuilder();
            //foreach (var item in array)
            //{
            //    builder.Append(item);
            //    builder.Append(", ");
            //}

            //if (builder.Length > 0)
            //{
            //    builder.Remove(builder.Length - 2, 2);
            //}

            //Console.WriteLine(builder.ToString());

            Console.WriteLine(string.Join(", ", array));

            Console.Write("Введите числа: ");
            var input = Console.ReadLine();
            var substrings = input.Split(" ", StringSplitOptions.RemoveEmptyEntries);
            var numbers = substrings.Where(s => int.TryParse(s, out _))
                .Select(s => int.Parse(s)).ToArray();

            Console.WriteLine($"Числа: {string.Join(", ", numbers)}");

        }
    }
}