# نص الفيديو - الفئات العامة | Uppgift 9 Script

## الفيديو التاسع: الفئات والدوال العامة (Generics)

---

## المقدمة (0:00 - 1:00)

السلام عليكم!

في هذا الدرس الأخير سوف نتعلم عن الفئات العامة (Generics).

**Generics** تعني: فئة أو دالة تعمل مع **أي نوع بيانات**.

بدل كتابة نفس الكود لـ int، string، double... نكتبه مرة واحدة!

---

## المشكلة بدون Generics (1:00 - 2:30)

تخيل نريد Container يحفظ بيانات:

❌ **بدون Generics:**
```csharp
class IntContainer
{
    public int Item { get; set; }
}

class StringContainer
{
    public string Item { get; set; }
}

class DoubleContainer
{
    public double Item { get; set; }
}

// كود مكرر كثير! 😞
```

**المشاكل:**
- تكرار الكود
- صعب الصيانة
- ملل جداً!

✅ **مع Generics:**
```csharp
class Container<T>
{
    public T Item { get; set; }
}

// فقط فئة واحدة! 😊
```

---

## ما هي الـ T؟ (2:30 - 4:00)

**T = Type = نوع**

**T ليست حقيقية، بل عنصر نائب (placeholder):**

```csharp
class Container<T>  // T = نوع غير محدد
{
    public T Item { get; set; }  // Item من أي نوع
}

// الاستخدام:
Container<int> intBox = new Container<int>();
intBox.Item = 42;  // T = int

Container<string> stringBox = new Container<string>();
stringBox.Item = "Hello";  // T = string

Container<double> doubleBox = new Container<double>();
doubleBox.Item = 3.14;  // T = double
```

**عند الاستخدام:**
```
Container<int>      → T becomes int
Container<string>   → T becomes string
Container<Dog>      → T becomes Dog
```

---

## الفئة الأولى: GenericClass (4:00 - 6:00)

```csharp
class GenericClass<T>
{
    public T msg;  // خاصية من نوع T
    
    public void GenericMethod<TName, TLocation>(TName name, TLocation location)
    {
        Console.WriteLine(msg);
        Console.WriteLine($"Name: {name}");
        Console.WriteLine($"Location: {location}");
    }
}
```

**شرح:**

1. `class GenericClass<T>`
   - فئة عامة مع نوع واحد T

2. `public T msg`
   - خاصية من نوع T
   - عند الاستخدام تصير نوع محدد

3. `public void GenericMethod<TName, TLocation>(...)`
   - دالة عامة مع نوعين مختلفين
   - معاملات بأنواع عامة

---

## الفئة الثانية: SampleClass (6:00 - 7:15)

```csharp
class SampleClass
{
    public void Gmethod<A, B>(A a, B b)
    {
        Console.WriteLine($"Param1: {a}");
        Console.WriteLine($"Param2: {b}");
    }
}
```

**شرح:**

1. `public void Gmethod<A, B>(...)`
   - دالة عامة (ليس الفئة)
   - معاملات بأنواع عامة A و B

2. يمكن استدعاؤها بأنواع مختلفة:
```csharp
Gmethod<int, int>(1, 2);
Gmethod<string, string>("A", "B");
Gmethod<int, string>(5, "Five");
```

---

## البرنامج الرئيسي (7:15 - 8:45)

```csharp
static void Main()
{
    // Test 1: GenericClass<string>
    GenericClass<string> gc = new GenericClass<string>();
    gc.msg = "Välkommen till ABF!";
    gc.GenericMethod<string, string>("Stina Persson", "Helsingborg");
    
    Console.WriteLine();
    
    // Test 2: SampleClass
    SampleClass sc = new SampleClass();
    
    // Gmethod مع Int
    sc.Gmethod<int, int>(1, 2);
    
    // Gmethod مع String
    sc.Gmethod<string, string>("Gabriel Ruis", "Säffle");
}
```

**التدفق:**

**الجزء الأول:**
```
gc = new GenericClass<string>();  // T = string
gc.msg = "...";                    // msg من نوع string
gc.GenericMethod<string, string>("Stina Persson", "Helsingborg");
// TName = string, TLocation = string
```

**الجزء الثاني:**
```
sc = new SampleClass();
sc.Gmethod<int, int>(1, 2);
// A = int, B = int

sc.Gmethod<string, string>("Gabriel Ruis", "Säffle");
// A = string, B = string
```

---

## المخرجات (8:45 - 9:30)

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

## أمثلة إضافية (9:30 - 11:00)

### مثال 1: Stack عامة
```csharp
class Stack<T>
{
    private List<T> items = new List<T>();
    
    public void Push(T item)
    {
        items.Add(item);
    }
    
    public T Pop()
    {
        T item = items[items.Count - 1];
        items.RemoveAt(items.Count - 1);
        return item;
    }
}

// الاستخدام:
Stack<int> intStack = new Stack<int>();
intStack.Push(5);
intStack.Push(10);
Console.WriteLine(intStack.Pop());  // 10

Stack<string> stringStack = new Stack<string>();
stringStack.Push("Hello");
Console.WriteLine(stringStack.Pop());  // Hello
```

### مثال 2: Pair (زوج من القيم)
```csharp
class Pair<T, U>
{
    public T First { get; set; }
    public U Second { get; set; }
}

// الاستخدام:
Pair<string, int> p1 = new Pair<string, int>
{
    First = "العمر",
    Second = 25
};

Pair<int, int> p2 = new Pair<int, int>
{
    First = 10,
    Second = 20
};
```

---

## مزايا Generics (11:00 - 12:30)

### 1. إعادة الاستخدام
```csharp
// فئة واحدة لأي نوع
Container<int> intContainer = new Container<int>();
Container<string> stringContainer = new Container<string>();
Container<Dog> dogContainer = new Container<Dog>();
```

### 2. Type Safety (الأمان من الأنواع)
```csharp
Container<int> box = new Container<int>();
box.Item = 42;        // ✓ يعمل
box.Item = "Hello";   // ✗ خطأ! لا يقبل string
```

### 3. بدون Type Casting
```csharp
// بدون Generics:
object item = box.Item;
int value = (int)item;  // Type Casting

// مع Generics:
int value = box.Item;   // مباشرة، بدون Casting
```

### 4. أداء أفضل
```csharp
// بدون Generics قد يسبب boxing/unboxing
// مع Generics، لا overhead
```

---

## القيود (Constraints) (12:30 - 13:45)

أحياناً نريد تحديد نوع T قليلاً:

```csharp
// T يجب أن يكون class (فئة)
class Repository<T> where T : class
{
}

// T يجب أن يكون number
class Calculator<T> where T : struct
{
}

// T يجب أن ترث من Animal
class AnimalFarm<T> where T : Animal
{
}

// T يجب أن تطبق IComparable
class Sorter<T> where T : IComparable
{
}
```

---

## الأخطاء الشائعة (13:45 - 14:45)

❌ **خطأ 1: نسيان <T> عند التعريف**
```csharp
// خطأ
class Container
{
    public T Item { get; set; }  // T من أين؟
}

// صحيح
class Container<T>
{
    public T Item { get; set; }
}
```

❌ **خطأ 2: نسيان <Type> عند الاستخدام**
```csharp
// خطأ
Container box = new Container();
box.Item = 42;  // غير واضح ما نوع Item

// صحيح
Container<int> box = new Container<int>();
box.Item = 42;  // واضح أن Item من نوع int
```

❌ **خطأ 3: استخدام T بدون تحديده**
```csharp
// خطأ
Container<> box = new Container<>();  // فارغ!

// صحيح
Container<int> box = new Container<int>();
```

---

## متى نستخدم Generics؟ (14:45 - 15:30)

**استخدمات شائعة:**

1. **Collections (مجموعات)**
```csharp
List<int> numbers = new List<int>();
Dictionary<string, int> ages = new Dictionary<string, int>();
```

2. **Repositories (قواعد البيانات)**
```csharp
class UserRepository : IRepository<User> { }
class ProductRepository : IRepository<Product> { }
```

3. **Caching (حفظ مؤقت)**
```csharp
class Cache<T>
{
    public T Get(string key) { }
    public void Set(string key, T value) { }
}
```

4. **API Responses**
```csharp
class ApiResponse<T>
{
    public bool Success { get; set; }
    public T Data { get; set; }
}
```

---

## الخلاصة (15:30 - 16:00)

✅ تعلمنا:
- ما هي Generics
- Generic Classes و Generic Methods
- T كعنصر نائب للنوع
- فوائد Generics
- أمثلة عملية

---

## ملخص السلسلة كاملة (16:00 - 17:00)

تعلمنا **9 دروس مهمة:**

1. ✅ **Classes & ToString()** - الأساس
2. ✅ **Constructors & Destructors** - تهيئة وتنظيف
3. ✅ **Inheritance** - الوراثة
4. ✅ **Photo Album** - Constructors المتعددة
5. ✅ **Advanced Inheritance** - Type Casting
6. ✅ **Interfaces** - العقود
7. ✅ **Abstract Classes** - وسط الطريق
8. ✅ **Polymorphism** - تعدد الأشكال
9. ✅ **Generics** - فئات عامة

**الآن أنت جاهز لـ:**
- برمجة تطبيقات حقيقية
- فهم أي كود OOP
- كتابة كود احترافي

---

## شكراً وتوفيق (17:00 - 17:30)

شكراً على متابعتكم هذه السلسلة الكاملة!

تذكروا:
- البرمجة تحتاج **ممارسة**
- لا تستسلموا عند الأخطاء
- كل خطأ هو درس جديد
- استمتعوا بالبرمجة! 😊

**نصائحي الأخيرة:**
1. اكتبوا الكود بأيديكم
2. جربوا تعديلات
3. اقرأوا أكواد الآخرين
4. ابحثوا وتعلموا المزيد

**شكراً شكراً شكراً!** 👋

آخر كلمة: **الحمد لله على كل حال**

---

**مدة الفيديو:** ~17.5 دقيقة  
**اللغة:** العربية  
**المستوى:** متقدم

---

**سلسلة تعليمية شاملة عن OOP في C#**  
**من تعريف الفئات إلى الفئات العامة**

**شكراً لكم** 💙
