using System;

public class SearchingAlgorithms
{
    static void Main(string[] args)
    {
        int[] arr1 = { 1, 1, 2, 2, 2, 2, 2, 3, 4, 4, 4, 4, 4, 4, 5, 6, 7, 8, 9, 10 };

        int arr1Result = LinearSearch(arr1, 4);
        Console.WriteLine($"The earliest index where 4 occurs in the linear search is: {arr1Result}");
    }

    public static int LinearSearch(int[] arrayToSearch, int target)
    {
        // Initialize the loop conditiional to 0 in this case
        // Next is to determine if the value satisfies the condition
        // After each loop we run the update logic (i-- also works as well as i++)
        for (int i = 0; i < arrayToSearch.Length; i++)
        {
            if (arrayToSearch[i] == target) return i;
        }

        return -1;
    }

    public static int BinarySearch(int[] arrayToSearch, int target)
    {
        // Set the lower and upper bounds of the binary search
        int lower = 0;
        int upper = arrayToSearch.Length - 1;

        while (upper > lower)
        {
            int mid = (lower + upper) / 2;
            if (arrayToSearch[mid] == target) return mid;
            else if (target < arrayToSearch[mid])
            {
                upper = mid - 1;
            }
            else
            {
                lower = mid + 1;
            }
        }
        return -1;
    }

    public static int[] MinMaxSearch(int[] arrayToSearch, int target)
    {
        /// This program returns an ordered integer pair (min, max)
        /// It initializes by reading the first 2 elements and evaluating them
        /// Then it reads from index 2 until the end of the array and updates min/max for each element
        int min = 0;
        int max = 0;
        int[] maxMinPair = {min,max};

        if (arrayToSearch[1] > arrayToSearch[0])
        {
            max = arrayToSearch[1];
            min = arrayToSearch[0];
        }
        else if (arrayToSearch[1] == arrayToSearch[0])
        {
            max = arrayToSearch[1];
            min = arrayToSearch[1];
        }
        else
        {
            max = arrayToSearch[0];
            min = arrayToSearch[1];
        }

        for (int i = 2; i < arrayToSearch.Length; i++)
        {
            if (arrayToSearch[i] > max)
            {
                max = arrayToSearch[i];
            }
            if (arrayToSearch[i] < min)
            {
                min = arrayToSearch[i];
            }
        }

        return maxMinPair;
    }
}
