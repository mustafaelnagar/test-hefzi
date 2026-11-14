using System;

class Person
{
    private string name;
    private int age;

    public Person()
    {
        name = "";
        age = 0;
    }

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public int Age
    {
        get { return age; }
    }

    public void Greet()
    {
        Console.WriteLine("Hej!");
    }

    public void SetAge(int age)
    {
        this.age = age;
    }
}
