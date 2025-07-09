using System;

class BasePrinter
{
    public virtual void Print(int a) => Console.WriteLine("Int: " + a);
    public virtual void Print(string s) => Console.WriteLine("String: " + s);
    public virtual void Print(double d) => Console.WriteLine("Double: " + d);
    public virtual void Print(int[] arr) => Console.WriteLine("Int Array: " + string.Join(",", arr));
    public virtual void Print(string[] arr) => Console.WriteLine("String Array: " + string.Join(",", arr));
    public virtual void Print(double[] arr) => Console.WriteLine("Double Array: " + string.Join(",", arr));
}

class DerivedPrinter : BasePrinter
{
    public override void Print(int a) => Console.WriteLine("Derived Int: " + a);
    public override void Print(string s) => Console.WriteLine("Derived String: " + s);
    public override void Print(double d) => Console.WriteLine("Derived Double: " + d);
    public override void Print(int[] arr) => Console.WriteLine("Derived Int Array: " + string.Join(" - ", arr));
    public override void Print(string[] arr) => Console.WriteLine("Derived String Array: " + string.Join(" - ", arr));
    public override void Print(double[] arr) => Console.WriteLine("Derived Double Array: " + string.Join(" - ", arr));
}

class Program
{
    public static void Main(string[] args)
    {
        // Base class reference to derived class object
        BasePrinter printer = new DerivedPrinter();

        printer.Print(10);
        printer.Print("Hello C#");
        printer.Print(3.14);

        printer.Print(new int[] { 1, 2, 3 });
        printer.Print(new string[] { "apple", "banana", "cherry" });
        printer.Print(new double[] { 1.1, 2.2, 3.3 });
    }
}
