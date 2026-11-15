using System;

// ============================================
// الواجب الثاني: البنائيات والمدمرات
// Assignment 2: Constructors & Destructors
// ============================================

class Person
{
    public string Name { get; set; }

    // Constructor - ينفذ عند إنشاء كائن جديد
    public Person(string name)
    {
        Name = name;
    }

    // Destructor - ينفذ عند حذف الكائن
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
            people[i] = new Person(name);  // Constructor ينفذ هنا
        }

        foreach (Person p in people)
        {
            Console.WriteLine(p);
        }
    }
}

/*
═══════════════════════════════════════════════
الفرق بين الواجب 1 و 2:

Task 1:
   Person p = new Person();
   p.Name = "Juan";

Task 2:
   Person p = new Person("Juan");

الفرق: في Task 2 نعيين الاسم أثناء الإنشاء مباشرة
═══════════════════════════════════════════════
*/
