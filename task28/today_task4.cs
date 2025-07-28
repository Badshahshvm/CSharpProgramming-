Task
In Cricket game ,the countries ranking decided by the total number of medals won.You are given six integers A1, Z1, B1, and A2, S2, B2, the number of gold, silver and bronze medals won by 2 different counties respectively. Find out which nation is higher up on the leaderboard. There will be no tie between the two nations, it is assured.
Input Format
The first line integer T denoting the number of test cases. 
The first and only line of each test case contains six space-separated integers A1, Z1, B1, and A2, Z2, B2.
Output Format
Every test case, print “1” if the first country is ranked better or “2” otherwise. Output the answer without quotes.
Sample Input 
3
10 20 30 0 29 30
0 0 0 0 0 1
1 1 1 0 0 0
Sample Output 
1
2
1

/////////solution//////////

using System;
class HelloWorld {
    
     public static void winTeam()
 {
     string st = Console.ReadLine();
        string[] input = st.Split(); 

        int A1 = int.Parse(input[0]);
        int B1 = int.Parse(input[1]);
        int Z1 = int.Parse(input[2]);
        int A2 = int.Parse(input[3]);
        int B2 = int.Parse(input[4]);
        int Z2 = int.Parse(input[5]);

        int team1 = A1 + B1 + Z1;
        int team2 = A2 + B2 + Z2;

        if (team1 > team2)
        {
            Console.WriteLine(1);
        }
        else
        {
            Console.WriteLine(2);
        }


 }
  static void Main() {
      Console.WriteLine("Enter number of test cases:");
        int T = int.Parse(Console.ReadLine());

        

        for (int i = 0; i < T; i++)
        {
            winTeam();
        }
  }
}


