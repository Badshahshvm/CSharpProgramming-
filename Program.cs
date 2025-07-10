using System;

#region Abstraction
// Abstract class (Abstraction)
abstract class Project
{
    public string ProjectName { get; set; }

    public Project(string name)
    {
        ProjectName = name;
    }

    // Abstract method
    public abstract void StartProject();
}
#endregion

#region Encapsulation
// Encapsulated class
class ClientProject : Project
{
    private double budget; // sensitive info

    public ClientProject(string name, double budget) : base(name)
    {
        this.budget = budget;
    }

    // Public getter/setter to access budget safely
    public void SetBudget(double value)
    {
        if (value > 0)
            budget = value;
    }

    public double GetBudget()
    {
        return budget;
    }

    // Overriding abstract method
    public override void StartProject()
    {
        Console.WriteLine($"Project '{ProjectName}' has been initiated for the client.");
    }
}
#endregion

#region Inheritance + Polymorphism
// Base class
class Employee
{
    protected string name;
    protected int id;

    public Employee(string name, int id)
    {
        this.name = name;
        this.id = id;
    }

    public virtual void Work()
    {
        Console.WriteLine($"{name} (ID: {id}) is working.");
    }
}

// Derived class
class Developer : Employee
{
    private string techStack;

    public Developer(string name, int id, string techStack) : base(name, id)
    {
        this.techStack = techStack;
    }

    public override void Work()
    {
        Console.WriteLine($"{name} is coding in {techStack}.");
    }
}
#endregion

#region Program Execution
class Program
{
    static void Main(string[] args)
    {
        // Polymorphism and Inheritance
        Employee e1 = new Employee("Shivam", 18078);
        e1.Work();

        Developer d1 = new Developer("Shivam", 18078, "C#");
        d1.Work();

        // Encapsulation + Abstraction
        ClientProject project = new ClientProject("FinTech App", 500000);
        project.StartProject();
        Console.WriteLine($"Budget: ₹{project.GetBudget()}");

        // Trying to set a new budget
        project.SetBudget(600000);
        Console.WriteLine($"Updated Budget: ₹{project.GetBudget()}");
    }
}
#endregion
