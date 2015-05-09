using System;

class BiggerNumber
{
    static int GetMax(int a, int b) 
    {
        int bigger = a;
        if (b > a)
	    {
            bigger = b;
	    }
        return bigger;
    }
    static void Main()
    {
        int firstNumber = int.Parse(Console.ReadLine());
        int secondNumber = int.Parse(Console.ReadLine());
        int max = GetMax(firstNumber, secondNumber);
        Console.WriteLine(max);
    }
}
