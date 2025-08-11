Task
Harish wants to generate some prime numbers for his mobile development.we’re providing for development.our task is to produce all prime numbers between two given numbers.
Input 
first line cover t, the number of test cases (less then or equal to 10). Followed by t lines which contain two numbers m and n (1 <= m <= n <= 1000000000, n-m<=100000) separated by a space.
Output 
For every test case print all prime numbers p such that m <= p <= n, one number per line. Separate the answers for each test case by an empty line.
Sample Input
2
1 10
3 5
Sample Output
2
3
5
7

3
5

/////Solution/////
class Solution {
    public int countPrimesInRange(int p, int q) {
        if (q < 2) return 0; // No primes less than 2

        // Sieve up to q
        boolean[] isPrime = new boolean[q + 1];
        
        // Assume all numbers are prime initially (except 0 and 1)
        for (int i = 2; i <= q; i++) {
            isPrime[i] = true;
        }

        // Sieve of Eratosthenes
        for (int i = 2; i * i <= q; i++) {
            if (isPrime[i]) {
                for (int j = i * i; j <= q; j += i) {
                    isPrime[j] = false;
                }
            }
        }

        // Count primes in the range [p, q]
        int count = 0;
        for (int i = Math.max(2, p); i <= q; i++) {
            if (isPrime[i]) {
                count++;
            }
        }
        return count;
    }

    public static void main(String[] args) {
        Solution sol = new Solution();
        int p = 10, q = 50;
        System.out.println("Number of primes between " + p + " and " + q + " = " + sol.countPrimesInRange(p, q));
    }
}
