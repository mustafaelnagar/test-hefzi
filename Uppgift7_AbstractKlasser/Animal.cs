using System;

abstract class Animal
{
    private string name;

    public void SetName(string n)
    {
        name = n;
    }

    public string GetName()
    {
        return name;
    }

    public abstract void Eat();
}
