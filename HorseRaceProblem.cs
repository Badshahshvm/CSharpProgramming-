
using System;

class Program
{
    static int FindMinDiff(int[] arr, int n)
    {
        Array.Sort(arr);
        int minDiff = int.MaxValue;
        for (int i = 1; i < n; i++)
        {
            int diff = arr[i] - arr[i - 1];
            if (diff < minDiff)
                minDiff = diff;
        }
        return minDiff;
    }

    static void Main()
    {
        int t = int.Parse(Console.ReadLine());
        while (t-- > 0)
        {
            int n = int.Parse(Console.ReadLine());
            int[] arr =  int.Parse(Console.ReadLine().Split());
            Console.WriteLine(FindMinDiff(arr, n));
        }
    }
}
