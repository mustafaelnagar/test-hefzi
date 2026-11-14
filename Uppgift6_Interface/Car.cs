using System;

class Car : IVehicle
{
    private int fuel;

    public Car(int initialFuel)
    {
        fuel = initialFuel;
    }

    public void Drive()
    {
        if (fuel > 0)
        {
            Console.WriteLine("Kör");
        }
        else
        {
            Console.WriteLine("Ingen bränsle!");
        }
    }

    public bool Refuel(int amount)
    {
        fuel += amount;
        return true;
    }
}
