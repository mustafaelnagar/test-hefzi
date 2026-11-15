using System;

// ============================================
// الواجب السادس: الواجهات
// Assignment 6: Interfaces
// ============================================

interface IVehicle
{
    void Drive();
    bool Refuel(int amount);
}

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

class Program
{
    static void Main()
    {
        Car myCar = new Car(0);

        int fuelAmount = int.Parse(Console.ReadLine());

        myCar.Refuel(fuelAmount);

        myCar.Drive();
    }
}
