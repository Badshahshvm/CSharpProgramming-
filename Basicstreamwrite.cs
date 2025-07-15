//1. Simple Example of StreamWriter (Write to File

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"D:\example.txt";

        StreamWriter writer = new StreamWriter(path, true); // append = true
        writer.WriteLine("Hello Shivam, this is written using StreamWriter.");
        writer.Close();

        Console.WriteLine("Text written successfully.");
    }
}


//2. Read from File

using System;
using System.IO;

class Program
{
    static void Main()
    {
        string path = @"D:\example.txt";

        StreamReader reader = new StreamReader(path);
        string content = reader.ReadToEnd();
        reader.Close();

        Console.WriteLine("File content:");
        Console.WriteLine(content);
    }
}

//3. Using out to Return Multiple Values from a Method


class Program
{
    static void Main()
    {
        int a, b;
        GetValues(out a, out b);
        Console.WriteLine($"Values are: a = {a}, b = {b}");
    }

    static void GetValues(out int x, out int y)
    {
        x = 10;
        y = 20;
    }
}

//4. Using ref to Modify the Original Variable


class Program
{
    static void Main()
    {
        int number = 5;
        MultiplyByTwo(ref number);
        Console.WriteLine("Number after ref call: " + number);
    }

    static void MultiplyByTwo(ref int n)
    {
        n = n * 2;
    }
}

//5. Using Both ref and out Together


class Program
{
    static void Main()
    {
        int original = 10;
        int result;

        Process(ref original, out result);
        Console.WriteLine($"Original: {original}, Result: {result}");
    }

    static void Process(ref int x, out int y)
    {
        x = x + 5;
        y = x * 2;
    }
}
