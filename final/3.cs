using System;

class Person
{
    private string name;
    private int age;

    public string Name { get { return name; } set { name = value; } }
    public int Age { get { return age; } }

    public void Greet()
    {
        Console.WriteLine("Hej!");
    }

    public void SetAge(int age)
    {
        this.age = age;
    }
}

class Student : Person
{
    public void Study()
    {
        Console.WriteLine("Jag pluggar!");
    }
}

class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("Jag förklarar");
    }
}

class Program
{
    static void Main()
    {
        Person p1 = new Person();
        p1.Greet();

        Student s1 = new Student();
        s1.SetAge(21);
        s1.Greet();
        Console.WriteLine($"Jag är {s1.Age} år gammal");
        s1.Study();

        Teacher t1 = new Teacher();
        t1.SetAge(40);
        t1.Greet();
        t1.Explain();
    }
}
