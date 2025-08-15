Task
Amit so much likes to write story’s. Today, he has decided to write a X pages long story, but unfortunately his notebook has only Y pages left in it.then he decided to buy a new notebook and went to the stationary shop. owner showed him some N notebooks, where the number of pages and price of the ith one are Pi pages and Ci rubles respectively. Amit has spent some money preparing for raj birthday, and then he has only K rubles left for now.
Amit wants to buy a single notebook such that the price of the notebook should not exceed his budget and he is able to complete his story.
Help Amit accomplishing this task. You just need to tell him whether he can buy such a notebook or not. Note that Amit can use all of the Y pages in the current notebook, and Amit can buy only one notebook because Amit doesn’t want to use many notebooks.
Input
The first line of input contains an integer T, denoting the number of test cases. Then T test cases are follow.
The first line of each test case contains four space-separated integers X, Y, K and N, described in the statement. The ith line of the next N lines contains two space-separated integers Pi and Ci, denoting the number of pages and price of the ith notebook respectively.
Output Format
For each test case, Print “HappyAmit” if Amit can select such a notebook, otherwise print “SadAmit”.
Constraints
1 ≤ T ≤ 105
1 ≤ Y < X ≤ 103
1 ≤ K ≤ 103
1 ≤ N ≤ 105
1 ≤ Pi, Ci ≤103



Sample Input
3
3 1 2 2
3 4
2 2    
3 1 2 2
2 3
2 3    
3 1 2 2
1 1
1 2
Sample Output
HappyAmit
SadAmit
SadAmit




//////Solution////


/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/


using System;

class Program
{
    static void Main()
    {
        int T = int.Parse(Console.ReadLine()); 

        while (T-- > 0)
        {
            string[] firstLine = Console.ReadLine().Split();
            int X = int.Parse(firstLine[0]);
            int Y = int.Parse(firstLine[1]);
            int K = int.Parse(firstLine[2]);
            int N = int.Parse(firstLine[3]);

            int neededPages = X - Y;
            bool found = false;

            for (int i = 0; i < N; i++)
            {
                string[] notebook = Console.ReadLine().Split();
                int P = int.Parse(notebook[0]); // pages
                int C = int.Parse(notebook[1]); // cost

                if (!found && P >= neededPages && C <= K)
                {
                    found = true;
                }
            }

            Console.WriteLine(found ? "HappyAmit" : "SadAmit");
        }
    }
}


