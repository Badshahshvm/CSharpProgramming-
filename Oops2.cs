//Polumorphism Eample & Inheriytance:-

using System;

class Employee
{
    // Field declaration
    protected string name;
    protected int id;

    // Constructor
    public Employee(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    // Virtual method (for polymorphism)
    public virtual void Work()
    {
        Console.WriteLine($"{name} (ID: {id}) is working.");
    }
}

class Developer : Employee
{
    private string techStack;

    // Constructor with base keyword (C# equivalent of super)
    public Developer(string name, int id, string techStack) : base(name, id)
    {
        this.techStack = techStack;
    }

    // Method override
    public override void Work()
    {
        Console.WriteLine($"{name} is coding in {techStack}.");
    }
}

class Program
{
    static void Main(string[] args)
    {
        Employee e1 = new Employee("Shivam", 18078);
        e1.Work();

        Developer d1 = new Developer("Shivam", 18078, "C#");
        d1.Work();
    }
}
