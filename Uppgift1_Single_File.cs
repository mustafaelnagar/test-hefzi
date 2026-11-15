using System;

// ============================================
// الواجب الأول: الفئات والتوابع
// Assignment 1: Classes & ToString()
// ============================================

// الفئة Person
class Person
{
    public string Name { get; set; }

    // استبدال التابع ToString
    public override string ToString()
    {
        return $"Hej! Jag heter {Name}";
    }
}

// البرنامج الرئيسي
class Program
{
    static void Main()
    {
        // إنشاء مصفوفة لحفظ 3 أشخاص
        Person[] people = new Person[3];

        // قراءة 3 أسماء من المستخدم
        for (int i = 0; i < 3; i++)
        {
            Person p = new Person();
            p.Name = Console.ReadLine();
            people[i] = p;
        }

        // طباعة الأشخاص باستخدام ToString()
        foreach (Person p in people)
        {
            Console.WriteLine(p);
        }
    }
}

/*
═══════════════════════════════════════════════
شرح الكود | Code Explanation
═══════════════════════════════════════════════

1. الفئة Person:
   - خاصية Name لحفظ اسم الشخص
   - تابع ToString() مخصص يرجع رسالة

2. البرنامج الرئيسي:
   - إنشاء مصفوفة Person بـ 3 عناصر
   - حلقة لقراءة 3 أسماء
   - حلقة لطباعة الأسماء

3. المدخلات:
   Juan
   Sara
   Kalle

4. المخرجات:
   Hej! Jag heter Juan
   Hej! Jag heter Sara
   Hej! Jag heter Kalle

═══════════════════════════════════════════════
*/
