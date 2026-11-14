using System;

class Calculator
{
    // Sum for integers
    public void Sum(int a, int b)
    {
        int result = a + b;
        Console.WriteLine($"Summan av {a} och {b} är {result}");
    }

    // Sum for floats
    public void Sum(float a, float b)
    {
        float result = a + b;
        Console.WriteLine($"Summan av {a} och {b} är {result}");
    }

    // Sum for strings
    public void Sum(string a, string b)
    {
        Console.WriteLine($"{a} - är inte numeriskt");
    }
}
