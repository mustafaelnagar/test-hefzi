# نص الفيديو - الوراثة المتقدمة | Uppgift 5 Script

## الفيديو الخامس: الوراثة والـ Type Casting

---

## المقدمة (0:00 - 0:30)

السلام عليكم!

في الدرس السابق تعلمنا عن الوراثة الأساسية.
اليوم سوف نتعلم عن مفهوم متقدم: **Type Casting** (تحويل النوع).

هذا يسمح لنا باستخدام الفئات الوارثة بطرق متقدمة جداً!

---

## المشكلة (0:30 - 2:00)

تخيل أن معك array من نوع Person:

```csharp
Person[] people = new Person[3];
```

هل يمكن أن تحتوي على Student و Teacher؟

**الإجابة: نعم! لأنهما يرثان من Person!**

```csharp
Person[] people = new Person[3];
people[0] = new Teacher("Juan");   // Teacher = Person ✓
people[1] = new Student("Sara");   // Student = Person ✓
people[2] = new Student("Kalle");  // Student = Person ✓
```

**لكن المشكلة:**
- كل العناصر تُعامل كـ Person
- لا نستطيع استدعاء `Study()` أو `Explain()`
- تُحتاج إلى **Type Casting** لحل هذا

---

## الفئات (2:00 - 3:30)

```csharp
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
    public Student(string name) : base(name)
    {
    }
    
    public void Study()
    {
        Console.WriteLine("Pluggar");
    }
}

class Teacher : Person
{
    public Teacher(string name) : base(name)
    {
    }
    
    public void Explain()
    {
        Console.WriteLine("Undervisar");
    }
}
```

**نقاط مهمة:**
- `: base(name)` - استدعاء Person Constructor
- `Study()` و `Explain()` خاصة بالفئات الوارثة

---

## البرنامج - الجزء الأول (3:30 - 5:00)

```csharp
static void Main()
{
    // 1. قراءة الأسماء
    string name1 = Console.ReadLine();  // Juan
    string name2 = Console.ReadLine();  // Sara
    string name3 = Console.ReadLine();  // Kalle
    
    // 2. إنشاء Array من Person
    Person[] people = new Person[3];
    
    // 3. إضافة الكائنات
    people[0] = new Teacher(name1);
    people[1] = new Student(name2);
    people[2] = new Student(name3);
}
```

**ما يحدث:**
1. نقرأ ثلاثة أسماء
2. ننشئ Array من نوع Person بـ 3 أماكن
3. نضع Teacher في المكان الأول
4. نضع Student في الثاني والثالث

**الأهمية:**
- كل الفئات الوارثة تُعتبر من نوع الفئة الأساسية
- لا خطأ في هذا!

---

## Type Casting (5:00 - 7:00)

**الآن المشكلة:** نريد استدعاء `Explain()` و `Study()`

لا يمكن:
```csharp
people[0].Explain();  // خطأ! Explain ليست في Person
```

**الحل: Type Casting**

```csharp
// تحويل Person إلى Teacher
Teacher teacher = (Teacher)people[0];
teacher.Explain();  // الآن يعمل!

// تحويل Person إلى Student
Student student1 = (Student)people[1];
student1.Study();  // الآن يعمل!

Student student2 = (Student)people[2];
student2.Study();  // الآن يعمل!
```

**الصيغة:**
```csharp
(الفئة_المراد_التحويل_إليها) الكائن

(Teacher)people[0]
(Student)people[1]
```

---

## البرنامج الكامل (7:00 - 8:30)

```csharp
static void Main()
{
    // قراءة الأسماء
    string name1 = Console.ReadLine();
    string name2 = Console.ReadLine();
    string name3 = Console.ReadLine();
    
    // إنشاء Array من Person
    Person[] people = new Person[3];
    people[0] = new Teacher(name1);
    people[1] = new Student(name2);
    people[2] = new Student(name3);
    
    // Type Casting واستدعاء التوابع الخاصة
    Teacher teacher = (Teacher)people[0];
    teacher.Explain();  // Undervisar
    
    Student student1 = (Student)people[1];
    student1.Study();   // Pluggar
    
    Student student2 = (Student)people[2];
    student2.Study();   // Pluggar
}
```

---

## المخرجات (8:30 - 9:00)

**المدخلات:**
```
Juan
Sara
Kalle
```

**المخرجات:**
```
Undervisar
Pluggar
Pluggar
```

**التطابق:**
- Line 1: Teacher Explain
- Line 2: First Student Study
- Line 3: Second Student Study

---

## الفوائد (9:00 - 10:15)

### 1. مرونة الكود
```csharp
// يمكن تخزين أنواع مختلفة في Array واحد
Person[] people = new Person[100];
people[0] = new Teacher("...");
people[1] = new Student("...");
people[2] = new Teacher("...");
// ... إلخ
```

### 2. التعامل الموحد
```csharp
// معالجة جميع Person بنفس الطريقة
foreach (Person p in people)
{
    Console.WriteLine(p);  // تطبع كل واحدة
}
```

### 3. التعامل الخاص
```csharp
// لكن يمكن معاملة كل نوع بشكل خاص
if (people[0] is Teacher)
{
    ((Teacher)people[0]).Explain();
}
```

---

## مزيد من الأمثلة (10:15 - 11:15)

### مثال 1: حيوانات
```csharp
class Animal { }
class Dog : Animal { public void Bark() { } }
class Cat : Animal { public void Meow() { } }

Animal[] animals = new Animal[2];
animals[0] = new Dog();
animals[1] = new Cat();

Dog dog = (Dog)animals[0];
dog.Bark();

Cat cat = (Cat)animals[1];
cat.Meow();
```

### مثال 2: مركبات
```csharp
class Vehicle { }
class Car : Vehicle { public void Drive() { } }
class Bike : Vehicle { public void Pedal() { } }

Vehicle[] vehicles = new Vehicle[2];
vehicles[0] = new Car();
vehicles[1] = new Bike();

Car car = (Car)vehicles[0];
car.Drive();
```

---

## الأخطاء الشائعة (11:15 - 12:15)

❌ **خطأ 1: تحويل خاطئ**
```csharp
Person[] people = new Person[2];
people[0] = new Teacher("Juan");
people[1] = new Student("Sara");

// خطأ! people[1] ليس Teacher
Teacher t = (Teacher)people[1];  // Runtime Error!
```

❌ **خطأ 2: نسيان التحويل**
```csharp
// خطأ - لا يمكن استدعاء Study() من Person
people[1].Study();

// صحيح - بعد التحويل
Student s = (Student)people[1];
s.Study();
```

❌ **خطأ 3: الخلط بين الأنواع**
```csharp
// خطأ
Student s = (Student)people[0];  // people[0] هو Teacher!

// صحيح
Teacher t = (Teacher)people[0];  // people[0] هو Teacher
```

---

## الحماية من الأخطاء (12:15 - 13:00)

```csharp
// الطريقة الآمنة: التحقق أولاً
if (people[0] is Teacher)
{
    Teacher teacher = (Teacher)people[0];
    teacher.Explain();
}
else if (people[0] is Student)
{
    Student student = (Student)people[0];
    student.Study();
}
```

أو باستخدام `as` (أكثر أماناً):

```csharp
Student student = people[1] as Student;
if (student != null)
{
    student.Study();
}
```

---

## الخلاصة (13:00 - 13:30)

✅ تعلمنا:
- تخزين أنواع مختلفة في نفس Array
- Type Casting لتحويل النوع
- الفوائد والاستخدامات
- الأخطاء الشائعة والحماية منها

⏭️ **الدرس القادم:**
سوف نتعلم عن الواجهات (Interfaces)
وهي طريقة أخرى غير الوراثة!

شكراً لكم! 👋

---

**مدة الفيديو:** ~13.5 دقيقة  
**اللغة:** العربية  
**المستوى:** متوسط-متقدم
