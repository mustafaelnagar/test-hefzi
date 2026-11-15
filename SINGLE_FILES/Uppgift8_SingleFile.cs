using System;

// ============================================
// الواجب الثامن: تعدد الأشكال
// Assignment 8: Polymorphism
// ============================================

class Calculator
{
    public void Sum(int a, int b)
    {
        int result = a + b;
        Console.WriteLine($"Summan av {a} och {b} är {result}");
    }

    public void Sum(float a, float b)
    {
        float result = a + b;
        Console.WriteLine($"Summan av {a} och {b} är {result}");
    }

    public void Sum(string a, string b)
    {
        Console.WriteLine($"{a} - är inte numeriskt");
    }
}

class IceCream
{
    public IceCream()
    {
        Console.WriteLine("Class : Icecream");
    }

    public virtual void Flavor()
    {
        Console.WriteLine("IceCream Type : Vanilj");
    }
}

class Chocolate : IceCream
{
    public Chocolate()
    {
        Console.WriteLine("Class : Chocolate");
    }

    public override void Flavor()
    {
        Console.WriteLine("IceCream Type : Chocolate");
    }
}

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        calc.Sum(5, 4);

        calc.Sum(9.3f, 8.6f);

        calc.Sum("Hej världen", "test");

        Chocolate choco = new Chocolate();
        choco.Flavor();
    }
}
