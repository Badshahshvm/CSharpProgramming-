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

//How to handle format exception :-



class HelloWorld
{
    static void Main()
    {
        string num = Console.ReadLine();

        try
        {
            int a = int.Parse(num); 
            Console.WriteLine(a);   
        }
        catch (FormatException)
        {
            Console.WriteLine("Format is invalid");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Number is too large or too small");
        }
    }
}
//try with multiple` catch blocks :-


class HelloWorld
{
    static void Main()
    {
        try
        {
            int a = 10;
            int b = 0;
            int c = a / b;
        }
        catch (DivideByZeroException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }
}

//Finally Block always execute whether exception occur or not :-


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
