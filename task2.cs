// //Task
// Man is going on a family trip and needs to apply for national and international travel passports. It takes A minutes to fill each national passport application and B minutes for each international passport
// His journey is given to you as a binary string S of length N where 0 denotes crossing from one district to another district (which needs a national passport ), and a 1 denotes crossing from one city to another (which needs an international passport).Find the total time Man has to spend on filling the various forms.
// Input Format
// The first line of the input contains a single integer T denoting the number of test cases. The description of T test cases follows. Each test case contains two lines of input.First line contains three space separated integers N,A and B.Second line contains the string S.
// Output Format:-For each testcase, output in a single line the total time Man has to spend on filling the various forms for his journey.
// Constraints
// 1 ≤ T ≤ 102
// 1 ≤ N, A, B ≤ 102
// Si ∈ {′ 0 ′,′ 1 ′}
// Sample Input 
//  3
//  2 1 2
//  00
//  2 1 1
//  01
//  4 2 1
//  1101

// Sample Output 
//  2
//  2
//  5


//Answer

using System;

class Program
{
    static void Main()
    {
        int t = int.Parse(Console.ReadLine()); // number of test cases

        for (int i = 0; i < t; i++)
        {
            string[] line = Console.ReadLine().Split(' ');
            int n = int.Parse(line[0]);
            int a = int.Parse(line[1]);
            int b = int.Parse(line[2]);

            string s = Console.ReadLine();

            int total = 0;

            foreach (char ch in s)
            {
                if (ch == '0')
                    total += a;
                else if (ch == '1')
                    total += b;
            }

Console.WriteLine("Totaltime is :");
            Console.WriteLine(total);
        }
    }


