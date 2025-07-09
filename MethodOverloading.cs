// Online C# Editor for free
// Write, Edit and Run your C# code using C# Online Compiler

using System;

public class HelloWorld
{
    // Method Overloading for Sum
    public int Sum(int a, int b) => a + b;
    public double Sum(double a, double b) => a + b;
    public int Sum(int a, int b, int c) => a + b + c;

    // Method Overloading for Subtraction
    public int Sub(int a, int b) => a - b;
    public double Sub(double a, double b) => a - b;
    public int Sub(int a, int b, int c) => a - b - c;

    // Method Overloading for Multiplication
    public int Mul(int a, int b) => a * b;
    public double Mul(double a, double b) => a * b;
    public int Mul(int a, int b, int c) => a * b * c;

    // Method Overloading for Division
    public int Div(int a, int b) => a / b;
    public double Div(double a, double b) => a / b;
    public double Div(int a, int b, int c) => (double)a / b / c;

    public static void Main(string[] args)
    {
        HelloWorld calc = new HelloWorld();

        Console.WriteLine("Sum (int, int): " + calc.Sum(5, 10));
        Console.WriteLine("Sum (double, double): " + calc.Sum(5.5, 3.2));
        Console.WriteLine("Sum (int, int, int): " + calc.Sum(1, 2, 3));

        Console.WriteLine("Sub (int, int): " + calc.Sub(10, 3));
        Console.WriteLine("Mul (int, int): " + calc.Mul(4, 5));
        Console.WriteLine("Div (int, int): " + calc.Div(20, 4));
    }
}
