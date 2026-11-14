using System;

class Program
{
    static void Main()
    {
        // Test GenericClass
        GenericClass<string> gc = new GenericClass<string>();
        gc.msg = "Välkommen till ABF!";
        gc.GenericMethod<string, string>("Stina Persson", "Helsingborg");

        Console.WriteLine();

        // Test SampleClass
        SampleClass sc = new SampleClass();

        // Call with integers
        sc.Gmethod<int, int>(1, 2);

        // Call with strings
        sc.Gmethod<string, string>("Gabriel Ruis", "Säffle");
    }
}
