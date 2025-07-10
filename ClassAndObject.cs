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


    public void Work()
    {
        Console.WriteLine($"{name} (ID: {id}) is working.");
    }
}


class Program
{
  static void Main(string[] args)
  {
    Employee e1=new Employee("Shivam", 18078);
    e1.work();
  }
  
}
