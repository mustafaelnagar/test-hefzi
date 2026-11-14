# نص الفيديو - البنائيات والمدمرات | Uppgift 2 Script

## الفيديو الثاني: Constructors و Destructors

---

## المقدمة (0:00 - 0:30)

السلام عليكم ورحمة الله وبركاته!

في الدرس الأول تعلمنا عن الفئات والتوابع. اليوم سوف نتعلم عن طرق خاصة جداً تُسمى البنائيات والمدمرات.

هذان الطريقتان مهمتان جداً لتهيئة وتنظيف الكائنات.

---

## ما هو Constructor؟ (0:30 - 2:00)

**Constructor = البناء = البنّاء**

هو طريقة خاصة تنفذ **تلقائياً** عند إنشاء كائن جديد.

**مثال من الحياة الواقعية:**
- عندما تشتري هاتف جديد، تفتحه وتشغّله للمرة الأولى
- هذا التشغيل الأول = Constructor

**في البرمجة:**
```csharp
Person p = new Person();  // هنا ينفذ Constructor تلقائياً
```

**فائدته:**
- تهيئة البيانات
- إعداد الكائن للعمل
- تنفيذ عمليات ضرورية

---

## ما هو Destructor؟ (2:00 - 3:30)

**Destructor = الهدم = الهادم**

هو طريقة خاصة تنفذ **تلقائياً** عند حذف الكائن من الذاكرة.

**مثال من الحياة الواقعية:**
- عندما تحطم الهاتف القديم
- تنظيفه وتخزينه = Destructor

**في البرمجة:**
```csharp
p = null;  // أو نهاية البرنامج
// هنا ينفذ Destructor تلقائياً
```

**فائدته:**
- تنظيف الموارد
- تحرير الذاكرة
- إيقاف العمليات المستمرة

---

## الكود - الفئة (3:30 - 5:00)

```csharp
class Person
{
    public string Name { get; set; }
    
    // Constructor - البناء
    public Person(string name)
    {
        Name = name;
        Console.WriteLine($"تم إنشاء شخص اسمه {name}");
    }
    
    // Destructor - الهدم
    ~Person()
    {
        Console.WriteLine($"تم حذف {Name}");
        Name = "";
    }
    
    public override string ToString()
    {
        return $"Hej! Jag heter {Name}";
    }
}
```

**شرح السطور:**

1. `public Person(string name)`
   - اسم الطريقة نفس اسم الفئة (Person)
   - بها معامل (parameter): الاسم
   - هذا هو Constructor

2. `Name = name`
   - نحفظ الاسم المستقبل في الخاصية

3. `Console.WriteLine(...)` داخل Constructor
   - تطبع رسالة عند الإنشاء
   - لتأكيد أن Constructor نفذت

4. `~Person()`
   - علامة ~ تعني Destructor
   - بدون معاملات
   - تنفذ عند حذف الكائن

5. `Name = ""`
   - تنظيف البيانات قبل الحذف

---

## البرنامج الرئيسي (5:00 - 6:30)

```csharp
static void Main()
{
    Person[] people = new Person[3];
    
    for (int i = 0; i < 3; i++)
    {
        string name = Console.ReadLine();
        people[i] = new Person(name);  // Constructor ينفذ هنا!
    }
    
    foreach (Person p in people)
    {
        Console.WriteLine(p);
    }
    
    // هنا Destructor تنفذ لكل كائن
}
```

**ما يحدث:**
1. نقرأ اسم من المستخدم
2. ننشئ كائن `new Person(name)`
   - **Constructor تنفذ تلقائياً!**
   - تطبع: "تم إنشاء شخص اسمه ..."
3. نحفظ في المصفوفة
4. في النهاية Destructors تنفذ
   - تطبع: "تم حذف ..."

---

## مثال التشغيل (6:30 - 7:30)

**المدخلات:**
```
Juan
Sara
Kalle
```

**ما يحدث بالترتيب:**

```
[عند إدخال Juan]
تم إنشاء شخص اسمه Juan

[عند إدخال Sara]
تم إنشاء شخص اسمه Sara

[عند إدخال Kalle]
تم إنشاء شخص اسمه Kalle

[عند الطباعة]
Hej! Jag heter Juan
Hej! Jag heter Sara
Hej! Jag heter Kalle

[عند انتهاء البرنامج]
تم حذف Kalle
تم حذف Sara
تم حذف Juan
```

---

## الفرق بين Task 1 و Task 2 (7:30 - 8:30)

**Task 1: بدون Constructor**
```csharp
Person p = new Person();
p.Name = "Juan";  // تعيين يدوي بعد الإنشاء
```

**Task 2: مع Constructor**
```csharp
Person p = new Person("Juan");  // تعيين أثناء الإنشاء
```

**الفرق:**
- Task 1: إنشاء ثم تعيين
- Task 2: إنشاء وتعيين معاً (أفضل!)

---

## متى نستخدم Constructor و Destructor؟ (8:30 - 9:30)

**Constructor - متى؟**
- ✅ إنشاء كائن جديد
- ✅ تهيئة البيانات
- ✅ فتح ملفات أو قواعد بيانات
- ✅ إعداد موارد

**Destructor - متى؟**
- ✅ غلق الملفات
- ✅ تحرير الذاكرة
- ✅ إغلاق الاتصالات
- ⚠️ نادراً ما يُستخدم في C# الحديثة

---

## الأخطاء الشائعة (9:30 - 10:30)

❌ **خطأ 1: نسيان معاملات Constructor**
```csharp
// خطأ
public Person()  // بدون معاملات
{
    Name = "Juan";  // اسم ثابت!
}

// صحيح
public Person(string name)  // مع معامل
{
    Name = name;  // حفظ المعامل
}
```

❌ **خطأ 2: اسم مختلف للـ Constructor**
```csharp
// خطأ
public Foo Person()  // اسم مختلف
{
}

// صحيح
public Person()  // نفس اسم الفئة
{
}
```

❌ **خطأ 3: Destructor مع معاملات**
```csharp
// خطأ
~Person(string name)  // خطأ!

// صحيح
~Person()  // بدون معاملات
{
}
```

---

## تمرين عملي (10:30 - 11:00)

**جرب بنفسك:**
1. غيّر الرسائل المطبوعة في Constructor و Destructor
2. أضف عملية إضافية في Constructor (مثل حساب العمر)
3. لاحظ ترتيب تنفيذ Destructors (من الآخر للأول)

---

## الخلاصة (11:00 - 11:30)

✅ تعلمنا:
- Constructor ينفذ عند الإنشاء
- Destructor ينفذ عند الحذف
- استخدام المعاملات في Constructor
- الفرق بين Task 1 و Task 2

⏭️ **الدرس القادم:**
سوف نتعلم عن الوراثة (Inheritance)
وكيف يمكن فئة أن ترث من فئة أخرى!

شكراً لكم ولا تنسوا الاشتراك! 👋

---

**مدة الفيديو:** ~11.5 دقائق  
**اللغة:** العربية  
**المستوى:** مبتدئ-متوسط
