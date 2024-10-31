using System;
using System.Collections.Generic;

public class Program
{
    public static void Main()
    {
        Console.Write("Введите количество элементов: ");
        int count = int.Parse(Console.ReadLine());

        List<int> numbers = new List<int>();
        Random rand = new Random();

        for (int i = 0; i < count; i++)
        {
            numbers.Add(rand.Next(1, 100)); 
        }

        Console.Write("Введите индекс для вставки: ");
        int k = int.Parse(Console.ReadLine());

        Console.Write("Введите значение для вставки: ");
        int C = int.Parse(Console.ReadLine());

        numbers.Add(0); 
        numbers.Insert(k, C); 

        Console.WriteLine("Результат:");
        foreach (int number in numbers)
        {
            Console.Write(number + " ");
        }
    }
}
