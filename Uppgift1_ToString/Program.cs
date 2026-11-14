using System;

class Program
{
    static void Main()
    {
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
    }
}
