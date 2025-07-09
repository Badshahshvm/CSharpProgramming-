using System;

abstract class Animal
{
    public abstract void Sound();     // Abstract method
    public void Sleep() => Console.WriteLine("Sleeping..."); // Concrete method
}

class Dog : Animal
{
    public override void Sound() => Console.WriteLine("Bark!");
}

class Program
{
    public static void Main(string[] args)
    {
        Animal pet = new Dog();
        pet.Sound();  // Output: Bark!
        pet.Sleep();  // Output: Sleeping...
    }
}
