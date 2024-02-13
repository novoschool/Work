using HashTable.Entities;

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
                    Console.WriteLine($"По ключу (\"{key}\" найдено значение {value}.");
                }
                else
                {
                    Console.WriteLine($"По ключу (\"{key}\" значение не найдено {value}.");
                }
            }
        }
    }
}