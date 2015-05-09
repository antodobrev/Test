using System;

class LargerThanNeighbours
{
    static bool IsLargerThanNeighbours(int[] arr, int pos) 
    {
        bool isIt = false;
        if (pos == 0)
	    {
            if (arr[0] > arr[1])
            {
                isIt = true;
            }
	    }
        else if(pos == arr.Length - 1)
        {
            if (arr[arr.Length - 1] > arr[arr.Length - 2])
            {
                isIt = true;
            }
        }
        else
        {
            if (arr[pos] > arr[pos -1] && arr[pos] > arr[pos + 1])
            {
                isIt = true;
            }
        }
        return isIt;
    }
    static void Main()
    {
        int[] numbers = { 1, 3, 4, 5, 1, 0, 5 };
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(IsLargerThanNeighbours(numbers, i));
        }
    }
}
