namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var rnd = new Random();
            var arraySizes = new[] { 1000, 10000, 100000, 1000000 };
            int value = 0;
            int step = 5;
            foreach (var size in arraySizes)
            {
                int[] array = new int[size];

                value = 0;
                step = 5;

                for (int i = 0; i < size; i++)
                {
                    value += rnd.Next(step);
                    array[i] = value;
                }

                LinearSearch(array, 0);
                BinarySearch(array, 0);

                DateTime start = DateTime.Now;

                for (int i = 0; i < 1000; i++)
                {
                    int valueToFind = rnd.Next(array.Last());
                    int index = LinearSearch(array, valueToFind);
                }

                DateTime finish = DateTime.Now;
                Console.WriteLine($"Линейный поиск в массиве из {size} элементов: {(finish - start).TotalSeconds / 1000}");

                //if (index >= array.Length)
                //{
                //    Console.WriteLine("Искомого значения в массиве нет.");
                //}
                //else
                //{
                //    Console.WriteLine($"Искомое значение находится по индексу {index}.");
                //}

                start = DateTime.Now;

                for (int i = 0; i < 1000; i++)
                {
                    var valueToFind = rnd.Next(array.Last());
                    int index2 = BinarySearch(array, valueToFind);
                }

                finish = DateTime.Now;
                Console.WriteLine($"Двоичный поиск в массиве из {size} элементов: {(finish - start).TotalSeconds / 1000}");
                //if (array[index2] != valueToFind)
                //{
                //    Console.WriteLine("Искомого значения в массиве нет.");
                //}
                //else
                //{
                //    Console.WriteLine($"Искомое значение находится по индексу {index}.");
                //}
            }

            //foreach (var item in array)
            //{
            //    Console.Write($"{item} ");
            //}

            Console.WriteLine();
            //Console.WriteLine($"Длина массива {array.Length} элементов");

            //int valueToFind;
            //string? input;
            //do
            //{
            //    Console.Write("Введите значение для поиска: ");
            //    input = Console.ReadLine();
            //}
            //while (!int.TryParse(input, out valueToFind));

            value = 0;
            value = Arrays2d(value, step);
        }

        private static int BinarySearch(int[] array, int valueToFind)
        {
            int left = 0;
            int right = array.Length - 1;
            while (left < right)
            {
                int middle = (left + right) / 2;
                if (valueToFind > array[middle])
                {
                    left = middle + 1;
                }
                else
                {
                    right = middle;
                }
            }

            return left;
        }

        private static int LinearSearch(int[] array, int valueToFind)
        {
            int index;
            for (index = 0; index < array.Length && array[index] != valueToFind; index++)
            {
            }

            return index;
        }

        private static int Arrays2d(int value, int step)
        {
            int[,] array2 = new int[3, 4];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    array2[i, j] = value;
                    value += step;
                }
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{array2[i, j]} ");
                }

                Console.WriteLine();
            }

            foreach (var item in array2)
            {
                Console.Write($"{item} ");
            }

            Console.WriteLine();
            Console.WriteLine($"Длина массива {array2.Length} элементов");
            Console.WriteLine($"В массиве {array2.GetLength(0)} строк");
            Console.WriteLine($"В массиве {array2.GetLength(1)} столбцов");

            int[][] array3 = new int[][] { new int[3], new int[4], new int[5] };
            for (int i = 0; i < array3.Length; i++)
            {
                for (int j = 0; j < array3[i].Length; j++)
                {
                    array3[i][j] = value;
                    value += step;
                }
            }

            foreach (var line in array3)
            {
                foreach (var item in line)
                {
                    Console.Write($"{item} ");
                }

                Console.WriteLine();
            }

            return value;
        }
    }
}