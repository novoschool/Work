using System.Collections;

namespace IntList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new DoubleIntList();
            list.Add(5);
            list.Add(10);
            list.Add(15);

            for (uint i = 0; i < list.Count; i++)
            {
                Console.Write($"{list[i]} ");
            }

            Console.WriteLine();

            var list2 = new List<int>();
            list2.Add(5);
            list2.Add(10);
            list2.Add(15);

            foreach (var item in list2)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();

            //PerformanceTest();
        }

        private static void PerformanceTest()
        {
            foreach (var arraySize in new[] { 100, 1000, 10000, 100000 })
            {
                const int runCount = 1000;
                DateTime beginTime = DateTime.Now;

                for (int i = 0; i < runCount; i++)
                {
                    var list = new IncrementIntList();
                    for (int j = 0; j < arraySize; j++)
                    {
                        list.Add(j);
                    }
                }

                DateTime endTime = DateTime.Now;
                var totalTime = (endTime - beginTime).TotalSeconds;
                Console.WriteLine($"Массив с инкрементом. Размер массива: {arraySize}. Среднее время добавления: {totalTime / arraySize / runCount}");

                beginTime = DateTime.Now;

                for (int i = 0; i < runCount; i++)
                {
                    var list = new DoubleIntList();
                    for (int j = 0; j < arraySize; j++)
                    {
                        list.Add(j);
                    }
                }

                endTime = DateTime.Now;
                totalTime = (endTime - beginTime).TotalSeconds;
                Console.WriteLine($"Массив с удвоением. Размер массива: {arraySize}. Среднее время добавления: {totalTime / arraySize / runCount}");

                beginTime = DateTime.Now;

                for (int i = 0; i < runCount; i++)
                {
                    var list = new List<int>();
                    for (int j = 0; j < arraySize; j++)
                    {
                        list.Add(j);
                    }
                }

                endTime = DateTime.Now;
                totalTime = (endTime - beginTime).TotalSeconds;
                Console.WriteLine($"List<int>. Размер массива: {arraySize}. Среднее время добавления: {totalTime / arraySize / runCount}");

                beginTime = DateTime.Now;

                for (int i = 0; i < runCount; i++)
                {
                    var list = new ArrayList();
                    for (int j = 0; j < arraySize; j++)
                    {
                        list.Add(j);
                    }
                }

                endTime = DateTime.Now;
                totalTime = (endTime - beginTime).TotalSeconds;
                Console.WriteLine($"ArrayList. Размер массива: {arraySize}. Среднее время добавления: {totalTime / arraySize / runCount}");
            }
        }
    }
}