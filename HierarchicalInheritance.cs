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
        Child1 c1 = new Child1();
        c1.ShowParent();
        c1.ShowChild1();

        Child2 c2 = new Child2();
