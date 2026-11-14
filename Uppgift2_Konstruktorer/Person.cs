using System;

class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    ~Person()
    {
        Name = "";
    }

    public override string ToString()
    {
        return $"Hej! Jag heter {Name}";
    }
}
