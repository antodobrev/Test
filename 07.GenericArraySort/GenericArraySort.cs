using System;
using System.Collections.Generic;

class GenericArraySort
{
    static void SortArray<T>(IList<T> arr) where T : IComparable
    {
        // Bubble sort
        for (int i = 0; i < arr.Count - 1; i++)
        {
            for (int j = 0; j < arr.Count - 1; j++)
            {
                if (arr[j + 1].CompareTo(arr[j]) < 0)
                {
                    T temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
        for (int i = 0; i < arr.Count-1; i++)
        {
            Console.Write(arr[i] + ", ");
        }
        Console.WriteLine(arr[arr.Count-1]);
    }
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        SortArray(numbers);
        string[] strings = { "zaz", "cba", "baa", "azis" };
        SortArray(strings);
        DateTime[] dates = 
        {
            new DateTime(2002,3,1), new DateTime(2015,5,6), new DateTime(2014,1,1)
        };
        SortArray(dates);
    }
}
