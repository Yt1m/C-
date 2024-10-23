using System;

public class ComplexNumber
{
    protected double realPart;      
    protected double imaginaryPart; 

    public ComplexNumber()
    {
        realPart = 0.0;
        imaginaryPart = 0.0;
    }

    public ComplexNumber(double real, double imaginary)
    {
        realPart = real;
        imaginaryPart = imaginary;
    }

    ~ComplexNumber()
    {
        Console.WriteLine("Объект комплексного числа уничтожен.");
    }

    public ComplexNumber MultiplyBy(double number)
    {
        return new ComplexNumber(realPart * number, imaginaryPart * number);
    }

    public double CalculateArgument()
    {
        return Math.Atan2(imaginaryPart, realPart) * (180.0 / Math.PI);
    }

    public override string ToString()
    {
        return $"{realPart} + {imaginaryPart}";
    }
}

class Program
{
    static void Main(string[] args)
    {
        ComplexNumber complex1 = new ComplexNumber(3, 4);
        Console.WriteLine($"Комплексное число: {complex1}");

        Console.Write("Введите число для умножения: ");
        double multiplier = Convert.ToDouble(Console.ReadLine());

        ComplexNumber result = complex1.MultiplyBy(multiplier);
        Console.WriteLine($"Результат умножения: {result}");

        double argument = complex1.CalculateArgument();
        Console.WriteLine($"Аргумент числа: {argument} градусов");
    }
}
