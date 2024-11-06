using System;

class Program
{
    static void Main()
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
}
