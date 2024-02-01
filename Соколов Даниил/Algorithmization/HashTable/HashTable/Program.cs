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

            //for (int i = 0; i < 80; i++)
            //{
            //    var key = rnd.Next(100).ToString();
            //    var value = rnd.Next(100);
            //    var inserted = hashTable.Add(key, value);
            //    if (inserted)
            //    {
            //        Console.WriteLine($"Добавлена пара (\"{key}\", {value}). В таблице {hashTable.Count} элементов.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Значение по ключу \"{key}\" заменено на {value}. В таблице {hashTable.Count} элементов.");
            //    }
            //}

            //for (int i = 0; i < 80; i++)
            //{
            //    var key = rnd.Next(100).ToString();
            //    var value = hashTable.Get(key);
            //    if (value.HasValue)
            //    {
            //        Console.WriteLine($"По ключу \"{key}\" найдено значение {value}.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"По ключу \"{key}\" значение не найдено.");
            //    }
            //}

            //for (int i = 0; i < 80; i++)
            //{
            //    var key = rnd.Next(100).ToString();
            //    var removed = hashTable.Remove(key);
            //    if (removed)
            //    {
            //        Console.WriteLine($"Значение по ключу \"{key}\" исключено из таблицы.");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"Значение по ключу \"{key}\" в таблице отсутствует.");
            //    }
            //}

            var complexTable = new MyHashTable<ComlexKey, string?>();

            for (int i = 0; i < 80; i++)
            {
                var keyString = rnd.Next(100).ToString();
                var keyInt = rnd.Next(10);
                var value = GenerateRandomString(rnd);

                var key = new ComlexKey
                {
                    StringProperty = keyString,
                    IntProperty = keyInt,
                };
                var inserted = complexTable.Add(key, value);
                if (inserted)
                {
                    Console.WriteLine($"Добавлена пара [(\"{key.StringProperty}\", {key.IntProperty}), <<<{value}>>>]. В таблице {complexTable.Count} элементов.");
                }
                else
                {
                    Console.WriteLine($"Значение по ключу [(\"{key.StringProperty}\", {key.IntProperty}) изменино на, <<<{value}>>>]. В таблице {complexTable.Count} элементов.");
                }
            }
        }

        private static string GenerateRandomString(Random rnd)
        {
            var sb = new StringBuilder();

            var stringLenght = 3 + rnd.Next(8);
            for (int i = 0; i < stringLenght; i++)
            {
                sb.Append((char)(33 + rnd.Next(93)));
            }
            return sb.ToString();
        }
    }
}