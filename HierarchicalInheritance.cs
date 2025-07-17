using System;

class Parent
{
    public void ShowParent() => Console.WriteLine("Parent class method");
}

class Child1 : Parent
{
    public void ShowChild1() => Console.WriteLine("Child1 class method");
}

class Child2 : Parent
{
    public void ShowChild2() => Console.WriteLine("Child2 class method");
}

class Program
{
    public static void Main()
    {
        // Creating object of Child1
        Child1 c1 = new Child1();
        c1.ShowParent();     // Accessing Parent method
        c1.ShowChild1();     // Accessing Child1 method

        Console.WriteLine();

        // Creating object of Child2
        Child2 c2 = new Child2();
        c2.ShowParent();     // Accessing Parent method
        c2.ShowChild2();     // Accessing Child2 method
    }
}
