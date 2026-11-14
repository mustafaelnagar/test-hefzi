using System;

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
