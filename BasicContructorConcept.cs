using System;

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

using System;

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
