//1D Array

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[] a = new int[5];

        Console.WriteLine("Enter 5 integers:");

        for (int i = 0; i < a.Length; i++)
        {
            Console.Write($"Enter value {i + 1}: ");
            a[i] = int.Parse(Console.ReadLine());
        }

        Console.WriteLine("\nThe entered values are:");
        foreach (int val in a)
        {
            Console.WriteLine(val);
        }
    }
}



//2D Arrays

using System;

public class HelloWorld
{
    public static void Main(string[] args)
    {
        int[,] a = new int[3, 5];  // 3 rows, 5 columns

        Console.WriteLine("Enter 15 integers (3 rows × 5 columns):");

        for (int i = 0; i < a.GetLength(0); i++)  // rows
        {
            for (int j = 0; j < a.GetLength(1); j++)  // columns
            {
                Console.Write($"Enter value for a[{i},{j}]: ");
                a[i, j] = int.Parse(Console.ReadLine());
            }
        }

        Console.WriteLine("\nThe entered 2D array is:");
        for (int i = 0; i < a.GetLength(0); i++)
        {
            for (int j = 0; j < a.GetLength(1); j++)
            {
                Console.Write(a[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}


//Reverse Array

class Program
{
    static void Reverse(int[] a)
    {
        int i = 0;
        int j = a.Length - 1;
        while (i < j)
        {
            int t = a[i];
            a[i] = a[j];
            a[j] = t;
            i++;
            j--;
        }
    }

    static void Main(string[] args)
    {
        int[] a = { 12, 34, 56, 78, 9 };

        Reverse(a);

        Console.WriteLine("Reversed array:");
        foreach (int val in a)
        {
            Console.Write(val + " ");
        }
    }
}


//Satic and Instance

class Company
{
  static string name="Mantar Softech pvt
;
  static void main(string [] args)
  {
    Comapny c1=new Comapny();
    Console.WriteLine(c1.name);
  }
}

