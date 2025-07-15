
//First Why we need arraylist:-

class Program{
  static void Main(string[], args)
  {
    int []a=new int[3];
    a[0]=2;
    a[1]=3;
    a[2]=5;
    Array.resize(ref a,4);
    a[3]=8;
  }
  }

//Basics Of arrayList

using System;
using System.Collections;

class HelloWorld {
  static void Main() {
    ArrayList l1 = new ArrayList();

    Console.WriteLine("Initial Capacity: " + l1.Capacity);

    l1.Add(5);
    l1.Add("shivam");
    l1.Add('a');

    Console.WriteLine("Elements in ArrayList:");
    foreach (object sbj in l1)
    {
        Console.Write(sbj + " ");
    }
  }
}


//Insert an elemnt at any specific index in an arraylist
using System;
using System.Collections;

class HelloWorld {
  static void Main() {
    ArrayList l1 = new ArrayList();

    Console.WriteLine("Initial Capacity: " + l1.Capacity);

    l1.Add(5);
    l1.Add("shivam");
    l1.Add('a');

    Console.WriteLine("Elements in ArrayList:");
    foreach (object sbj in l1)
    {
        Console.Write(sbj + " ");
    }
    
    l1.Insert(2,56);
    Console.WriteLine();
    foreach (object sbj in l1)
    {
        Console.Write(sbj + " ");
    }
  }
}

//REmove elemnt from arraylist

using System.Collections;

class HelloWorld {
  static void Main() {
    ArrayList l1 = new ArrayList();

    Console.WriteLine("Initial Capacity: " + l1.Capacity);

    l1.Add(5);
    l1.Add("shivam");
    l1.Add('a');

    Console.WriteLine("Elements in ArrayList:");
    foreach (object sbj in l1)
    {
        Console.Write(sbj + " ");
    }
    
    l1.Insert(2,56);
    Console.WriteLine();
    foreach (object sbj in l1)
    {
        Console.Write(sbj + " ");
    }
    l1.Remove(56);
     Console.WriteLine();
    foreach (object sbj in l1)
    {
        Console.Write(sbj + " ");
    }
  }
}

//Remove ArrayList from any specific position in arraylist

using System.Collections;

class HelloWorld {
  static void Main() {
    ArrayList l1 = new ArrayList();

    Console.WriteLine("Initial Capacity: " + l1.Capacity);

    l1.Add(5);
    l1.Add("shivam");
    l1.Add('a');

    Console.WriteLine("Elements in ArrayList:");
    foreach (object sbj in l1)
    {
        Console.Write(sbj + " ");
    }
    
    l1.Insert(2,56);
    Console.WriteLine();
    foreach (object sbj in l1)
    {
        Console.Write(sbj + " ");
    }
    l1.RemoveAt(2);
     Console.WriteLine();
    foreach (object sbj in l1)
    {
        Console.Write(sbj + " ");
    }
  }
}


