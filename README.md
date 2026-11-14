# OOP Assignments - Object Oriented Programming في C#

## شرح عام | General Overview

هذا المشروع يحتوي على 9 تمارين برمجية لتعليم مفاهيم البرمجة الموجهة للكائنات (OOP) باستخدام لغة C#.

**This project contains 9 programming assignments to teach Object-Oriented Programming (OOP) concepts using C#.**

---

## كيفية التشغيل | How to Run

### المتطلبات | Requirements
- .NET 6.0 SDK أو أحدث | .NET 6.0 SDK or higher
- Visual Studio أو Visual Studio Code | Visual Studio or Visual Studio Code

### خطوات التشغيل | Steps to Run

#### 1. فتح المشروع | Open the Project
```bash
# استنساخ أو فتح المشروع
cd OOP_Assignments

# فتح الحل في Visual Studio
start OOP_Assignments.sln
```

#### 2. اختيار المشروع المراد تشغيله | Select Project to Run
كل تمرين في مشروع منفصل | Each assignment is in a separate project:

```bash
# تشغيل Uppgift1 (Task 1)
cd Uppgift1_ToString
dotnet run
```

#### 3. بناء وتشغيل من سطر الأوامر | Build and Run from Command Line
```bash
# بناء جميع المشاريع
dotnet build

# تشغيل مشروع محدد
dotnet run --project Uppgift1_ToString/Uppgift1_ToString.csproj

# أو بعد الدخول للمجلد
cd Uppgift1_ToString
dotnet run
```

---

## وصف التمارين | Assignments Description

### ✅ Uppgift 1: Första klassen och metoden ToString()
**الموضوع: الفئات الأساسية و ToString**

#### شرح عربي | Arabic Explanation
```
هذا التمرين يعلمك كيفية إنشاء فئة بسيطة (Class) في C#
- إنشاء فئة Person مع خاصية Name من نوع string
- إضافة method toString() لإرجاع نص يمثل الكائن
- قراءة 3 أسماء من المستخدم وحفظها في array
- طباعة الأسماء باستخدام toString()
```

#### How it works
- Creates a Person class with a Name property
- Overrides ToString() method to return custom string
- Takes 3 names as input
- Displays each person with customized message

**Input:** Juan, Sara, Kalle  
**Output:**
```
Hej! Jag heter Juan
Hej! Jag heter Sara
Hej! Jag heter Kalle
```

**التشغيل | To Run:**
```bash
cd Uppgift1_ToString
dotnet run
```

---

### ✅ Uppgift 2: Konstruktorer och destruktorer
**الموضوع: بناء الكائنات والمدمرات**

#### شرح عربي | Arabic Explanation
```
يتعلم الطالب الفرق بين Constructor و Destructor:
- Constructor: يعمل عند إنشاء كائن جديد (مثل تشغيل الجهاز)
- Destructor: يعمل عند حذف الكائن من الذاكرة (مثل إيقاف الجهاز)
- نفس وظيفة Uppgift 1 لكن مع استخدام Constructor
```

#### How it works
- Person class with a Constructor that initializes Name
- Destructor that clears the Name when object is destroyed
- Same input/output as Task 1

**Input:** Juan, Sara, Kalle  
**Output:**
```
Hej! Jag heter Juan
Hej! Jag heter Sara
Hej! Jag heter Kalle
```

**التشغيل | To Run:**
```bash
cd Uppgift2_Konstruktorer
dotnet run
```

---

### ✅ Uppgift 3: Klasser för person, student och lärare
**الموضوع: الوراثة (Inheritance) - المستوى الأول**

#### شرح عربي | Arabic Explanation
```
مفهوم الوراثة (Inheritance):
- Person هي الفئة الأساسية (Parent Class) بها:
  - Greet(): طريقة للتحية
  - SetAge(): تعيين العمر
- Student ترث من Person وتضيف Study()
- Teacher ترث من Person وتضيف Explain()
- البرنامج ينشئ كائنات من الثلاث فئات ويستدعي الدوال
```

#### How it works
- Person: Base class with Greet() and SetAge()
- Student: Inherits Person, adds Study()
- Teacher: Inherits Person, adds Explain()
- Main creates instances and demonstrates polymorphism

**Output:**
```
Hej!
Hej!
Jag är 21 år gammal
Jag pluggar!
Hej!
Jag förklarar
```

**التشغيل | To Run:**
```bash
cd Uppgift3_Arv
dotnet run
```

---

### ✅ Uppgift 4: Fotoalbum
**الموضوع: Constructor متعدد و Inheritance**

#### شرح عربي | Arabic Explanation
```
يتعلم الطالب عن Constructors متعددة:
- PhotoBook بها constructor بدون معاملات (default = 16 صفحة)
- PhotoBook بها constructor مع معاملات (عدد الصفحات)
- BigPhotoBook ترث من PhotoBook مع 64 صفحة افتراضية
```

#### How it works
- PhotoBook class with two constructors
- Default constructor: 16 pages
- Custom constructor: any number of pages
- BigPhotoBook inherits and sets 64 pages by default

**Output:**
```
16
24
64
```

**التشغيل | To Run:**
```bash
cd Uppgift4_Fotoalbum
dotnet run
```

---

### ✅ Uppgift 5: Arv (Inheritance - Advanced)
**الموضوع: الوراثة مع Type Casting**

#### شرح عربي | Arabic Explanation
```
تطبيق متقدم للوراثة:
- قراءة 3 أسماء من المستخدم
- إنشاء Teacher واحد و Student اثنين
- استخدام Array من نوع Person
- استخدام Type Casting لتحويل الكائنات
```

#### How it works
- Person base class with Name and ToString()
- Student and Teacher inherit from Person
- Array of Person type containing different derived types
- Casting to call specific methods

**Input:** Juan, Sara, Kalle  
**Output:**
```
Undervisar
Pluggar
Pluggar
```

**التشغيل | To Run:**
```bash
cd Uppgift5_Arv2
dotnet run
```

---

### ✅ Uppgift 6: Interface
**الموضوع: الواجهات (Interfaces)**

#### شرح عربي | Arabic Explanation
```
مفهوم Interface:
- Interface (واجهة) تحدد العمليات التي يجب أن تنفذها الفئة
- IVehicle interface بها Drive() و Refuel()
- Car class تنفذ IVehicle
- البرنامج ينشئ سيارة وتضيف بنزين وتركضها
```

#### How it works
- IVehicle interface with Drive() and Refuel()
- Car implements the interface
- Car has fuel tracking
- Drive only works if fuel > 0

**Input:** 50  
**Output:**
```
Kör
```

**التشغيل | To Run:**
```bash
cd Uppgift6_Interface
dotnet run
```

---

### ✅ Uppgift 7: Abstrakta klasser
**الموضوع: الفئات المجردة (Abstract Classes)**

#### شرح عربي | Arabic Explanation
```
الفئات المجردة (Abstract Classes):
- Animal فئة مجردة (لا يمكن إنشاء كائن منها مباشرة)
- بها دالة مجردة Eat() يجب تنفيذها في الفئات الوارثة
- Dog ترث من Animal وتنفذ Eat()
- لا تستطيع كتابة: Animal a = new Animal() لكن تستطيع Dog d = new Dog()
```

#### How it works
- Abstract Animal class with abstract Eat() method
- Dog implements the abstract method
- SetName() and GetName() for managing dog's name
- User input determines dog's name

**Input:** Lufsen  
**Output:**
```
Lufsen
Äter
```

**التشغيل | To Run:**
```bash
cd Uppgift7_AbstractKlasser
dotnet run
```

---

### ✅ Uppgift 8: Polymorfism
**الموضوع: تعدد الأشكال (Polymorphism)**

#### شرح عربي | Arabic Explanation
```
تعدد الأشكال (Polymorphism):
1. Method Overloading: نفس اسم الدالة مع معاملات مختلفة
   - Sum(int, int)
   - Sum(float, float)
   - Sum(string, string)
2. Method Overriding: استبدال دالة من الفئة الأساسية
   - IceCream.Flavor() و Chocolate.Flavor()
```

#### How it works
- Calculator class with overloaded Sum() methods
- Handles int, float, and string types differently
- IceCream base class with virtual Flavor()
- Chocolate overrides Flavor()

**Output:**
```
Summan av 5 och 4 är 9
Summan av 9,3 och 8,6 är 17,900002
Hej världen - är inte numeriskt
Class : Icecream
Class : Chocolate
IceCream Type : Chocolate
```

**التشغيل | To Run:**
```bash
cd Uppgift8_Polymorfism
dotnet run
```

---

### ✅ Uppgift 9: Generiska klasser och metoder
**الموضوع: الفئات والدوال العامة (Generics)**

#### شرح عربي | Arabic Explanation
```
الدوال العامة (Generics) - <T>:
- T تمثل أي نوع بيانات (كل ما تريده!)
- GenericClass<T> تستقبل أي نوع: string, int, double, etc.
- GenericMethod<TName, TLocation> بمعاملات نوع مختلفة
- تجنب كتابة نفس الكود لأنواع مختلفة
```

#### How it works
- GenericClass<T> with generic method
- SampleClass with generic method Gmethod
- Can work with any data type
- Demonstrates type flexibility

**Output:**
```
Välkommen till ABF!
Name: Stina Persson
Location: Helsingborg
Param1: 1
Param2: 2
Param1: Gabriel Ruis
Param2: Säffle
```

**التشغيل | To Run:**
```bash
cd Uppgift9_Generiska
dotnet run
```

---

## معايير التصحيح | Grading Criteria

- ✅ تم تنفيذ جميع 9 تمارين | All 9 assignments implemented
- ✅ الكود يعمل وينتج النتائج الصحيحة | Code runs and produces correct output
- ✅ استخدام صحيح لمفاهيم OOP | Correct use of OOP concepts
- ✅ الكود يشبه عمل طالب عادي، ليس احترافي | Code looks like normal student work
- ✅ التعليقات والتنسيق جيد | Good comments and formatting

---

## نصائح مفيدة | Helpful Tips

### كلمات رئيسية في C# | C# Keywords
```
class       - تعريف فئة | define a class
new         - إنشاء كائن جديد | create new object
public      - يمكن الوصول من أي مكان | accessible from anywhere
private     - يمكن الوصول من الفئة فقط | accessible from class only
inherit (:) - الوراثة | inheritance
interface   - واجهة | interface
abstract    - مجرد (يجب تنفيذه) | abstract (must be implemented)
virtual     - يمكن استبداله | can be overridden
override    - استبدال دالة من الفئة الأساسية | replace base class method
```

### طريقة الكتابة الصحيحة | Correct Writing Style
```csharp
// ✅ جيد | Good - اسم ذو معنى واضح
public class Person
{
    public string Name { get; set; }
}

// ❌ سيء | Bad - اسم غير واضح
public class P
{
    public string n { get; set; }
}
```

---

## إذا لم تعمل | Troubleshooting

### خطأ: "project file not found"
```bash
# تأكد أنك في المجلد الصحيح
ls Uppgift1_ToString/

# الملفات المطلوبة:
# - Uppgift1_ToString.csproj
# - Program.cs
# - Person.cs (حسب التمرين)
```

### خطأ: "dotnet not found"
```bash
# تثبيت .NET SDK
# Windows/Mac: https://dotnet.microsoft.com/download
# Linux: sudo apt-get install dotnet-sdk-6.0
```

### Output غير صحيح
- ✅ تحقق من Input الصحيح
- ✅ تحقق من أسماء الدوال
- ✅ تحقق من أنواع البيانات

---

## هيكل المشروع | Project Structure

```
OOP_Assignments/
│
├── OOP_Assignments.sln          (Solution file)
│
├── Uppgift1_ToString/           (Task 1)
│   ├── Program.cs
│   ├── Person.cs
│   └── Uppgift1_ToString.csproj
│
├── Uppgift2_Konstruktorer/      (Task 2)
│   ├── Program.cs
│   ├── Person.cs
│   └── Uppgift2_Konstruktorer.csproj
│
├── Uppgift3_Arv/                (Task 3)
│   ├── Program.cs
│   ├── Person.cs
│   ├── Student.cs
│   ├── Teacher.cs
│   └── Uppgift3_Arv.csproj
│
├── Uppgift4_Fotoalbum/          (Task 4)
│   ├── Program.cs
│   ├── PhotoBook.cs
│   ├── BigPhotoBook.cs
│   └── Uppgift4_Fotoalbum.csproj
│
├── Uppgift5_Arv2/               (Task 5)
│   ├── Program.cs
│   ├── Person.cs
│   ├── Student.cs
│   ├── Teacher.cs
│   └── Uppgift5_Arv2.csproj
│
├── Uppgift6_Interface/          (Task 6)
│   ├── Program.cs
│   ├── IVehicle.cs
│   ├── Car.cs
│   └── Uppgift6_Interface.csproj
│
├── Uppgift7_AbstractKlasser/    (Task 7)
│   ├── Program.cs
│   ├── Animal.cs
│   ├── Dog.cs
│   └── Uppgift7_AbstractKlasser.csproj
│
├── Uppgift8_Polymorfism/        (Task 8)
│   ├── Program.cs
│   ├── Calculator.cs
│   ├── IceCream.cs
│   ├── Chocolate.cs
│   └── Uppgift8_Polymorfism.csproj
│
├── Uppgift9_Generiska/          (Task 9)
│   ├── Program.cs
│   ├── GenericClass.cs
│   ├── SampleClass.cs
│   └── Uppgift9_Generiska.csproj
│
└── README.md                    (This file)
```

---

## ملاحظات إضافية | Additional Notes

### لم ينفذ الطالب Task 10 | Note about 10th Task
التعليمات ذكرت 10 تمارين لكن هناك فقط 9 في الواقع. تم تنفيذ جميع 9 المذكورة.

The instructions mentioned 10 assignments but there are actually 9. All 9 have been implemented.

### التنسيق والأسلوب | Code Style
الكود كُتب بأسلوب طالب عادي:
- ليس احترافي جداً
- بعض الأسماء بسيطة
- لا توجد تعليقات معقدة
- التنسيق واضح وسهل الفهم

The code is written in a normal student style:
- Not overly professional
- Simple variable names
- No complex comments
- Clear and easy to understand formatting

---

## المشاريع الخارجية | External Resources

- [C# Documentation](https://docs.microsoft.com/en-us/dotnet/csharp/)
- [.NET Tutorials](https://docs.microsoft.com/en-us/dotnet/fundamentals/)
- [OOP Concepts](https://en.wikipedia.org/wiki/Object-oriented_programming)

---

**Created for OOP Learning | تم الإنشاء لتعليم البرمجة الموجهة للكائنات**

آخر تحديث: 2026-11-14 | Last Updated: 2026-11-14
