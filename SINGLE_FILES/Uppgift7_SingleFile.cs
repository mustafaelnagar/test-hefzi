using System;

// ============================================
// الواجب السابع: الفئات المجردة
// Assignment 7: Abstract Classes
// ============================================

abstract class Animal
{
    private string name;

    public void SetName(string n)
    {
        name = n;
    }

    public string GetName()
    {
        return name;
    }

    public abstract void Eat();
}

class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Äter");
    }
}

class Program
{
    static void Main()
    {
        string dogName = Console.ReadLine();

        Dog myDog = new Dog();
        myDog.SetName(dogName);

        Console.WriteLine(myDog.GetName());
        myDog.Eat();
    }
}
