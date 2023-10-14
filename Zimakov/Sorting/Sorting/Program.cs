namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleSort(InsertionSort, (x, y) => x < y ? -1:x == y ? 0 : 1);
            SingleKeyValueSort(InsertionSort, (x, y) => x.Key < y.Key ? -1 : x.Key == y.Key ? 0 : 1);
            SingleComplexKeyValueSort(InsertionSort, (x, y) =>
            {
                if (x.KeyOne < y.KeyOne)
                {
                    return -1;
                }
                if (x.KeyOne > y.KeyOne)
                {
                    return 1;
                }
                if (x.KeyTwo < y.KeyTwo)
                {
                    return -1;
                }
                if (x.KeyTwo > y.KeyTwo)
                {
                    return 1;
                }
                return 0;

            });
            GeneralTimeMeasure(InsertionSort, (x, y) => x > y ? -1 : x == y ? 0 : 1);
            SortedTimeMeasure(InsertionSort, (x, y) => x > y ? -1 : x == y ? 0 : 1);
            AlmostSortedTimeMeasure(InsertionSort, (x, y) => x > y ? -1 : x == y ? 0 : 1);
            ReverseSortedTimeMeasure(InsertionSort, (x, y) => x > y ? -1 : x == y ? 0 : 1);


        }

        private static void ReverseSortedTimeMeasure(Action<IList<int>, Func<int, int, int>> sort, Func<int, int, int> compare)
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

                    sort(array, compare);
                }

                DateTime endTime = DateTime.Now;

                Console.WriteLine($"Количество элементов (обратно упорядочен): {itemCount}, среднее время сортировки: {(endTime - startTime).TotalSeconds / runCount}");
            }

            Console.WriteLine();
        }

        private static void AlmostSortedTimeMeasure(Action<IList<int>, Func<int, int, int>> sort, Func<int, int, int> compare)
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
                    sort(array, compare);
                }

                DateTime endTime = DateTime.Now;

                Console.WriteLine($"Количество элементов (почти упорядочен): {itemCount}, среднее время сортировки: {(endTime - startTime).TotalSeconds / runCount}");
            }

            Console.WriteLine();
        }

        private static void SortedTimeMeasure(Action<IList<int>, Func<int, int, int>> sort, Func<int, int, int> compare)
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

                    sort(array, compare);
                }

                DateTime endTime = DateTime.Now;

                Console.WriteLine($"Количество элементов (упорядочен): {itemCount}, среднее время сортировки: {(endTime - startTime).TotalSeconds / runCount}");
            }

            Console.WriteLine();
        }

        private static void GeneralTimeMeasure(Action<IList<int>, Func<int, int, int>> sort, Func<int, int, int> compare)
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

                    sort(array, compare);
                }

                DateTime endTime = DateTime.Now;

                Console.WriteLine($"Количество элементов: {itemCount}, среднее время сортировки: {(endTime - startTime).TotalSeconds / runCount}");
            }

            Console.WriteLine();
        }

        private static void SingleSort(Action<IList<int>, Func<int, int, int>> sort, Func<int, int, int> compare)
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

            sort(array, compare);

            Console.WriteLine("Отсортированный массив:");
            ShowArray(array);
            Console.WriteLine();
        }

        private static void SingleKeyValueSort(Action<IList<KeyValue>, Func<KeyValue, KeyValue, int>> sort, Func<KeyValue, KeyValue, int> compare)
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

            sort(array, compare);

            Console.WriteLine("Отсортированный массив:");
            ShowArray(array);
            Console.WriteLine();
        }

        static void SelectionSort<T>(IList<T> data, Func<T, T, int> compare)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                var iMin = i;
                var minValue = data[iMin];
                for (int j = i; j < data.Count; j++)
                {
                    if (compare(data[j], minValue) < 0)
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

        static void InsertionSort<T>(IList<T> data, Func<T, T, int> compare)
        {
            for (int i = 1; i < data.Count; i++)
            {
                int j = i - 1;
                for (; j >= 0; j--)
                {
                    if (compare(data[j], data[i]) <= 0)
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
        private static void SingleComplexKeyValueSort(Action<IList<ComplexKeyValue>, Func<ComplexKeyValue, ComplexKeyValue, int>> sort, Func<ComplexKeyValue, ComplexKeyValue, int> compare)
        {
            var array = new ComplexKeyValue[100];
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new ComplexKeyValue { 
                    KeyOne = rnd.Next(10),
                    KeyTwo = rnd.Next(10), 
                    Value = i 
                };
            }

            Console.WriteLine("Исходный массив:");
            ShowArray(array);
            Console.WriteLine();

            sort(array, compare);

            Console.WriteLine("Отсортированный массив:");
            ShowArray(array);
            Console.WriteLine();
        }

        static void ShowArray(ComplexKeyValue[] array)
        {
            var count = 0;
            var prevKey1 = array.First().KeyOne;
            var prevKey2 = array.First().KeyTwo;
            foreach (var item in array)
            {
                Console.Write($"{item.KeyOne}, {item.KeyTwo} : {item.Value}; ");
                if (++count >= 5 && item.KeyOne != prevKey1 && item.KeyTwo != prevKey2)
                {
                    Console.WriteLine();
                    count = 0;
                }

                prevKey1 = item.KeyOne;
                prevKey2 = item.KeyTwo;
            }

            Console.WriteLine();
        }


        private class KeyValue
        {
            public int Key { get; set; }

            public int Value { get; set; }
        }

        private class ComplexKeyValue
        {
            public int KeyOne { get; set; }

            public int KeyTwo { get; set; }

            public int Value { get; set; }
        }
    }
}