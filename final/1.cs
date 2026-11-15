using System;

class Person
{
    public string Name { get; set; }

    public override string ToString()
    {
        return $"Hej! Jag heter {Name}";
    }
}

Person[] people = new Person[3];

for (int i = 0; i < 3; i++)
{
    Person p = new Person();
    p.Name = Console.ReadLine();
    people[i] = p;
}

foreach (Person p in people)
{
    Console.WriteLine(p);
}
