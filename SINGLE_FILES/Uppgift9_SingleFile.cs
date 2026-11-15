using System;

// ============================================
// الواجب التاسع: الفئات العامة
// Assignment 9: Generic Classes
// ============================================

class GenericClass<T>
{
    public T msg;

    public void GenericMethod<TName, TLocation>(TName name, TLocation location)
    {
        Console.WriteLine(msg);
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Location: {location}");
    }
}

class SampleClass
{
    public void Gmethod<A, B>(A a, B b)
    {
        Console.WriteLine($"Param1: {a}");
        Console.WriteLine($"Param2: {b}");
    }
}

class Program
{
    static void Main()
    {
        // Test 1: GenericClass<string>
        GenericClass<string> gc = new GenericClass<string>();
        gc.msg = "Välkommen till ABF!";
        gc.GenericMethod<string, string>("Stina Persson", "Helsingborg");

        Console.WriteLine();

        // Test 2: SampleClass
        SampleClass sc = new SampleClass();

        // Gmethod مع Int
        sc.Gmethod<int, int>(1, 2);

        // Gmethod مع String
        sc.Gmethod<string, string>("Gabriel Ruis", "Säffle");
    }
}
