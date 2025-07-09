using System;

interface IWork
{
    void DoWork();
}

interface IPlay
{
    void DoPlay();
}

class Robot : IWork, IPlay
{
    public void DoWork() => Console.WriteLine("Robot is working...");
    public void DoPlay() => Console.WriteLine("Robot is playing...");
}

class Program
{
    public static void Main()
    {
        Robot r = new Robot();
        r.DoWork();
        r.DoPlay();
    }
}
