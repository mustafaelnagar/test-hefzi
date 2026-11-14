using System;

class Program
{
    static void Main()
    {
        // Read 3 names from user
        string name1 = Console.ReadLine();
        string name2 = Console.ReadLine();
        string name3 = Console.ReadLine();

        // Create array with different types
        Person[] people = new Person[3];
        people[0] = new Teacher(name1);
        people[1] = new Student(name2);
        people[2] = new Student(name3);

        // Cast and call methods
        Teacher teacher = (Teacher)people[0];
        teacher.Explain();

        Student student1 = (Student)people[1];
        student1.Study();

        Student student2 = (Student)people[2];
        student2.Study();
    }
}
