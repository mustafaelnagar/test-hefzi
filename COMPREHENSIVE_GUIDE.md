# شرح شامل لجميع الواجبات
# Comprehensive Guide to All Assignments

**اللغة:** العربية  
**المستوى:** مبتدئ إلى متقدم  
**الإجمالي:** 9 واجبات برمجية  

---

## 📋 فهرس سريع | Quick Index

| # | الواجب | الموضوع | المدة |
|---|--------|---------|------|
| 1 | Classes & ToString | الفئات والتوابع | 9.5 دقيقة |
| 2 | Constructors | البنائيات والمدمرات | 11.5 دقيقة |
| 3 | Inheritance | الوراثة الأساسية | 12 دقيقة |
| 4 | Photo Album | Constructors متعددة | 11.5 دقيقة |
| 5 | Type Casting | الوراثة المتقدمة | 13.5 دقيقة |
| 6 | Interfaces | الواجهات | 14 دقيقة |
| 7 | Abstract | الفئات المجردة | 12 دقيقة |
| 8 | Polymorphism | تعدد الأشكال | 15.5 دقيقة |
| 9 | Generics | الفئات العامة | 17.5 دقيقة |

---

# 🎯 الواجب 1: الفئات والتوابع
## Assignment 1: Classes & ToString()

### 📝 الشرح:
**تعريف:** إنشاء فئة `Person` بخاصية `Name` وتابع `ToString()` مخصص.

**الهدف:** فهم:
- تعريف الفئات (Classes)
- الخصائص (Properties)
- استبدال التوابع (Override)

### 💻 الكود:
```csharp
class Person
{
    public string Name { get; set; }
    
    public override string ToString()
    {
        return $"Hej! Jag heter {Name}";
    }
}
```

### 📊 Flowchart:
```
┌─────────────────────┐
│   قراءة 3 أسماء     │
└──────────┬──────────┘
           │
           ▼
┌─────────────────────┐
│  إنشاء مصفوفة       │
│   Person[3]        │
└──────────┬──────────┘
           │
           ▼
    ┌──────────────┐
    │  حلقة (for)  │
    └──────┬───────┘
           │
      ┌────┴────┐
      ▼         │
┌──────────────┐│
│ new Person() ││
└──────┬───────┘│
       ▼        │
┌────────────┐  │
│ SetName()  │  │
└────────┬───┘  │
         ▼      │
    Add to Array│
         │◄─────┘
         ▼
┌──────────────────┐
│  حلقة (foreach)  │
└──────────┬───────┘
           │
           ▼
┌──────────────────┐
│  ToString()      │
│  المخصص          │
└──────────┬───────┘
           │
           ▼
┌──────────────────┐
│    الطباعة       │
└──────────────────┘
```

### 📥 المدخلات:
```
Juan
Sara
Kalle
```

### 📤 المخرجات:
```
Hej! Jag heter Juan
Hej! Jag heter Sara
Hej! Jag heter Kalle
```

---

# 🎯 الواجب 2: البنائيات والمدمرات
## Assignment 2: Constructors & Destructors

### 📝 الشرح:
**تعريف:** إضافة `Constructor` (يعمل عند الإنشاء) و `Destructor` (يعمل عند الحذف).

**الفرق مع الواجب 1:**
- الواجب 1: إنشاء ثم تعيين
- الواجب 2: إنشاء وتعيين معاً

### 💻 الكود:
```csharp
class Person
{
    public string Name { get; set; }
    
    public Person(string name)      // Constructor
    {
        Name = name;
    }
    
    ~Person()                       // Destructor
    {
        Name = "";
    }
    
    public override string ToString()
    {
        return $"Hej! Jag heter {Name}";
    }
}
```

### 📊 Flowchart:
```
┌──────────────────────┐
│  قراءة الاسم         │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│ new Person(name)     │◄── Constructor ينفذ
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│ حفظ في المصفوفة      │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│  ToString()          │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│  الطباعة             │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│  نهاية البرنامج      │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│ ~Person()            │◄── Destructor ينفذ
│ حذف البيانات         │
└──────────────────────┘
```

### 📥 المدخلات:
```
Juan
Sara
Kalle
```

### 📤 المخرجات:
```
Hej! Jag heter Juan
Hej! Jag heter Sara
Hej! Jag heter Kalle
```

---

# 🎯 الواجب 3: الوراثة الأساسية
## Assignment 3: Inheritance

### 📝 الشرح:
**تعريف:** إنشاء فئة أساسية `Person` وفئات وارثة `Student` و `Teacher`.

**المزايا:**
- عدم تكرار الكود
- ترتيب أفضل

### 💻 الكود:
```csharp
class Person
{
    public void Greet() { Console.WriteLine("Hej!"); }
    public void SetAge(int age) { /* ... */ }
}

class Student : Person
{
    public void Study() { Console.WriteLine("Jag pluggar!"); }
}

class Teacher : Person
{
    public void Explain() { Console.WriteLine("Jag förklarar"); }
}
```

### 📊 Flowchart:
```
┌─────────────────────┐
│     Person          │
│  (الفئة الأساسية)    │
├─────────────────────┤
│ - Greet()           │
│ - SetAge()          │
└────────┬────────────┘
         │
    ┌────┴────┐
    │          │
    ▼          ▼
┌────────┐  ┌────────┐
│Student │  │Teacher │
├────────┤  ├────────┤
│Study() │  │Explain │
└────────┘  └────────┘

[ترث كل شيء من Person]
```

### 📥 المدخلات:
```
(بدون مدخلات)
```

### 📤 المخرجات:
```
Hej!
Hej!
Jag är 21 år gammal
Jag pluggar!
Hej!
Jag förklarar
```

---

# 🎯 الواجب 4: الألبوم الفوتوغرافي
## Assignment 4: Photo Album

### 📝 الشرح:
**تعريف:** Constructors متعددة في `PhotoBook` و `BigPhotoBook` يرث منها.

**المفهوم:**
- نفس الاسم `PhotoBook`
- معاملات مختلفة
- البرنامج يختار الصحيح

### 💻 الكود:
```csharp
class PhotoBook
{
    private int numPages;
    
    public PhotoBook()              // Default: 16
    { numPages = 16; }
    
    public PhotoBook(int pages)     // Custom
    { numPages = pages; }
    
    public int GetNumberPages() { return numPages; }
}

class BigPhotoBook : PhotoBook
{
    public BigPhotoBook() : base(64)  // Default: 64
    { }
}
```

### 📊 Flowchart:
```
┌──────────────────────┐
│   PhotoBook()        │◄── Overloading 1
│   (بدون معاملات)      │
│   numPages = 16      │
└──────────┬───────────┘
           │
    ┌──────┴──────┐
    ▼             ▼
┌──────────┐  ┌──────────────┐
│PhotoBook │  │PhotoBook(24) │◄── Overloading 2
│GetPages()│  │numPages = 24 │
│   = 16   │  └──────────────┘
└──────────┘         │
                     ▼
            ┌──────────────────┐
            │BigPhotoBook()    │◄── Overloading 3
            │: base(64)        │
            │numPages = 64     │
            └──────────────────┘
```

### 📥 المدخلات:
```
(بدون مدخلات)
```

### 📤 المخرجات:
```
16
24
64
```

---

# 🎯 الواجب 5: الوراثة المتقدمة
## Assignment 5: Advanced Inheritance & Type Casting

### 📝 الشرح:
**تعريف:** تخزين أنواع مختلفة في Array واحد من نوع أساسي.

**الأهمية:** Polymorphism الحقيقي - معاملة مختلفة في نفس المصفوفة.

### 💻 الكود:
```csharp
Person[] people = new Person[3];
people[0] = new Teacher("Juan");    // Teacher = Person ✓
people[1] = new Student("Sara");    // Student = Person ✓
people[2] = new Student("Kalle");   // Student = Person ✓

// Type Casting للوصول للتوابع الخاصة
Teacher t = (Teacher)people[0];
t.Explain();

Student s = (Student)people[1];
s.Study();
```

### 📊 Flowchart:
```
┌────────────────────────┐
│  Array[Person]         │
│     Size = 3           │
└────────┬───────────────┘
         │
    ┌────┼────┐
    ▼    ▼    ▼
┌────┐┌──┐┌──┐
│Tea││St││St│  (نفس النوع Person)
└─┬──┘└─┬┘└─┬┘
  │     │   │
  ▼     ▼   ▼
┌────┐┌──┐┌──┐
│Cast││Ca││Ca│  (Type Casting)
│to  ││st││st│
│Tch ││to││to│
└─┬──┘└─┬┘└─┬┘
  │     │   │
  ▼     ▼   ▼
┌────┐┌──┐┌──┐
│Expl││Stu││Stu│  (استدعاء التوابع)
│ain()││dy()││dy()│
└────┘└──┘└──┘
```

### 📥 المدخلات:
```
Juan
Sara
Kalle
```

### 📤 المخرجات:
```
Undervisar
Pluggar
Pluggar
```

---

# 🎯 الواجب 6: الواجهات
## Assignment 6: Interfaces

### 📝 الشرح:
**تعريف:** عقد يحدد ما يجب أن تفعله الفئة دون تحديد كيفية التنفيذ.

**الفرق عن الوراثة:**
- Interface = عقد فقط
- Class = تطبيق كامل

### 💻 الكود:
```csharp
interface IVehicle
{
    void Drive();
    bool Refuel(int amount);
}

class Car : IVehicle
{
    private int fuel;
    
    public void Drive()
    {
        if (fuel > 0)
            Console.WriteLine("Kör");
    }
    
    public bool Refuel(int amount)
    {
        fuel += amount;
        return true;
    }
}
```

### 📊 Flowchart:
```
┌──────────────────────┐
│   IVehicle           │
│    (Interface)       │
├──────────────────────┤
│ + Drive()            │
│ + Refuel(int)        │
└────────┬─────────────┘
         │
         │ implements
         │
         ▼
┌──────────────────────┐
│   Car                │
├──────────────────────┤
│ - fuel: int          │
│ + Drive()     ✓      │
│ + Refuel()    ✓      │
└────────┬─────────────┘
         │
         ▼
┌──────────────────────┐
│ new Car(0)           │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│ Refuel(50)           │
│ fuel = 50            │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│ Drive()              │
│ "Kör"                │
└──────────────────────┘
```

### 📥 المدخلات:
```
50
```

### 📤 المخرجات:
```
Kör
```

---

# 🎯 الواجب 7: الفئات المجردة
## Assignment 7: Abstract Classes

### 📝 الشرح:
**تعريف:** فئة تحتوي على توابع عادية وتوابع مجردة (بدون تطبيق).

**الفرق:**
- Class عادية = يمكن إنشاء كائن منها
- Abstract Class = لا يمكن إنشاء كائن منها

### 💻 الكود:
```csharp
abstract class Animal
{
    public void SetName(string n) { /* ... */ }
    public string GetName() { /* ... */ }
    
    public abstract void Eat();  // بدون تطبيق
}

class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("Äter");
    }
}
```

### 📊 Flowchart:
```
┌──────────────────────┐
│   abstract Animal    │
├──────────────────────┤
│ + SetName()   ✓      │
│ + GetName()   ✓      │
│ + Eat()       ✗      │ (abstract)
└────────┬─────────────┘
         │
    ❌ لا يمكن: new Animal()
         │
         │ (يجب تطبيق)
         │
         ▼
┌──────────────────────┐
│   Dog                │
├──────────────────────┤
│ + SetName()   ✓      │ (موروث)
│ + GetName()   ✓      │ (موروث)
│ + Eat()       ✓      │ (مطبق)
└────────┬─────────────┘
         │
    ✅ يمكن: new Dog()
         │
         ▼
┌──────────────────────┐
│ Dog d = new Dog()    │
│ d.SetName("Lufsen")  │
│ d.GetName()→Lufsen   │
│ d.Eat()→Äter         │
└──────────────────────┘
```

### 📥 المدخلات:
```
Lufsen
```

### 📤 المخرجات:
```
Lufsen
Äter
```

---

# 🎯 الواجب 8: تعدد الأشكال
## Assignment 8: Polymorphism

### 📝 الشرح:
**تعريف:** نفس الاسم، تطبيقات مختلفة.

**نوعان:**
1. **Method Overloading** - معاملات مختلفة
2. **Method Overriding** - استبدال التابع

### 💻 الكود:
```csharp
// Overloading - نفس الاسم، معاملات مختلفة
class Calculator
{
    public void Sum(int a, int b) { /* ... */ }
    public void Sum(float a, float b) { /* ... */ }
    public void Sum(string a, string b) { /* ... */ }
}

// Overriding - استبدال التابع
class IceCream
{
    public virtual void Flavor()
    { Console.WriteLine("Vanilj"); }
}

class Chocolate : IceCream
{
    public override void Flavor()
    { Console.WriteLine("Chocolate"); }
}
```

### 📊 Flowchart:
```
┌─────────────────────────────┐
│     Method Overloading      │
│   (نفس الاسم - معاملات مختلفة) │
└────────┬────────────────────┘
         │
    ┌────┼────┐
    ▼    ▼    ▼
  Sum() Sum() Sum()
  int   float string
   │     │     │
   5,4   9.3   "text"
   │     │     │
   ▼     ▼     ▼
  9    17.9   error

┌─────────────────────────────┐
│    Method Overriding        │
│  (استبدال التابع من الأساسي) │
└────────┬────────────────────┘
         │
    ┌────┴──────┐
    ▼           ▼
IceCream    Chocolate
Flavor()    override Flavor()
  │            │
  ▼            ▼
"Vanilj"   "Chocolate"
```

### 📥 المدخلات:
```
(بدون مدخلات)
```

### 📤 المخرجات:
```
Summan av 5 och 4 är 9
Summan av 9,3 och 8,6 är 17,900002
Hej världen - är inte numeriskt
Class : Icecream
Class : Chocolate
IceCream Type : Chocolate
```

---

# 🎯 الواجب 9: الفئات العامة
## Assignment 9: Generic Classes

### 📝 الشرح:
**تعريف:** فئة تعمل مع أي نوع بيانات (T = Type).

**الفائدة:** كود واحد لأنواع مختلفة بدل التكرار.

### 💻 الكود:
```csharp
// Generics - T = أي نوع
class Container<T>
{
    public T Item { get; set; }
    
    public void Display()
    {
        Console.WriteLine(Item);
    }
}

// الاستخدام
Container<int> box1 = new Container<int>();
box1.Item = 42;

Container<string> box2 = new Container<string>();
box2.Item = "Hello";
```

### 📊 Flowchart:
```
┌──────────────────────┐
│  Container<T>        │
│    (Generic Class)   │
├──────────────────────┤
│ + Item: T            │
│ + Display()          │
└────────┬─────────────┘
         │
    ┌────┼────┬────┐
    │    │    │    │
    ▼    ▼    ▼    ▼
   int string double bool

┌──────────────────────┐
│  Container<int>      │ T = int
│  Item = 42           │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│  Container<string>   │ T = string
│  Item = "Hello"      │
└──────────┬───────────┘
           │
           ▼
┌──────────────────────┐
│  Container<Dog>      │ T = Dog
│  Item = new Dog()    │
└──────────────────────┘
```

### 📥 المدخلات:
```
(بدون مدخلات)
```

### 📤 المخرجات:
```
Välkommen till ABF!
Name: Stina Persson
Location: Helsingborg
Param1: 1
Param2: 2
Param1: Gabriel Ruis
Param2: Säffle
```

---

# 🎓 الملخص الكامل | Complete Summary

## المفاهيم المتعلمة:

```
Task 1-2     → الأساسيات (Classes, Constructors)
               ↓
Task 3-5     → الوراثة (Inheritance, Type Casting)
               ↓
Task 6-7     → الواجهات والمجردة (Interfaces, Abstract)
               ↓
Task 8       → تعدد الأشكال (Polymorphism)
               ↓
Task 9       → الفئات العامة (Generics)
```

## هرم OOP:

```
             ┌─────────────┐
             │  Generics   │ (Task 9)
             │ (الفئات العامة)│
             └──────┬──────┘
                    │
         ┌──────────┼──────────┐
         ▼          ▼          ▼
      ┌────┐   ┌────┐     ┌────────┐
      │Poly│   │Abs │     │Interfa│
      │morph   │class│     │ce     │
      └────┘   └────┘     └────────┘
      (Task 8) (Task 7)   (Task 6)
         │        │          │
         └────────┼──────────┘
                  │
            ┌─────┴──────┐
            ▼            ▼
       ┌────────┐   ┌──────┐
       │Inherit │   │Inherit│
       │ance 2  │   │ance 1 │
       └────────┘   └──────┘
       (Task 5)     (Task 3)
            │         │
            └────┬────┘
                 │
            ┌────┴─────┐
            ▼          ▼
       ┌────────┐  ┌──────┐
       │ Const  │  │ Class│
       │ ructor │  │ Basic│
       └────────┘  └──────┘
       (Task 2)    (Task 1)
```

---

## 🎯 نصائح مهمة | Key Tips

```
✅ ابدأ من الأساسيات (Task 1)
✅ لا تقفز الوسط
✅ اكتب الكود بنفسك
✅ شغّل وجرّب التعديلات
✅ فهم الكود أهم من الحفظ
✅ ارجع للمراجع عند الضرورة
```

---

## 📊 خريطة الطريق الموصى بها

```
اليوم 1: Task 1-2 (2 ساعة)
اليوم 2: Task 3-4 (2 ساعة)
اليوم 3: Task 5 (1.5 ساعة)
اليوم 4: مراجعة + تمارين (1.5 ساعة)
اليوم 5: Task 6-7 (2 ساعة)
اليوم 6: Task 8 (2 ساعة)
اليوم 7: Task 9 + مراجعة (2.5 ساعة)
```

---

**Total Learning Time: ~14-15 ساعة**

**الآن أنت جاهز لفهم أي كود OOP!** ✅

---

**تم إنشاؤه:** 2026-11-15  
**اللغة:** العربية  
**المستوى:** مبتدئ إلى متقدم
