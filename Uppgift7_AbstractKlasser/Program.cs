using System;

class Program
{
    static void Main()
    {
        // Ask user for dog name
        string dogName = Console.ReadLine();

        // Create dog and set name
        Dog myDog = new Dog();
        myDog.SetName(dogName);

        // Call methods
        Console.WriteLine(myDog.GetName());
        myDog.Eat();
    }
}
