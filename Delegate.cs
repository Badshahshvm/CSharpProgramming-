using System;

// Declare a delegate
delegate int ArithmeticOperation(int a, int b);

class Program
{
    // Methods matching the delegate signature
    public static int Add(int x, int y)
    {
        return x + y;
    }

    public static int Subtract(int x, int y)
    {
        return x - y;
    }

    public static int Multiply(int x, int y)
    {
        return x * y;
    }

    public static int Divide(int x, int y)
    {
        return y != 0 ? x / y : 0; // Avoid divide by zero
    }

    static void Main(string[] args)
    {
        int a = 20, b = 5;

        // Delegate instances
        ArithmeticOperation op;

        // Addition
        op = Add;
        Console.WriteLine("Addition: " + op(a, b));

        // Subtraction
        op = Subtract;
        Console.WriteLine("Subtraction: " + op(a, b));

        // Multiplication
        op = Multiply;
        Console.WriteLine("Multiplication: " + op(a, b));

        // Division
        op = Divide;
        Console.WriteLine("Division: " + op(a, b));
    }
}


// use delegate without creating instance of class

public delegate void show_delegate();

class Program
{
  public static void show()
  {
    Consoel.WriteLine("This is show method");
  }
  public static void Main(string[] args)
  {
    show_delegate s1=new show_delegate(show);
    s1.Invoke();
  }

}
