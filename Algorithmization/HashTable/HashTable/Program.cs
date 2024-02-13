using HashTable.Entities;
using System.Text;

namespace HashTable
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var hashTable = new MyHashTable<string, int?>();
            var rnd = new Random();

            //for (int k = 0; k < 10; k++)
            //{
            //    Console.WriteLine($"Шаг {k}");

            //    for (int i = 0; i < 20; i++)
            //    {
            //        var key = rnd.Next(100).ToString();
            //        var value = rnd.Next(100);
            //        var inserted = hashTable.Add(key, value);
            //        if (inserted)
            //        {
            //            Console.WriteLine($"Добавлена пара (\"{key}\", {value}). В таблице {hashTable.Count} элементов.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Значение по ключу \"{key}\" заменено на {value}. В таблице {hashTable.Count} элементов.");
            //        }
            //    }

            //    for (int i = 0; i < 20; i++)
            //    {
            //        var key = rnd.Next(100).ToString();
            //        var value = hashTable.Get(key);
            //        if (value.HasValue)
            //        {
            //            Console.WriteLine($"По ключу \"{key}\" найдено значение {value}.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"По ключу \"{key}\" значение не найдено.");
            //        }
            //    }

            //    for (int i = 0; i < 20; i++)
            //    {
            //        var key = rnd.Next(100).ToString();
            //        var removed = hashTable.Remove(key);
            //        if (removed)
            //        {
            //            Console.WriteLine($"Значение по ключу \"{key}\" исключено из таблицы. В таблице {hashTable.Count} элементов.");
            //        }
            //        else
            //        {
            //            Console.WriteLine($"Значение по ключу \"{key}\" в таблице отсутствует. В таблице {hashTable.Count} элементов.");
            //        }
            //    }
            //}

            var dictionary = new MyDictionary<string, int?>();

            for (int i = 0; i < 100; i++)
            {
                var key = rnd.Next(100).ToString();
                var value = rnd.Next(100);
                dictionary[key] = value;
                Console.WriteLine($"Добавлена пара (\"{key}\", {value}). В таблице {dictionary.Count} элементов.");
            }

            for (int i = 0; i < 100; i++)
            {
                var key = rnd.Next(100).ToString();
                var value = dictionary[key];
                if (value.HasValue)
                {
                    Console.WriteLine($"По ключу \"{key}\" найдено значение {value}.");
                }
                else
                {
                    Console.WriteLine($"По ключу \"{key}\" значение не найдено.");
                }
            }

            for (int i = 0; i < 100; i++)
            {
                var key = rnd.Next(100).ToString();
                dictionary[key] = null;
                Console.WriteLine($"Значение по ключу \"{key}\" исключено из таблицы. В таблице {dictionary.Count} элементов.");
            }

            const int totalOperationCount = 1000000;
            foreach (var insertCount in new[] { 10, 100, 1000, 10000, 100000 })
            {
                var repeatCount = totalOperationCount / insertCount;
                var beginTime = DateTime.Now;
                for (int i = 0; i < repeatCount; i++)
                {
                    var testDictionary = new MyDictionary<string, int?>();
                    for (int j = 0; j < insertCount; j++)
                    {
                        var key = rnd.Next(2 * repeatCount).ToString();
                        var value = rnd.Next(2 * repeatCount);
                        testDictionary[key] = value;
                    }
                }

                var endTime = DateTime.Now;
                var timeDiff = (endTime - beginTime).TotalSeconds;
                Console.WriteLine($"Insert count: {insertCount}. Operation time: {timeDiff / totalOperationCount}");
            }

            //var complexTable = new MyHashTable<ComplexKey, string?>();
            //for (int i = 0; i < 80; i++)
            //{
            //    var keyString = rnd.Next(10).ToString();
            //    var keyInt = rnd.Next(10);
            //    var value = GenerateRandomString(rnd);

            //    var key = new ComplexKey
            //    {
            //        StringProperty = keyString,
            //        IntProperty = keyInt,
            //    };

            //    var inserted = complexTable.Add(key, value);
            //    if (inserted)
            //    {
            //        Console.WriteLine($"Добавлена пара [(\"{key.StringProperty}\", {key.IntProperty}), "
            //            + $"<<<{value}>>>]. В таблице {complexTable.Count} элементов.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Значение по ключу (\"{key.StringProperty}\", {key.IntProperty}) " + 
            //            $"заменено на <<<{value}>>>. В таблице {complexTable.Count} элементов.");
            //    }
            //}
        }

        private static string GenerateRandomString(Random rnd)
        {
            var sb = new StringBuilder();

            var stringLength = 3 + rnd.Next(8);

            for (int i = 0; i < stringLength; i++)
            {
                sb.Append((char)(33 + rnd.Next(93)));
            }

            return sb.ToString();
        }
    }
}