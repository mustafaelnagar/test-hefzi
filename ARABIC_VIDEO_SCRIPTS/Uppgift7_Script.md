# نص الفيديو - الفئات المجردة | Uppgift 7 Script

## الفيديو السابع: الفئات المجردة (Abstract Classes)

---

## المقدمة (0:00 - 0:45)

السلام عليكم!

في الدرس السابق تعلمنا عن الواجهات. اليوم سوف نتعلم عن الفئات المجردة.

الفئات المجردة هي **وسط بين الفئات العادية والواجهات**.
فيها خصائص وتوابع عادية، لكن بعض التوابع **مجردة** (بدون تطبيق).

---

## الفرق بين Class و Abstract Class و Interface (0:45 - 2:30)

### Class (فئة عادية)
```csharp
class Person
{
    public string Name { get; set; }
    
    public void Greet()
    {
        Console.WriteLine("Hi");
    }
}

Person p = new Person();  // يمكن إنشاء كائن ✓
```

### Abstract Class (فئة مجردة)
```csharp
abstract class Animal
{
    public string Name { get; set; }  // خاصية عادية ✓
    
    public void Move()  // تابع عادي ✓
    {
        Console.WriteLine("Moving");
    }
    
    public abstract void Sound();  // تابع مجرد (بدون تطبيق) ✗
}

Animal a = new Animal();  // خطأ! لا يمكن إنشاء كائن ✗
```

### Interface (واجهة)
```csharp
interface IMovable
{
    void Move();  // فقط التوقيع
}

IMovable m = new IMovable();  // خطأ! لا يمكن إنشاء كائن ✗
```

**الفرق الرئيسي:**
| الميزة | Class | Abstract | Interface |
|--------|-------|----------|-----------|
| خصائص عادية | ✅ | ✅ | ❌ |
| توابع عادية | ✅ | ✅ | ❌ |
| توابع مجردة | ❌ | ✅ | ✅ |
| إنشاء كائن | ✅ | ❌ | ❌ |

---

## الفئة المجردة (2:30 - 4:30)

```csharp
abstract class Animal
{
    // خاصية عادية
    private string name;
    
    // توابع عادية
    public void SetName(string n)
    {
        name = n;
    }
    
    public string GetName()
    {
        return name;
    }
    
    // تابع مجرد (بدون تطبيق)
    public abstract void Eat();
}
```

**شرح:**

1. `abstract class Animal`
   - كلمة `abstract` تعني الفئة مجردة
   - لا يمكن عمل `new Animal()`

2. `SetName()` و `GetName()`
   - توابع عادية بتطبيق كامل
   - ترثها كل الفئات الوارثة

3. `public abstract void Eat()`
   - تابع مجرد (بدون جسم)
   - لا يوجد `{ ... }` بعدها
   - تنتهي بـ `;`
   - كل فئة وارثة **يجب** أن تطبقها

---

## الفئة الوارثة (4:30 - 6:00)

```csharp
class Dog : Animal
{
    // يجب تطبيق الدالة المجردة
    public override void Eat()
    {
        Console.WriteLine("Äter");
    }
}
```

**شرح:**

1. `class Dog : Animal`
   - Dog ترث من الفئة المجردة Animal
   - يمكن إنشاء كائن من Dog

2. `public override void Eat()`
   - `override` تعني استبدال التابع المجرد
   - نطبق الدالة بشكل كامل

3. الآن `Dog` فئة عادية:
```csharp
Dog d = new Dog();  // يعمل ✓
d.SetName("Lufsen");
Console.WriteLine(d.GetName());  // Lufsen
d.Eat();  // Äter
```

---

## البرنامج الرئيسي (6:00 - 7:30)

```csharp
static void Main()
{
    // 1. قراءة اسم الكلب من المستخدم
    string dogName = Console.ReadLine();
    
    // 2. إنشاء كائن Dog
    Dog myDog = new Dog();
    
    // 3. تعيين الاسم
    myDog.SetName(dogName);
    
    // 4. طباعة الاسم
    Console.WriteLine(myDog.GetName());
    
    // 5. استدعاء الدالة المجردة المطبقة
    myDog.Eat();
}
```

**التدفق:**

**Input:** "Lufsen"

```
[1] dogName = "Lufsen"
↓
[2] myDog = new Dog()  (يعمل لأن Dog ليست مجردة)
↓
[3] myDog.SetName("Lufsen")  (من Animal)
↓
[4] Console.WriteLine(myDog.GetName())
    → "Lufsen"
↓
[5] myDog.Eat()  (Dog طبقت هذه الدالة)
    → "Äter"
```

---

## المخرجات (7:30 - 8:00)

**المدخلات:**
```
Lufsen
```

**المخرجات:**
```
Lufsen
Äter
```

---

## مثال متقدم (8:00 - 9:15)

```csharp
abstract class Shape
{
    public abstract void Draw();
    public abstract double GetArea();
}

class Circle : Shape
{
    public double Radius { get; set; }
    
    public override void Draw()
    {
        Console.WriteLine("رسم دائرة");
    }
    
    public override double GetArea()
    {
        return Math.PI * Radius * Radius;
    }
}

class Rectangle : Shape
{
    public double Width { get; set; }
    public double Height { get; set; }
    
    public override void Draw()
    {
        Console.WriteLine("رسم مستطيل");
    }
    
    public override double GetArea()
    {
        return Width * Height;
    }
}

// الاستخدام
Shape[] shapes = new Shape[2];
shapes[0] = new Circle { Radius = 5 };
shapes[1] = new Rectangle { Width = 10, Height = 20 };

foreach (Shape s in shapes)
{
    s.Draw();
    Console.WriteLine("المساحة: " + s.GetArea());
}
```

---

## متى نستخدم Abstract Class؟ (9:15 - 10:30)

**استخدمات Abstract Class:**

1. **خصائص مشتركة**
```csharp
// إذا كنت تريد خصائص بيانات مشتركة
abstract class Animal
{
    public string Name { get; set; }  // مشترك
    public abstract void Sound();  // مختلف
}
```

2. **توابع جزئية**
```csharp
// إذا كان لديك تطبيق جزئي
abstract class Vehicle
{
    public void TurnOn()  // متشابه
    {
        Console.WriteLine("محرك مشغل");
    }
    
    public abstract void Drive();  // مختلف
}
```

3. **Constructors**
```csharp
// إذا كنت تحتاج Constructor
abstract class Employee
{
    protected string name;
    
    public Employee(string name)  // يجب تطبيقه في الوارثة
    {
        this.name = name;
    }
    
    public abstract void Work();
}
```

---

## الأخطاء الشائعة (10:30 - 11:30)

❌ **خطأ 1: إنشاء كائن من فئة مجردة**
```csharp
// خطأ
abstract class Animal { }
Animal a = new Animal();  // لا يمكن!

// صحيح
class Dog : Animal { }
Dog d = new Dog();  // يعمل
```

❌ **خطأ 2: نسيان تطبيق التابع المجرد**
```csharp
// خطأ
abstract class Animal
{
    public abstract void Eat();
}

class Dog : Animal
{
    // نسيان تطبيق Eat!
}

// صحيح
class Dog : Animal
{
    public override void Eat()
    {
        Console.WriteLine("يأكل");
    }
}
```

❌ **خطأ 3: الخلط بين abstract و override**
```csharp
// خطأ
class Dog : Animal
{
    public abstract void Eat()  // خطأ! يجب override
    {
    }
}

// صحيح
class Dog : Animal
{
    public override void Eat()  // override
    {
        Console.WriteLine("يأكل");
    }
}
```

---

## ملخص (11:30 - 12:00)

✅ تعلمنا:
- الفئات المجردة (Abstract Classes)
- التوابع المجردة (Abstract Methods)
- الفرق بين Class و Abstract و Interface
- كيفية تطبيق الفئات الوارثة

⏭️ **الدرس القادم:**
سوف نتعلم عن تعدد الأشكال (Polymorphism)
وهو من أقوى مفاهيم البرمجة الموجهة للكائنات!

شكراً لكم! 👋

---

**مدة الفيديو:** ~12 دقيقة  
**اللغة:** العربية  
**المستوى:** متقدم
