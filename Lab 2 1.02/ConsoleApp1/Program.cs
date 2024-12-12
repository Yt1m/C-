using System;

class Program
{
    static void Main()
    {
        Lab();

        Test();
    }

    static void Lab()
    {
        Random random = new Random();
        int arraySize = 15;
        double[] doubleArray = new double[arraySize];

        for (int i = 0; i < arraySize; i++)
        {   
            doubleArray[i] = random.NextDouble() * 20 - 10;
        }

        Console.WriteLine("Массив вещественных чисел:");
        foreach (var num in doubleArray)
        {
            Console.Write(num + " ");
        }
        Console.WriteLine();

        int[] intArray = ConvertToIntegerArray(doubleArray);

        Console.WriteLine("Массив целых чисел:");
        foreach (var num in intArray)
        {
            Console.Write(num + " ");
        }

        int maxAbs = FindMaxAbsolute(intArray);

        Console.WriteLine($"\nМаксимальное по модулю число: {maxAbs}");
    }

    static int RoundToNearestInteger(double number)
    {
        return (int)(number >= 0 ? number + 0.5 : number - 0.5);
    }

    static int[] ConvertToIntegerArray(double[] doubleArray)
    {
        int[] intArray = new int[doubleArray.Length];
        for (int i = 0; i < doubleArray.Length; i++)
        {
            intArray[i] = RoundToNearestInteger(doubleArray[i]);
        }
        return intArray;
    }

    static int FindMaxAbsolute(int[] intArray)
    {
        int maxAbs = Math.Abs(intArray[0]);
        int maxNum = intArray[0];

        foreach (int num in intArray)
        {
            int absValue = Math.Abs(num);
            if (absValue > maxAbs)
            {
                maxAbs = absValue;
                maxNum = num;
            }
        }

        return maxNum;
    }

    static void Test()
    {
        Console.WriteLine("\nЗапуск тестов...");

        AssertEqual(RoundToNearestInteger(5.4), 5, "RoundToNearestInteger(5.4)");
        AssertEqual(RoundToNearestInteger(5.5), 6, "RoundToNearestInteger(5.5)");
        AssertEqual(RoundToNearestInteger(-5.4), -5, "RoundToNearestInteger(-5.4)");
        AssertEqual(RoundToNearestInteger(-5.5), -6, "RoundToNearestInteger(-5.5)");

        double[] doubleInput = { -1.6, 2.4, 3.5 };
        int[] expectedIntArray = { -2, 2, 4 };
        AssertEqual(ConvertToIntegerArray(doubleInput), expectedIntArray, "ConvertToIntegerArray");

        int[] intInput = { -5, 3, -9, 2 };
        AssertEqual(FindMaxAbsolute(intInput), -9, "FindMaxAbsolute");

        Console.WriteLine("Все тесты пройдены!");
    }

    static void AssertEqual(int actual, int expected, string testName)
    {
        if (actual != expected)
        {
            Console.WriteLine($"Тест {testName} не пройден. Ожидалось: {expected}, Получено: {actual}");
        }
        else
        {
            Console.WriteLine($"Тест {testName} пройден.");
        }
    }

    static void AssertEqual(int[] actual, int[] expected, string testName)
    {
        if (actual.Length != expected.Length)
        {
            Console.WriteLine($"Тест {testName} не пройден. Массивы разной длины.");
            return;
        }

        for (int i = 0; i < actual.Length; i++)
        {
            if (actual[i] != expected[i])
            {
                Console.WriteLine($"Тест {testName} не пройден. Ожидалось: {string.Join(", ", expected)}, Получено: {string.Join(", ", actual)}");
                return;
            }
        }

        Console.WriteLine($"Тест {testName} пройден.");
    }
}
