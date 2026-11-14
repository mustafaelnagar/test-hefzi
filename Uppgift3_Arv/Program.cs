using System;

class Program
{
    static void Main()
    {
        // Create a person
        Person p1 = new Person();
        p1.Greet();

        // Create a student
        Student s1 = new Student();
        s1.SetAge(21);
        s1.Greet();
        Console.WriteLine($"Jag är {s1.Age} år gammal");
        s1.Study();

        // Create a teacher
        Teacher t1 = new Teacher();
        t1.SetAge(40);
        t1.Greet();
        t1.Explain();
    }
}
