using System;

class Student
{
    private string name;
    private int age;

    public void SetData(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    public string GetName() => name;
    public int GetAge() => age;
}

class Teacher
{
    private string subject;

    public void SetSubject(string sub) => subject = sub;
    public string GetSubject() => subject;
}

class Course
{
    private string courseName;
    private int duration;

    public void SetCourse(string name, int duration)
    {
        courseName = name;
        this.duration = duration;
    }

    public void ShowCourse()
    {
        Console.WriteLine($"Course: {courseName}, Duration: {duration} months");
    }
}

class Program
{
    public static void Main()
    {
        Student s = new Student();
        s.SetData("Shivam", 22);
        Console.WriteLine($"Student: {s.GetName()}, Age: {s.GetAge()}");

        Teacher t = new Teacher();
        t.SetSubject("Maths");
        Console.WriteLine($"Subject: {t.GetSubject()}");

        Course c = new Course();
        c.SetCourse("C#", 3);
        c.ShowCourse();
    }
}
