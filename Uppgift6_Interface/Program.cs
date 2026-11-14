using System;

class Program
{
    static void Main()
    {
        // Create car with 0 fuel
        Car myCar = new Car(0);

        // Ask user for fuel amount
        int fuelAmount = int.Parse(Console.ReadLine());

        // Refuel the car
        myCar.Refuel(fuelAmount);

        // Drive the car
        myCar.Drive();
    }
}
