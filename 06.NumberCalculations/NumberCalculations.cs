using System;

class NumberCalculations
{
    static double CalcMin(double[] numbers)
    {
        Array.Sort(numbers);
        double min = numbers[0];
        return min;
    }
    static decimal CalcMin(decimal[] numbers)
    {
        Array.Sort(numbers);
        decimal min = numbers[0];
        return min;
    }
    static double CalcMax(double[] numbers)
    {
        Array.Sort(numbers);
        double min = numbers[numbers.Length - 1];
        return min;
    }
    static decimal CalcMax(decimal[] numbers)
    {
        Array.Sort(numbers);
        decimal min = numbers[numbers.Length-1];
        return min;
    }
    static double CalcSum(double[] numbers)
    {
        double sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static decimal CalcSum(decimal[] numbers)
    {
        decimal sum = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            sum += numbers[i];
        }
        return sum;
    }
    static double CalcAvg(double[] numbers)
    {
        return CalcSum(numbers) / numbers.Length;
    }
    static decimal CalcAvg(decimal[] numbers)
    {
        return CalcSum(numbers) / numbers.Length;
    }
    static double CalcProd(double[] numbers)
    {
        double prod = 1;
        for (int i = 0; i < numbers.Length; i++)
        {
            prod *= numbers[i];
        }
        return prod;
    }
    static decimal CalcProd(decimal[] numbers)
    {
        decimal prod = 0;
        for (int i = 0; i < numbers.Length; i++)
        {
            prod *= numbers[i];
        }
        return prod;
    }
    static void Main()
    {
        double[] arrDouble = { 1.2, 332.2, -1.232, 0, 22, 12, 19 };
        decimal[] arrDecimal = { 1.2m, 332.2m, -1.232m, 0, 22, 12, 19, -1.232222222222m };
        double[] arrSimple = { 3, 5, 6 };
        Console.WriteLine(CalcMin(arrDouble));
        Console.WriteLine(CalcMin(arrDecimal));
        Console.WriteLine(CalcMax(arrDouble));
        Console.WriteLine(CalcMax(arrDecimal));
        Console.WriteLine(CalcAvg(arrSimple));
        Console.WriteLine(CalcSum(arrSimple));
        Console.WriteLine(CalcProd(arrSimple));
    }
}
