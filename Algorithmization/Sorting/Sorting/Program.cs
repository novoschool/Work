namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleSort(SelectionSort);
            SingleKeyValueSort(SelectionSort);
            GeneralTimeMeasure(SelectionSort);
            SortedTimeMeasure(SelectionSort);
            AlmostSortedTimeMeasure(SelectionSort);
            ReverseSortedTimeMeasure(SelectionSort);
        }

        private static void ReverseSortedTimeMeasure(Action<int[]> sort)
        {
            const int runCount = 1000;
            var rnd = new Random();

            foreach (var itemCount in new[] { 100, 200, 400, 800 })
            {
                DateTime startTime = DateTime.Now;

                int value = 0;
                for (int i = 0; i < runCount; i++)
                {
                    var array = new int[itemCount];
                    for (int j = 0; j < array.Length; j++)
                    {
                        value -= rnd.Next(5);
                        array[j] = value;
                    }

                    sort(array);
                }

                DateTime endTime = DateTime.Now;

                Console.WriteLine($"Количество элементов (обратно упорядочен): {itemCount}, среднее время сортировки: {(endTime - startTime).TotalSeconds / runCount}");
            }

            Console.WriteLine();
        }

        private static void AlmostSortedTimeMeasure(Action<int[]> sort)
        {
            const int runCount = 1000;
            var rnd = new Random();

            foreach (var itemCount in new[] { 100, 200, 400, 800 })
            {
                DateTime startTime = DateTime.Now;

                int value = 0;
                for (int i = 0; i < runCount; i++)
                {
                    var array = new int[itemCount];
                    for (int j = 0; j < array.Length; j++)
                    {
                        value += rnd.Next(5);
                        array[j] = value;
                    }

                    var index = rnd.Next(array.Length);
                    array[index] = rnd.Next(array.Length * 2);
                    sort(array);
                }

                DateTime endTime = DateTime.Now;

                Console.WriteLine($"Количество элементов (почти упорядочен): {itemCount}, среднее время сортировки: {(endTime - startTime).TotalSeconds / runCount}");
            }

            Console.WriteLine();
        }

        private static void SortedTimeMeasure(Action<int[]> sort)
        {
            const int runCount = 1000;
            var rnd = new Random();

            foreach (var itemCount in new[] { 100, 200, 400, 800 })
            {
                DateTime startTime = DateTime.Now;

                int value = 0;
                for (int i = 0; i < runCount; i++)
                {
                    var array = new int[itemCount];
                    for (int j = 0; j < array.Length; j++)
                    {
                        value += rnd.Next(5);
                        array[j] = value;
                    }

                    sort(array);
                }

                DateTime endTime = DateTime.Now;

                Console.WriteLine($"Количество элементов (упорядочен): {itemCount}, среднее время сортировки: {(endTime - startTime).TotalSeconds / runCount}");
            }

            Console.WriteLine();
        }

        private static void GeneralTimeMeasure(Action<int[]> sort)
        {
            const int runCount = 1000;
            var rnd = new Random();

            foreach (var itemCount in new[] { 100, 200, 400, 800 })
            {
                DateTime startTime = DateTime.Now;

                for (int i = 0; i < runCount; i++)
                {
                    var array = new int[itemCount];
                    for (int j = 0; j < array.Length; j++)
                    {
                        array[j] = rnd.Next(itemCount * 2);
                    }

                    sort(array);
                }

                DateTime endTime = DateTime.Now;

                Console.WriteLine($"Количество элементов: {itemCount}, среднее время сортировки: {(endTime - startTime).TotalSeconds / runCount}");
            }

            Console.WriteLine();
        }

        private static void SingleSort(Action<int[]> sort)
        {
            var array = new int[100];
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rnd.Next(200);
            }

            Console.WriteLine("Исходный массив:");
            ShowArray(array);
            Console.WriteLine();

            sort(array);

            Console.WriteLine("Отсортированный массив:");
            ShowArray(array);
            Console.WriteLine();
        }

        private static void SingleKeyValueSort(Action<KeyValue[]> sort)
        {
            var array = new KeyValue[100];
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new KeyValue { Key = rnd.Next(100), Value = i };
            }

            Console.WriteLine("Исходный массив:");
            ShowArray(array);
            Console.WriteLine();

            sort(array);

            Console.WriteLine("Отсортированный массив:");
            ShowArray(array);
            Console.WriteLine();
        }

        static void SelectionSort(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                var iMin = i;
                var minValue = data[iMin];
                for (int j = i; j < data.Length; j++)
                {
                    if (data[j] < minValue)
                    {
                        iMin = j;
                        minValue = data[j];
                    }
                }

                if (i != iMin)
                {
                    var t = data[i];
                    data[i] = data[iMin];
                    data[iMin] = t;
                }
            }
        }

        static void SelectionSort(KeyValue[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                var iMin = i;
                var minValue = data[iMin].Key;
                for (int j = i; j < data.Length; j++)
                {
                    if (data[j].Key < minValue)
                    {
                        iMin = j;
                        minValue = data[j].Key;
                    }
                }

                if (i != iMin)
                {
                    var t = data[i];
                    data[i] = data[iMin];
                    data[iMin] = t;
                }
            }
        }

        static void InsertionSort(int[] data)
        {
            for (int i = 1; i < data.Length; i++)
            {
                int j = i - 1;
                for (; j >= 0; j--)
                {
                    if (data[j] <= data[i])
                    {
                        break;
                    }
                }

                if (j < i - 1)
                {
                    var t = data[i];
                    for (int k = i - 1; k > j; k--)
                    {
                        data[k + 1] = data[k];
                    }

                    data[j + 1] = t;
                }
            }
        }

        static void ShowArray(int[] array)
        {
            foreach (var item in array)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
        }

        static void ShowArray(KeyValue[] array)
        {
            var count = 0;
            var prevKey = array.First().Key;
            foreach (var item in array)
            {
                Console.Write($"{item.Key} : {item.Value}; ");
                if (++count >= 10 && item.Key != prevKey)
                {
                    Console.WriteLine();
                    count = 0;
                }

                prevKey = item.Key;
            }

            Console.WriteLine();
        }

        private class KeyValue
        {
            public int Key { get; set; }

            public int Value { get; set; }
        }
    }
}