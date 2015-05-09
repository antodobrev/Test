using System;

class FirstLargerThanNeighbours
{
    static int GetIndexOfFirstElementLargerThanNeighbours(int[] arr)
    {
        int index = -1;
        // Check if the first (#0) element is the largest
        if (arr[0] > arr[1])
        {
            index = 0;
        }
        // Loop through #1 to last but one
        else
        {
            for (int i = 1; i < arr.Length - 1; i++)
            {
                if (arr[i] > arr[i - 1] && arr[i] > arr[i + 1])
                {
                    index = i;
                    break;
                }
            }
        }
        // Check if the last element is the largest
        if (index == -1 && arr[arr.Length-1] > arr[arr.Length-2])
        {
            index = arr.Length - 1;
        }
        return index;
    }
    static void Main()
    {
        int[] sequenceOne = { 1, 3, 4, 5, 1, 0, 5 };
        int[] sequenceTwo = { 1, 2, 3, 4, 5, 6, 6 };
        int[] sequenceTree = { 1, 1, 1 };

        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceOne));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTwo));
        Console.WriteLine(GetIndexOfFirstElementLargerThanNeighbours(sequenceTree));
    }
}
