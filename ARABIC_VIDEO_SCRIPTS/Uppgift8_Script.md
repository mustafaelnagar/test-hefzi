# نص الفيديو - تعدد الأشكال | Uppgift 8 Script

## الفيديو الثامن: تعدد الأشكال (Polymorphism)

---

## المقدمة (0:00 - 1:00)

السلام عليكم!

"Polymorphism" كلمة يونانية معناها: "poly" = كثير، "morph" = شكل.

يعني: **نفس الاسم، أشكال مختلفة**.

هذا من أقوى مفاهيم البرمجة الموجهة للكائنات!

---

## نوع 1: Method Overloading (1:00 - 3:30)

### ما هو Method Overloading؟

نفس اسم التابع، لكن معاملات مختلفة.
البرنامج يختار الصحيح حسب المعاملات.

### مثال: Calculator

```csharp
class Calculator
{
    // Overloading 1: جمع الأعداد الصحيحة
    public void Sum(int a, int b)
    {
        int result = a + b;
        Console.WriteLine($"Summan av {a} och {b} är {result}");
    }
    
    // Overloading 2: جمع الأعداد العشرية
    public void Sum(float a, float b)
    {
        float result = a + b;
        Console.WriteLine($"Summan av {a} och {b} är {result}");
    }
    
    // Overloading 3: جمع النصوص (عملياً)
    public void Sum(string a, string b)
    {
        Console.WriteLine($"{a} - är inte numeriskt");
    }
}
```

**ثلاثة Sum مختلفة:**
1. `Sum(int, int)` - نوع مختلف
2. `Sum(float, float)` - نوع مختلف
3. `Sum(string, string)` - نوع مختلف

**كيف يعرف البرنامج أيها يستخدم؟**
حسب نوع المعاملات!

```csharp
calc.Sum(5, 4);          // int → Overloading 1
calc.Sum(9.3f, 8.6f);    // float → Overloading 2
calc.Sum("Hello", "World");  // string → Overloading 3
```

---

## الاستخدام - الجزء الأول (3:30 - 5:00)

```csharp
static void Main()
{
    Calculator calc = new Calculator();
    
    // Test 1: Int
    calc.Sum(5, 4);
    // Output: Summan av 5 och 4 är 9
    
    // Test 2: Float
    calc.Sum(9.3f, 8.6f);
    // Output: Summan av 9,3 och 8,6 är 17,900002
    
    // Test 3: String
    calc.Sum("Hej världen", "test");
    // Output: Hej världen - är inte numeriskt
}
```

---

## نوع 2: Method Overriding (5:00 - 7:30)

### ما هو Method Overriding؟

الفئة الوارثة **استبدل** التابع من الفئة الأساسية.

### مثال: Ice Cream

```csharp
// الفئة الأساسية
class IceCream
{
    public IceCream()
    {
        Console.WriteLine("Class : Icecream");
    }
    
    // تابع virtual (يمكن استبداله)
    public virtual void Flavor()
    {
        Console.WriteLine("IceCream Type : Vanilj");
    }
}

// الفئة الوارثة
class Chocolate : IceCream
{
    public Chocolate()
    {
        Console.WriteLine("Class : Chocolate");
    }
    
    // استبدال التابع
    public override void Flavor()
    {
        Console.WriteLine("IceCream Type : Chocolate");
    }
}
```

**الفرق:**
- `virtual` - في الفئة الأساسية (يمكن استبداله)
- `override` - في الفئة الوارثة (استبدال)

---

## الاستخدام - الجزء الثاني (7:30 - 9:00)

```csharp
// إنشاء كائن Chocolate
Chocolate choco = new Chocolate();

// عند الإنشاء يطبع:
// Class : Icecream (من IceCream Constructor)
// Class : Chocolate (من Chocolate Constructor)

// استدعاء الدالة
choco.Flavor();
// Output: IceCream Type : Chocolate
```

**ملاحظة:**
- عند `new Chocolate()` ينفذ Constructors بالترتيب
- الأساسي أولاً (IceCream)
- ثم الوارثة (Chocolate)

---

## الفرق بين Overloading و Overriding (9:00 - 10:30)

### Overloading (تحميل)
```csharp
class Calculator
{
    public void Sum(int a, int b) { }
    public void Sum(float a, float b) { }  // نفس الاسم، معاملات مختلفة
    public void Sum(string a, string b) { }
}

// البرنامج يختار بناءً على المعاملات
calc.Sum(5, 4);          // Overloading 1
calc.Sum(9.3f, 8.6f);    // Overloading 2
calc.Sum("a", "b");      // Overloading 3
```

### Overriding (استبدال)
```csharp
class Animal
{
    public virtual void Sound() { }
}

class Dog : Animal
{
    public override void Sound() { }  // استبدال من الفئة الوارثة
}

Animal a = new Dog();
a.Sound();  // Dog's Sound
```

**الفرق الأساسي:**
- **Overloading**: في نفس الفئة، معاملات مختلفة
- **Overriding**: في فئات مختلفة، استبدال

---

## المخرجات (10:30 - 11:15)

```
Summan av 5 och 4 är 9
Summan av 9,3 och 8,6 är 17,900002
Hej världen - är inte numeriskt
Class : Icecream
Class : Chocolate
IceCream Type : Chocolate
```

**التطابق:**
- Lines 1-3: Overloading
- Lines 4-6: Overriding + Constructors

---

## مثال متقدم: Polymorphic Animals (11:15 - 12:45)

```csharp
class Animal
{
    public virtual void Speak()
    {
        Console.WriteLine("حيوان");
    }
}

class Dog : Animal
{
    public override void Speak()
    {
        Console.WriteLine("ولولة");
    }
}

class Cat : Animal
{
    public override void Speak()
    {
        Console.WriteLine("مياء");
    }
}

// الاستخدام
Animal[] animals = new Animal[2];
animals[0] = new Dog();
animals[1] = new Cat();

foreach (Animal animal in animals)
{
    animal.Speak();  // كل واحد يتكلم بطريقته!
}

// Output:
// ولولة
// مياء
```

---

## الأخطاء الشائعة (12:45 - 13:45)

❌ **خطأ 1: نسيان virtual في الأساسي**
```csharp
// خطأ
class Animal
{
    public void Speak()  // بدون virtual
    {
    }
}

class Dog : Animal
{
    public override void Speak()  // قد لا يعمل كما متوقع
    {
    }
}

// صحيح
class Animal
{
    public virtual void Speak()  // مع virtual
    {
    }
}

class Dog : Animal
{
    public override void Speak()  // يعمل صحيح
    {
    }
}
```

❌ **خطأ 2: الخلط بين Overloading و Overriding**
```csharp
// خطأ - هذا Overloading وليس Overriding
class Dog : Animal
{
    public void Speak(string word)  // معاملات مختلفة
    {
    }
}

// صحيح - هذا Overriding
class Dog : Animal
{
    public override void Speak()  // نفس التوقيع
    {
    }
}
```

❌ **خطأ 3: نسيان override**
```csharp
// قد يسبب مشاكل
class Dog : Animal
{
    public void Speak()  // بدون override
    {
    }
}

// صحيح
class Dog : Animal
{
    public override void Speak()  // مع override
    {
    }
}
```

---

## فوائد Polymorphism (13:45 - 14:45)

### 1. المرونة
```csharp
// يمكن التعامل مع جميع الأنواع بنفس الطريقة
Animal[] animals = new Animal[100];
foreach (Animal a in animals)
{
    a.Speak();  // كل واحد يتكلم بطريقته
}
```

### 2. سهولة الإضافة
```csharp
// إذا أضفنا حيوان جديد
class Bird : Animal
{
    public override void Speak()
    {
        Console.WriteLine("تغريد");
    }
}

// الكود القديم يعمل بدون تعديل!
animals[99] = new Bird();
animals[99].Speak();  // يعمل تلقائياً
```

### 3. قابلية الصيانة
```csharp
// بدل:
if (dog is Dog) ((Dog)dog).Speak();
else if (cat is Cat) ((Cat)cat).Speak();
else if (bird is Bird) ((Bird)bird).Speak();

// نستخدم:
animal.Speak();  // بسيط جداً!
```

---

## الخلاصة (14:45 - 15:15)

✅ تعلمنا:
- Method Overloading (نفس الاسم، معاملات مختلفة)
- Method Overriding (استبدال التابع)
- virtual و override
- فوائد Polymorphism

⏭️ **الدرس القادم:**
سوف نتعلم عن الفئات والدوال العامة (Generic Classes)
آخر مفهوم مهم جداً!

شكراً لكم! 👋

---

**مدة الفيديو:** ~15.5 دقيقة  
**اللغة:** العربية  
**المستوى:** متقدم
