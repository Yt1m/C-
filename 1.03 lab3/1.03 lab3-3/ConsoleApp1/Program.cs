using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        List<Tuple<string, int, string, string>> catsDatabase = new List<Tuple<string, int, string, string>>
        {
            Tuple.Create("Барсик", 4, "Иван", "Петров"),
            Tuple.Create("Мурка", 2, "Ольга", "Сидорова"),
            Tuple.Create("Рыжик", 3, "Анна", "Кузнецова")
        };

        foreach (var cat in catsDatabase)
        {
            Console.WriteLine($"Кличка: {cat.Item1}, Возраст: {cat.Item2}, Владелец: {cat.Item3} {cat.Item4}");
        }
    }
}
