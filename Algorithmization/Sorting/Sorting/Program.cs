namespace Sorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleSort(QuickSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            SingleKeyValueSort(QuickSort, (x, y) => x.Key < y.Key ? -1 : x.Key == y.Key ? 0 : 1);
            //SingleComplexKeyValueSort(HeapSort, (x, y) =>
            //    {
            //        if (x.Key1 < y.Key1)
            //        {
            //            return -1;
            //        }

            //        if (x.Key1 > y.Key1)
            //        {
            //            return 1;
            //        }

            //        if (x.Key2 < y.Key2)
            //        {
            //            return -1;
            //        }

            //        if (x.Key2 > y.Key2)
            //        {
            //            return 1;
            //        }

            //        return 0;
            //    });

            //Console.WriteLine("Сортировка выбором:");
            //Console.WriteLine();

            //GeneralTimeMeasure(SelectionSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            //SortedTimeMeasure(SelectionSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            //AlmostSortedTimeMeasure(SelectionSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            //ReverseSortedTimeMeasure(SelectionSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);

            //Console.WriteLine("Сортировка вставкой:");
            //Console.WriteLine();

            //GeneralTimeMeasure(InsertionSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            //SortedTimeMeasure(InsertionSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            //AlmostSortedTimeMeasure(InsertionSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            //ReverseSortedTimeMeasure(InsertionSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);

            //Console.WriteLine("Пузырьковая сортировка:");
            //Console.WriteLine();

            //GeneralTimeMeasure(BubbleSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            //SortedTimeMeasure(BubbleSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            //AlmostSortedTimeMeasure(BubbleSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            //ReverseSortedTimeMeasure(BubbleSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);

            Console.WriteLine("Сортировка Шелла:");
            Console.WriteLine();

            GeneralTimeMeasure(ShellSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            SortedTimeMeasure(ShellSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            AlmostSortedTimeMeasure(ShellSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            ReverseSortedTimeMeasure(ShellSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);

            Console.WriteLine("Пирамидальная сортировка:");
            Console.WriteLine();

            GeneralTimeMeasure(HeapSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            SortedTimeMeasure(HeapSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            AlmostSortedTimeMeasure(HeapSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            ReverseSortedTimeMeasure(HeapSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);

            Console.WriteLine("Быстрая сортировка:");
            Console.WriteLine();

            GeneralTimeMeasure(QuickSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            SortedTimeMeasure(QuickSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            AlmostSortedTimeMeasure(QuickSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
            ReverseSortedTimeMeasure(QuickSort, (x, y) => x < y ? -1 : x == y ? 0 : 1);
        }

        private static void ReverseSortedTimeMeasure(Action<IList<int>, Func<int, int, int>> sort,
            Func<int, int, int> compare)
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

        private static void AlmostSortedTimeMeasure(Action<IList<int>, Func<int, int, int>> sort,
            Func<int, int, int> compare)
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

        private static void SortedTimeMeasure(Action<IList<int>, Func<int, int, int>> sort,
            Func<int, int, int> compare)
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

        private static void GeneralTimeMeasure(Action<IList<int>, Func<int, int, int>> sort,
            Func<int, int, int> compare)
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

        private static void SingleSort(Action<IList<int>, Func<int, int, int>> sort,
            Func<int, int, int> compare)
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

        private static void SingleKeyValueSort(Action<IList<KeyValue>, 
                Func<KeyValue, KeyValue, int>> sort,
            Func<KeyValue, KeyValue, int> compare)
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

        private static void SingleComplexKeyValueSort(Action<IList<ComplexKeyValue>,
                Func<ComplexKeyValue, ComplexKeyValue, int>> sort,
            Func<ComplexKeyValue, ComplexKeyValue, int> compare)
        {
            var array = new ComplexKeyValue[100];
            var rnd = new Random();
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = new ComplexKeyValue 
                { 
                    Key1 = rnd.Next(10),
                    Key2 = rnd.Next(10),
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

        static void SelectionSort<T>(IList<T> data, Func<T, T, int> compare)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                var iMin = i;
                var minValue = data[iMin];
                for (int j = i + 1; j < data.Count; j++)
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

        static void ShellSort<T>(IList<T> data, Func<T, T, int> compare)
        {
            int step = data.Count / 4;
            while (step >= 1)
            {
                for (int i = 0; i < step; i++)
                {
                    for (int j = 1; j < data.Count; j += step)
                    {
                        int k = j - step;
                        for (; k >= 0; k -= step)
                        {
                            if (compare(data[k], data[j]) <= 0)
                            {
                                break;
                            }
                        }


                        if (k < j - step)
                        {
                            var t = data[j];
                            for (int m = j - step; m > k; m -= step)
                            {
                                data[m + step] = data[m];
                            }

                            data[k + step] = t;
                        }

                        var nextStep = step / 4;
                        if (nextStep == 0 && step > 1)
                        {
                            step = 1;

                        }
                        else
                        {

                        }
                    }
                }

                step /= 2;
            }
        }

        static void BubbleSort<T>(IList<T> data, Func<T, T, int> compare)
        {
            for (int i = 0; i < data.Count - 1; i++)
            {
                for (int j = data.Count - 2; j >= i; j--)
                {
                    if (compare(data[j], data[j + 1]) > 0)
                    {
                        var t = data[j];
                        data[j] = data[j + 1];
                        data[j + 1] = t;
                    }
                }
            }
        }

        static void HeapSort<T>(IList<T> data, Func<T, T, int> compare)
        {
            var left = (data.Count + 1) / 2;
            var right = data.Count;
            while (left > 0)
            {
                left--;
                Sift(data, compare, left, right);
            }

            while (right > 0)
            {
                var t = data[0];
                data[0] = data[right - 1];
                data[right - 1] = t;
                right--;
                Sift(data, compare, left, right);
            }

            void Sift(IList<T> data, Func<T, T, int> compare, int left, int right)
            {
                var i = left;
                var j = 2 * i + 1;
                var t = data[i];
                while (j < right)
                {
                    if (j < right - 1 && compare(data[j], data[j + 1]) < 0)
                    {
                        j++;
                    }

                    if (compare(t, data[j]) >= 0)
                    {
                        break;
                    }

                    data[i] = data[j];
                    i = j;
                    j = 2 * i + 1;
                }

                data[i] = t;
            }
        }

        static void QuickSort<T>(IList<T> data, Func<T, T, int> compare)
        {
            Sort(data, compare, 0, data.Count - 1);

            void Sort(IList<T> data, Func<T, T, int> compare, int left, int right)
            {

                if (right == left)
                {
                    return;
                }

                var middleIdx = (left + right) / 2;

                if (right - left >= 2)
                {
                    if (compare(data[right], data[middleIdx]) < 0)
                    {
                        var t = data[right];
                        data[right] = data[middleIdx];
                        data[middleIdx] = t;
                    }

                    if (compare(data[middleIdx], data[left]) < 0)
                    {
                        var t = data[left];
                        data[left] = data[middleIdx];
                        data[middleIdx] = t;
                    }

                    if (compare(data[right], data[middleIdx]) < 0)
                    {
                        var t = data[right];
                        data[right] = data[middleIdx];
                        data[middleIdx] = t;
                    }
                }
                else
                {
                    if (compare(data[right], data[left]) < 0)
                    {
                        var t = data[right];
                        data[right] = data[left];
                        data[left] = t;
                    }
                }

                var i = left;
                var j = right;
                var middle = data[middleIdx];

                do
                {
                    while (compare(data[i], middle) < 0)
                    {
                        i++;
                    }

                    while (compare(middle, data[j]) < 0)
                    {
                        j--;
                    }

                    if (i <= j)
                    {
                        var t = data[i];
                        data[i] = data[j];
                        data[j] = t;
                        i++;
                        j--;
                    }
                }
                while (i <= j);

                if (left < j)
                {
                    Sort(data, compare, left, j);
                }

                if (i < right)
                {
                    Sort(data, compare, i, right);
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

        static void ShowArray(ComplexKeyValue[] array)
        {
            var count = 0;
            var prevKey1 = array.First().Key1;
            var prevKey2 = array.First().Key2;
            foreach (var item in array)
            {
                Console.Write($"({item.Key1}, {item.Key2} : {item.Value}); ");
                if (++count >= 5 && item.Key1 != prevKey1 && item.Key2 != prevKey2)
                {
                    Console.WriteLine();
                    count = 0;
                }

                prevKey1 = item.Key1;
                prevKey2 = item.Key2;
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
            public int Key1 { get; set; }

            public int Key2 { get; set; }

            public int Value { get; set; }
        }
    }
}