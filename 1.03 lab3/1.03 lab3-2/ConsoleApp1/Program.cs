using System;
using System.Collections.Generic;

public class Program
{
    public static void Superset(HashSet<int> setA, HashSet<int> setB)
    {
        if (setA.SetEquals(setB))
        {
            Console.WriteLine("Множества равны");
        }
        else if (setA.IsSupersetOf(setB))
        {
            Console.WriteLine("Объект A является чистым супермножеством");
        }
        else if (setB.IsSupersetOf(setA))
        {
            Console.WriteLine("Объект B является чистым супермножеством");
        }
        else
        {
            Console.WriteLine("Супермножество не обнаружено");
        }
    }

    public static void Main()
    {
        Console.Write("Введите количество элементов для множества A: ");
        int countA = int.Parse(Console.ReadLine());

        Console.Write("Введите количество элементов для множества B: ");
        int countB = int.Parse(Console.ReadLine());

        HashSet<int> setA = GenerateRandomSet(countA);
        HashSet<int> setB = GenerateRandomSet(countB);

        Console.WriteLine("Множество A: " + string.Join(", ", setA));
        Console.WriteLine("Множество B: " + string.Join(", ", setB));

        Superset(setA, setB);
    }


    public static HashSet<int> GenerateRandomSet(int count)
    {
        HashSet<int> randomSet = new HashSet<int>();
        Random rand = new Random();

        while (randomSet.Count < count)
        {
            randomSet.Add(rand.Next(1, 100)); 
        }

        return randomSet;
    }
}
