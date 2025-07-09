using System;

class A
{
    public void ShowA() => Console.WriteLine("Class A method");
}

class B : A
{
    public void ShowB() => Console.WriteLine("Class B method");
}

class C : B
{
    public void ShowC() => Console.WriteLine("Class C method");
}

class Program
{
    public static void Main()
    {
        C obj = new C();
        obj.ShowA();
        obj.ShowB();
        obj.ShowC();
    }
}
