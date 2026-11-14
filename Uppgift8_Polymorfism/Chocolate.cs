using System;

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
