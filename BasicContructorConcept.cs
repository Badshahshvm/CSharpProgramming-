using System;

//Constructor
class Student
{
    public string name;
    public int rollNo;

    // Default constructor
    public Student()
    {
        name = "Unknown";
        rollNo = 0;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {name}, Roll No: {rollNo}");
    }

    static void Main(string[] args)
    {
        Student s1 = new Student();
        s1.Display(); // Output: Name: Unknown, Roll No: 0
    }
}

//Parametrized Constructor

class Student
{
    public string name;
    public int rollNo;

    // Parameterized constructor
    public Student(string studentName, int studentRollNo)
    {
        name = studentName;
        rollNo = studentRollNo;
    }

    public void Display()
    {
        Console.WriteLine($"Name: {name}, Roll No: {rollNo}");
    }

    static void Main(string[] args)
    {
        Student s1 = new Student("Shivam", 101);
        s1.Display(); // Output: Name: Shivam, Roll No: 101
    }
}


//Copy Constructor

class Student{
    string name;
    int age;
    public Student(string name, int age)
    {
        this.name=name;
        this.age=age;
        
    }
    //Copy Constructor
    public Student(Student s1)
    {
        this.name=s1.name;
        this.age=s1.age;
    }
    public void getData()
    {
        Console.WriteLine(name);
        Console.WriteLine(age);
    }
}
class HelloWorld {
  static void Main() {
    Console.WriteLine("Hello World");
    Student s2=new Student("shivam",22);
    s2.getData();
    Student s3=new Student("Prince",25);
    s3.getData();
  }
}


//Private Constructor

class privateConstructor{
    public static int a;
    private privateConstructor()
    {
        
    }
    public static int getIncrement()
    {
        return ++a;
    }
}
class HelloWorld {
  static void Main() {
      Console.WriteLine(privateConstructor.getIncrement());
   
  }
}


// Static Constructor 


class StaticConstructorDemo
{
    public static string name;
    public static int age;

    // Static constructor
    static StaticConstructorDemo()
    {
        name = "Shivam";
        age = 20;
        Console.WriteLine("Static Constructor is invoked!!!");
    }

    // Default (instance) constructor
    public StaticConstructorDemo()
    {
        Console.WriteLine("Default Constructor is called!!!");
    }
}

class HelloWorld
{
    static void Main()
    {
        StaticConstructorDemo s1 = new StaticConstructorDemo();
    }
}

