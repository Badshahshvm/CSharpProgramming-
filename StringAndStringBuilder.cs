//String Concatenation 

class Program
{
    static void Main()
    {
        string fname = "Shivam";
        string lname = "Kumar";
        string fullname = fname + " " + lname;
        Console.WriteLine("Full Name: " + fullname);
    }
}

// String Methods (Length, ToUpper, ToLower, Contains)

class Program
{
    static void Main()
    {
        string message = "Hello Mantra Softech";

        Console.WriteLine("Length: " + message.Length);
        Console.WriteLine("Uppercase: " + message.ToUpper());
        Console.WriteLine("Lowercase: " + message.ToLower());
        Console.WriteLine("Contains 'Mantra': " + message.Contains("Mantra"));
    }
}

// StringBuilder
using System.Text;

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder();

        for (int i = 1; i <= 5; i++)
        {
            sb.Append("Number " + i + " ");
        }

        Console.WriteLine(sb.ToString());
    }
}

//StringBuilder – Insert, Replace, Remove

class Program
{
    static void Main()
    {
        StringBuilder sb = new StringBuilder("Hello World");

        sb.Insert(6, "C# ");
        sb.Replace("World", "Developers");
        sb.Remove(0, 6);

        Console.WriteLine("Modified StringBuilder: " + sb);
    }
}
