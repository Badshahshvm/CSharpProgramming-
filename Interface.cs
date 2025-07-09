using System;

interface IShape
{
    void Area();
    void Perimeter();
    void Draw();
    void Resize();
    void Rotate();
    void Move();
    void Color();
    void Fill();
}

class Circle : IShape
{
    public void Area() => Console.WriteLine("Area = πr²");
    public void Perimeter() => Console.WriteLine("Perimeter = 2πr");
    public void Draw() => Console.WriteLine("Drawing Circle");
    public void Resize() => Console.WriteLine("Resizing Circle");
    public void Rotate() => Console.WriteLine("Rotating Circle");
    public void Move() => Console.WriteLine("Moving Circle");
    public void Color() => Console.WriteLine("Coloring Circle");
    public void Fill() => Console.WriteLine("Filling Circle");
}

class Program
{
    public static void Main(string[] args)
    {
        IShape shape = new Circle();

        shape.Draw();
        shape.Area();
        shape.Perimeter();
        shape.Resize();
        shape.Rotate();
        shape.Move();
        shape.Color();
        shape.Fill();
    }
}
