//Exception Handling :-


//An exception ia an event, which occur during the exceution f program that disrupts the normal flow of the program's instructions.

using System;

class HelloWorld
{
    static void Main()
    {
        try
        {
            Console.Write("Enter first number: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Enter second number: ");
            int num2 = int.Parse(Console.ReadLine());

            int result = num1 / num2;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: You cannot divide by zero.");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid numbers.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Unexpected error: " + ex.Message);
        }
        finally
        {
            Console.WriteLine("Program finished.");
        }
    }
}
//Handling Index Out Of Range Exception :-
/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;

using System;

class HelloWorld
{
    static void Main()
    {
        int[] a = new int[3];

        try
        {
            a[0] = 1;
            a[1] = 2;
            a[2] = 3;
            a[3] = 56; // This will throw IndexOutOfRangeException

            foreach (int i in a)
            {
                Console.WriteLine(i);
            }
        }
        catch (IndexOutOfRangeException e)
        {
            Console.WriteLine("Index not found...");
        }
    }
}


//Handling Null Reference Exception in c#

class HelloWorld
{
    static void Main()
    {
        
        try
        {string name=null;
        Console.WriteLine(name.Length);
            
        }
        catch(NullReferenceException e)
        {
            Console.WriteLine("String is null");
        }

       
    }
}

