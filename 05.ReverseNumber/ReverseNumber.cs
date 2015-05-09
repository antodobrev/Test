using System;

class ReverseNumber
{
    static string GetReversedNumber(double num)
    {
        string result = "";
        if (num > 0)
        {
            char[] chars = ReverseChars(num);
            result = new string(chars);
        }
        else
        {
            num *= -1;
            char[] chars = ReverseChars(num);
            result = "-" + new string(chars);
        }
        return result;
    }

    static char[] ReverseChars(double num)
    {
        char[] chars = num.ToString().ToCharArray();
        Array.Reverse(chars);
        return chars;
    }
    static void Main()
    {
        double reversed = double.Parse(GetReversedNumber(double.Parse(Console.ReadLine())));
        Console.WriteLine(reversed);
    }
}
