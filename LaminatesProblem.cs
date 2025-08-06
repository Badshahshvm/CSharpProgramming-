//LaminatesProblem

using System;

class Program
{
    static long LaminatesProblem(int n, int k)
    {
        if (k > n - k) k = n - k;
        long result = 1;

        for (int i = 1; i <= k; i++)
        {
            result = result * (n - (k - i)) / i;
        }

        return result;
    }

    static void Main()
    {
        int T = int.Parse(Console.ReadLine());

        for (int t = 0; t < T; t++)
        {
            var parts = Console.ReadLine().Split();
            int n = int.Parse(parts[0]);
            int k = int.Parse(parts[1]);

            if (n < k)
            {
                Console.WriteLine(0);
                continue;
            }

            Console.WriteLine(LaminatesProblem(n - 1, k - 1));
        }
    }
}
