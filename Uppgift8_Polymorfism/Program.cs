using System;

class Program
{
    static void Main()
    {
        Calculator calc = new Calculator();

        // Test Sum with integers
        calc.Sum(5, 4);

        // Test Sum with floats
        calc.Sum(9.3f, 8.6f);

        // Test Sum with strings
        calc.Sum("Hej världen", "test");

        // Test Ice Cream and Chocolate
        Chocolate choco = new Chocolate();
        choco.Flavor();
    }
}
