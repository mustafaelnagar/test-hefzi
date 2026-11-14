# مرجع سريع بالعربية | Quick Arabic Reference

## المفاهيم الأساسية | Basic Concepts

### 1. الفئة (Class) | Class
```csharp
class Person
{
    // خصائص | Properties
    public string Name { get; set; }
    
    // دالة | Method
    public void Greet()
    {
        Console.WriteLine("السلام عليكم");
    }
}

// الاستخدام | Usage:
Person p = new Person();
p.Name = "محمد";
p.Greet();
```

**شرح:**
- `class` - تعريف فئة (قالب لإنشاء كائنات)
- `public` - يمكن الوصول من أي مكان
- `string` - نوع بيانات للنصوص
- `new` - إنشاء كائن جديد

---

### 2. الوراثة (Inheritance) | Inheritance

```csharp
// الفئة الأساسية | Parent Class
class Person
{
    public string Name { get; set; }
    
    public void Greet()
    {
        Console.WriteLine("السلام عليكم");
    }
}

// الفئة الوارثة | Child Class
class Student : Person
{
    // يرث Name و Greet من Person
    
    public void Study()
    {
        Console.WriteLine("أنا أدرس");
    }
}

// الاستخدام | Usage:
Student s = new Student();
s.Name = "علي";
s.Greet();    // من Person
s.Study();    // من Student
```

**الفائدة:**
- عدم تكرار الكود
- ترتيب أفضل للمشروع
- سهولة الصيانة

---

### 3. الواجهة (Interface) | Interface

```csharp
// تعريف الواجهة | Define Interface
interface IAnimal
{
    void Eat();
    void Sleep();
}

// تطبيق الواجهة | Implement Interface
class Dog : IAnimal
{
    public void Eat()
    {
        Console.WriteLine("الكلب يأكل");
    }
    
    public void Sleep()
    {
        Console.WriteLine("الكلب ينام");
    }
}

// الاستخدام | Usage:
Dog d = new Dog();
d.Eat();
d.Sleep();
```

**الفرق بين Class و Interface:**
- `Class`: يحتوي على بيانات وتطبيق
- `Interface`: تعريف العمليات فقط (بدون تطبيق)

---

### 4. الفئة المجردة (Abstract Class) | Abstract Class

```csharp
// فئة مجردة | Abstract Class
abstract class Shape
{
    // خاصية عادية | Normal property
    public string Name { get; set; }
    
    // دالة عادية | Normal method
    public void Describe()
    {
        Console.WriteLine($"اسم الشكل: {Name}");
    }
    
    // دالة مجردة (بدون تطبيق) | Abstract method
    public abstract double GetArea();
}

// تطبيق الفئة المجردة | Implement Abstract Class
class Circle : Shape
{
    public double Radius { get; set; }
    
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

// الاستخدام | Usage:
// Shape s = new Shape(); // ❌ خطأ - لا تستطيع إنشاء كائن من فئة مجردة
Circle c = new Circle { Name = "دائرة", Radius = 5 };
c.Describe();
```

**ملاحظة:**
- لا تستطيع عمل `new AbstractClass()`
- يجب أن تطبق الدوال المجردة في الفئات الوارثة

---

### 5. Constructor و Destructor

```csharp
class Person
{
    public string Name { get; set; }
    
    // Constructor - ينفذ عند إنشاء الكائن
    public Person(string name)
    {
        Name = name;
        Console.WriteLine($"تم إنشاء شخص اسمه {name}");
    }
    
    // Destructor - ينفذ عند حذف الكائن
    ~Person()
    {
        Console.WriteLine($"تم حذف {Name}");
    }
}

// الاستخدام | Usage:
Person p = new Person("محمد");  // Prints: تم إنشاء شخص اسمه محمد
p = null;  // الآن ينفذ Destructor - Prints: تم حذف محمد
```

**متى تستخدم:**
- `Constructor`: لتهيئة الكائن
- `Destructor`: لتنظيف الموارد (نادراً ما تحتاجه)

---

### 6. تعدد الأشكال (Polymorphism) | Polymorphism

#### أ) Method Overloading - نفس الاسم، معاملات مختلفة

```csharp
class Calculator
{
    // Add للأعداد الصحيحة
    public int Add(int a, int b)
    {
        return a + b;
    }
    
    // Add للأعداد العشرية
    public double Add(double a, double b)
    {
        return a + b;
    }
    
    // Add للنصوص
    public string Add(string a, string b)
    {
        return a + b;
    }
}

// الاستخدام | Usage:
Calculator c = new Calculator();
Console.WriteLine(c.Add(5, 3));           // 8
Console.WriteLine(c.Add(5.5, 3.3));       // 8.8
Console.WriteLine(c.Add("مرحبا", "علي")); // مرحباعلي
```

#### ب) Method Overriding - استبدال دالة من الفئة الأساسية

```csharp
class Animal
{
    public virtual void Sound()
    {
        Console.WriteLine("صوت الحيوان");
    }
}

class Dog : Animal
{
    public override void Sound()
    {
        Console.WriteLine("ولولة");
    }
}

class Cat : Animal
{
    public override void Sound()
    {
        Console.WriteLine("مياء");
    }
}

// الاستخدام | Usage:
Animal dog = new Dog();
dog.Sound();  // ولولة

Animal cat = new Cat();
cat.Sound();  // مياء
```

---

### 7. الفئات العامة (Generics) | Generics

```csharp
// فئة عامة - T يمكن أن تكون أي نوع
class Container<T>
{
    public T Item { get; set; }
    
    public void Display()
    {
        Console.WriteLine($"العنصر: {Item}");
    }
}

// الاستخدام | Usage:
// مع String
Container<string> stringBox = new Container<string>();
stringBox.Item = "مرحبا";
stringBox.Display();  // العنصر: مرحبا

// مع int
Container<int> intBox = new Container<int>();
intBox.Item = 42;
intBox.Display();  // العنصر: 42

// دالة عامة | Generic Method
class Printer
{
    public void Print<T>(T value)
    {
        Console.WriteLine($"القيمة: {value}");
    }
}

// الاستخدام | Usage:
Printer p = new Printer();
p.Print<string>("محمد");  // القيمة: محمد
p.Print<int>(123);        // القيمة: 123
```

---

## المفاهيم المهمة | Important Concepts

### الكائن (Object) vs الفئة (Class)
```
الفئة = الرسمة (مخطط)
الكائن = المبنى (التطبيق)

Class Person { }        <- الرسمة
new Person();          <- المبنى
```

### public vs private
```csharp
class Person
{
    public string Name;    // يمكن الوصول من خارج الفئة
    private int Age;       // لا يمكن الوصول من خارج الفئة
}

// الاستخدام | Usage:
Person p = new Person();
p.Name = "محمد";        // ✅ صحيح
p.Age = 25;             // ❌ خطأ - Age خاص
```

### virtual و override
```csharp
// virtual - تعني أن الدالة يمكن أن تُستبدل
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("صوت");
    }
}

// override - استبدال الدالة من الفئة الأساسية
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("ولولة");
    }
}
```

---

## أخطاء شائعة | Common Mistakes

### ❌ خطأ 1: نسيان new عند الإنشاء
```csharp
Person p;           // ❌ p قيمتها null
p.Name = "محمد";   // ❌ سيحصل خطأ!

Person p = new Person();  // ✅ صحيح
p.Name = "محمد";         // ✅ صحيح
```

### ❌ خطأ 2: استخدام class بدل interface
```csharp
// ❌ خطأ - لا تستطيع وراثة من أكثر من class واحد
class Student : Person, Teacher { }

// ✅ صحيح - تستطيع implement أكثر من interface
class Student : IPerson, ITeacher { }
```

### ❌ خطأ 3: نسيان override في الفئة الوارثة
```csharp
// ❌ خطأ
class Dog : Animal
{
    public void Speak()  // نسيت override
    {
        Console.WriteLine("ولولة");
    }
}

// ✅ صحيح
class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("ولولة");
    }
}
```

### ❌ خطأ 4: استخدام abstract class بدون تطبيق
```csharp
// ❌ خطأ
abstract class Animal
{
    public abstract void Eat();
}

class Dog : Animal
{
    // نسيت تطبيق Eat!
}

// ✅ صحيح
class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("الكلب يأكل");
    }
}
```

---

## التطبيق العملي | Practical Example

```csharp
// فئة أساسية
abstract class Vehicle
{
    public string Name { get; set; }
    
    public abstract void Start();
}

// فئة وارثة
class Car : Vehicle
{
    public override void Start()
    {
        Console.WriteLine($"{Name} بدأ يعمل");
    }
}

// واجهة
interface IFueled
{
    void Refuel(int amount);
}

// فئة توارث وتطبق
class GasolineCar : Car, IFueled
{
    private int fuel;
    
    public GasolineCar(string name)
    {
        Name = name;
        fuel = 0;
    }
    
    public void Refuel(int amount)
    {
        fuel += amount;
        Console.WriteLine($"تمت إضافة {amount} لتر");
    }
    
    public override void Start()
    {
        if (fuel > 0)
        {
            base.Start();  // استدعاء دالة الفئة الأساسية
            fuel--;
        }
        else
        {
            Console.WriteLine("لا يوجد وقود!");
        }
    }
}

// الاستخدام | Usage:
GasolineCar myCar = new GasolineCar("تويوتا");
myCar.Refuel(50);
myCar.Start();  // تويوتا بدأ يعمل
```

---

## المصطلحات باللغات | Terminology

| English | العربية | المعنى |
|---------|---------|--------|
| Class | فئة | قالب لإنشاء الكائنات |
| Object | كائن | نسخة من الفئة |
| Inheritance | الوراثة | فئة ترث من أخرى |
| Interface | الواجهة | عقد العمليات |
| Abstract | المجرد | بدون تطبيق كامل |
| Polymorphism | تعدد الأشكال | نفس الاسم، تطبيق مختلف |
| Encapsulation | التغليف | إخفاء البيانات الداخلية |
| Constructor | البناء | تهيئة الكائن |
| Destructor | الهدم | حذف الكائن |
| Property | الخاصية | متغير مع getter/setter |
| Method | الدالة | عملية |

---

## نصائح مهمة | Important Tips

1. **استخدم أسماء واضحة للفئات والدوال:**
   ```csharp
   ✅ class StudentManagementSystem
   ❌ class SMS
   ```

2. **اكتب تعليقات للعمليات المعقدة:**
   ```csharp
   // احسب المساحة (قطر × قطر × 3.14)
   double area = Math.PI * radius * radius;
   ```

3. **استخدم const للقيم الثابتة:**
   ```csharp
   const double PI = 3.14159;
   ```

4. **تجنب المتغيرات العامة جداً:**
   ```csharp
   ✅ private int studentAge;
   ❌ public int x;
   ```

---

**آخر تحديث | Last Updated: 2026-11-14**
