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

class Program
{
    static void Main()
    {
        Person[] people = new Person[3];

        for (int i = 0; i < 3; i++)
        {
            string name = Console.ReadLine();
            people[i] = new Person(name);
        }

        foreach (Person p in people)
        {
            Console.WriteLine(p);
        }
    }
}
