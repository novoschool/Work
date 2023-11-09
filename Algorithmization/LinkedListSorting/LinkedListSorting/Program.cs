using LinkedListSorting.Entities;
using System;
using System.Net;

namespace LinkedListSorting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SingleSort((x, y) => x < y ? -1 : x == y ? 0 : 1);

            Console.WriteLine("Сортировка слиянием:");
            Console.WriteLine();

            GeneralTimeMeasure((x, y) => x < y ? -1 : x == y ? 0 : 1);
            SortedTimeMeasure((x, y) => x < y ? -1 : x == y ? 0 : 1);
            AlmostSortedTimeMeasure((x, y) => x < y ? -1 : x == y ? 0 : 1);
            ReverseSortedTimeMeasure((x, y) => x < y ? -1 : x == y ? 0 : 1);
        }

        private static void SingleSort(Func<int, int, int> compare)
        {
            var list = new DoubleLinkedList<int>();
            var rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                list.InsertLast(new DoubleLinkedListNode<int> { Value = rnd.Next(200) });
            }

            Console.WriteLine("Исходный массив:");
            ShowList(list);
            Console.WriteLine();

            MergeSort(list, compare);

            Console.WriteLine("Отсортированный массив:");
            ShowList(list);
            Console.WriteLine();
        }

        private static void GeneralTimeMeasure(Func<int, int, int> compare)
        {
            const int runCount = 1000;
            var rnd = new Random();

            foreach (var itemCount in new[] { 100, 200, 400, 800 })
            {
                DateTime startTime = DateTime.Now;

                for (int i = 0; i < runCount; i++)
                {
                    var list = new DoubleLinkedList<int>();
                    for (int j = 0; j < itemCount; j++)
                    {
                        list.InsertLast(new DoubleLinkedListNode<int> { Value = rnd.Next(itemCount * 2) });
                    }

                    MergeSort(list, compare);
                }

                DateTime endTime = DateTime.Now;

                Console.WriteLine($"Количество элементов: {itemCount}, среднее время сортировки: {(endTime - startTime).TotalSeconds / runCount:E4}");
            }

            Console.WriteLine();
        }

        private static void SortedTimeMeasure(Func<int, int, int> compare)
        {
            const int runCount = 1000;
            var rnd = new Random();

            foreach (var itemCount in new[] { 100, 200, 400, 800 })
            {
                DateTime startTime = DateTime.Now;

                for (int i = 0; i < runCount; i++)
                {
                    int value = 0;
                    var list = new DoubleLinkedList<int>();
                    for (int j = 0; j < itemCount; j++)
                    {
                        value += rnd.Next(5);
                        list.InsertLast(new DoubleLinkedListNode<int> { Value = value });
                    }

                    MergeSort(list, compare);
                }

                DateTime endTime = DateTime.Now;

                Console.WriteLine($"Количество элементов (упорядочен): {itemCount}, среднее время сортировки: {(endTime - startTime).TotalSeconds / runCount:E4}");
            }

            Console.WriteLine();
        }

        private static void AlmostSortedTimeMeasure(Func<int, int, int> compare)
        {
            const int runCount = 1000;
            var rnd = new Random();

            foreach (var itemCount in new[] { 100, 200, 400, 800 })
            {
                DateTime startTime = DateTime.Now;

                for (int i = 0; i < runCount; i++)
                {
                    int value = 0;
                    var list = new DoubleLinkedList<int>();
                    for (int j = 0; j < itemCount; j++)
                    {
                        value += rnd.Next(5);
                        list.InsertLast(new DoubleLinkedListNode<int> { Value = value });
                    }

                    list.Head.Value = rnd.Next(list.Count * 2);
                    list.Tail.Value = rnd.Next(list.Count * 2);

                    MergeSort(list, compare);
                }

                DateTime endTime = DateTime.Now;

                Console.WriteLine($"Количество элементов (почти упорядочен): {itemCount}, среднее время сортировки: {(endTime - startTime).TotalSeconds / runCount:E4}");
            }

            Console.WriteLine();
        }

        private static void ReverseSortedTimeMeasure(Func<int, int, int> compare)
        {
            const int runCount = 1000;
            var rnd = new Random();

            foreach (var itemCount in new[] { 100, 200, 400, 800 })
            {
                DateTime startTime = DateTime.Now;

                for (int i = 0; i < runCount; i++)
                {
                    int value = 0;
                    var list = new DoubleLinkedList<int>();
                    for (int j = 0; j < itemCount; j++)
                    {
                        value -= rnd.Next(5);
                        list.InsertLast(new DoubleLinkedListNode<int> { Value = value });
                    }

                    MergeSort(list, compare);
                }

                DateTime endTime = DateTime.Now;

                Console.WriteLine($"Количество элементов (обратно упорядочен): {itemCount}, среднее время сортировки: {(endTime - startTime).TotalSeconds / runCount:E4}");
            }

            Console.WriteLine();
        }

        private static void ShowList(DoubleLinkedList<int> list)
        {
            for (var node = list.Head; node != null; node = node.Next)
            {
                Console.Write($"{node.Value} ");
            }

            Console.WriteLine();
        }

        private static void MergeSort<T>(DoubleLinkedList<T> list, Func<T, T, int> compare)
        {
            var left = new DoubleLinkedList<T>();
            var right = new DoubleLinkedList<T>();
            var valueCount = 1;
            while (valueCount < list.Count)
            {
                Split(list, left, right, valueCount);
                Merge(list, left, right, valueCount, compare);

                valueCount *= 2;
            }

            void Split(DoubleLinkedList<T> list, DoubleLinkedList<T> left, DoubleLinkedList<T> right, int valueCount)
            {
                bool toLeft = true;
                while (list.Count > 0)
                {
                    for (int i = 0; i < valueCount && list.Count > 0; i++)
                    {
                        var node = list.RemoveFirst();
                        if (toLeft)
                        {
                            left.InsertLast(node);
                        }
                        else
                        {
                            right.InsertLast(node);
                        }
                    }

                    toLeft = !toLeft;
                }
            }

            void Merge(DoubleLinkedList<T> list, DoubleLinkedList<T> left, DoubleLinkedList<T> right, int valueCount, Func<T, T, int> compare)
            {
                while (left.Count > 0 || right.Count > 0)
                {
                    int iLeft = 0;
                    int iRight = 0;
                    while (iLeft < valueCount && iRight < valueCount && left.Count > 0 && right.Count > 0)
                    {
                        if (compare(left.Head.Value, right.Head.Value) <= 0)
                        {
                            var node = left.RemoveFirst();
                            list.InsertLast(node);
                            iLeft++;
                        }
                        else
                        {
                            var node = right.RemoveFirst();
                            list.InsertLast(node);
                            iRight++;
                        }
                    }

                    while (iLeft < valueCount && left.Count > 0)
                    {
                        var node = left.RemoveFirst();
                        list.InsertLast(node);
                        iLeft++;
                    }

                    while (iRight < valueCount && right.Count > 0)
                    {
                        var node = right.RemoveFirst();
                        list.InsertLast(node);
                        iRight++;
                    }
                }
            }
        }
    }
}