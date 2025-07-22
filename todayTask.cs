Task
A man has 3 diamond box of sizes P,Q, and R respectively. He puts the diamond box in bags of size S. Find the minimum number of bags man needs so that he can put each diamond box in a bag. A bag can contain more than one diamond box if the sum of sizes of diamond boxes in the bag does not exceed the size of the bag.
Input Format
The first line contains T denoting the number of test cases. Then the test cases follow.
Each test case contains four integers P, Q, R, and S on a single line denoting the sizes of the diamond boxes and bags.
Output Format
For each test case, output on a single line the minimum number of bags Man needs.
Constraints
1 ≤ T ≤ 100
1 ≤ P ≤ Q ≤ R ≤ S ≤ 100
Sample Input 1
3
2 3 5 10
1 2 3 5
3 3 4 4


  ///code///


  
using System;

class HelloWorld {
    static void Main() {
     

            
            int[] a = new int[4];
            for (int i = 0; i < 4; i++) {
                a[i] = int.Parse(Console.ReadLine());
            }

            int p = a[0];
            int q = a[1];
            int r = a[2];
            int s = a[3];

Console.WriteLine("Minimum Bag is :");
            Console.WriteLine(MinimumBagsRequired(p, q, r, s));
        
    }

 
    static int MinimumBagsRequired(int p, int q, int r, int s) {
      
        int count = 3;

        
        if (p + q + r <= s) return 1;

   
        if (p + q <= s && r <= s) return 2;
        if (p + r <= s && q <= s) return 2;
        if (q + r <= s && p <= s) return 2;

      
        return 3;
    }
}


//Process//
1. Input Reading:

The program reads 4 integers as input:

p, q, and r represent the sizes of the 3 diamond boxes.

s represents the size of the bag.

2. Function Used:

A function MinimumBagsRequired(int p, int q, int r, int s) is created.

This function returns an int representing the minimum number of bags required.

3. Main Logic:

The default assumption is that 3 bags are needed (i.e., one for each box).

Then the function checks the following conditions:

Condition 1 – All Boxes in One Bag:

If the total size p + q + r is less than or equal to s, then only 1 bag is needed.

if (p + q + r <= s) return 1;

Condition 2 – Two Boxes in One Bag, One in Another:

If any two boxes can fit together in one bag, and the third fits alone in another bag, then 2 bags are needed.

if (p + q <= s && r <= s) return 2;

if (p + r <= s && q <= s) return 2;

if (q + r <= s && p <= s) return 2;

Condition 3 – None Can Be Combined:

If no combination of two boxes can fit together within the bag limit, then 3 bags are needed (one for each box).

return 3;

Output:

The program prints: Minimum Bag is : followed by the result returned by the function.


