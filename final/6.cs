using System;

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
    }

    public bool Refuel(int amount)
    {
        fuel += amount;
        return true;
    }
}

Car myCar = new Car(0);
int fuelAmount = int.Parse(Console.ReadLine());
myCar.Refuel(fuelAmount);
myCar.Drive();
