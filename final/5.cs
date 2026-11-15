using System;

class Person
{
    public string Name { get; set; }

    public Person(string name)
    {
        Name = name;
    }

    public override string ToString()
    {
        return $"Namn: {Name}";
    }
}

class Student : Person
{
    public Student(string name) : base(name) { }

    public void Study()
    {
        Console.WriteLine("Pluggar");
    }
}

class Teacher : Person
{
    public Teacher(string name) : base(name) { }

    public void Explain()
    {
        Console.WriteLine("Undervisar");
    }
}

class Program
{
    static void Main()
    {
        string name1 = Console.ReadLine();
        string name2 = Console.ReadLine();
        string name3 = Console.ReadLine();

        Person[] people = new Person[3];
        people[0] = new Teacher(name1);
        people[1] = new Student(name2);
        people[2] = new Student(name3);

        Teacher teacher = (Teacher)people[0];
        teacher.Explain();

        Student student1 = (Student)people[1];
        student1.Study();

        Student student2 = (Student)people[2];
        student2.Study();
    }
}
