using System;

class SampleClass
{
    public void Gmethod<A, B>(A a, B b)
    {
        Console.WriteLine($"Param1: {a}");
        Console.WriteLine($"Param2: {b}");
    }
}
