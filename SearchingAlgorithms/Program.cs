using System;

public class SearchingAlgorithms
{
    static void Main(string[] args)
    {
        int[] arr1 = { 1, 1, 2, 2,2, 2, 2, 3, 4, 4, 4, 4, 4, 4, 5, 6, 7, 8, 9, 10 };

        int arr1Result = LinearSearch(arr1, 4);
        Console.WriteLine(arr1Result);
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
}
