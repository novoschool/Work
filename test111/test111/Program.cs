namespace test111
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Solutions: ");

            /*

            //task 1

            Console.WriteLine("\n \nTask 1");
            Console.WriteLine("Введите число");

            var numbers = Convert.ToInt32(Console.ReadLine());

            int result_task1 = numbers * numbers;

            Console.WriteLine("Квадрат этого числа: " + result_task1);







            //task2
            
            Console.WriteLine("\nTask 2");
            Console.WriteLine("введите кол-во студентов");
            var students = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("введите кол-во заданий");
            var tasks = Convert.ToInt32(Console.ReadLine());

            double result_task2 = tasks / students; 

            Console.WriteLine($"каждому студенту достанется {result_task2} заданий");
            //СЛОЖНААА
            





            

            //task3

            Console.WriteLine("\nTask 3 \nвведите первое число");

            var converted_numbs = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < 3; i++) {
                
                Console.WriteLine(converted_numbs + 1);
                
            }
            






            //task4

            Console.WriteLine("\nTask 4");

            Console.WriteLine("напишите сколько стоят \n'устройство' \n'чехол' \n'зарядка и наушники' ");

            var result1 = Convert.ToDouble(Console.ReadLine());
            var result2 = Convert.ToDouble(Console.ReadLine());
            var result3 = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Итог: {result1 + result2 + result3}");
            





            
            //task5

            Console.WriteLine("\nTask 5");

            Console.WriteLine("введите температуру по шкале фаренгейта");

            var farengeit = Convert.ToDouble(Console.ReadLine());

            double result_task5 = farengeit * 9/5 + 32;

            Console.WriteLine($"ваша указанная температура равна {result_task5} градуса по цельсию");
            

            double num1 = +5.5e-2;

            float num2 = 7.8f;

            int num3 = 0;

            long num4 = 200000L;

            Console.WriteLine(num1);

            Console.WriteLine(num2);

            Console.WriteLine(num3);

            Console.WriteLine(num4);
            */

            Console.WriteLine("введите кол-во бит");

            double a = Convert.ToDouble(Console.ReadLine());

            double result = Math.Pow(2,13);

            Console.WriteLine(a / result);


            Console.ReadLine();

        }
    }
}