# نص الفيديو - الوراثة | Uppgift 3 Script

## الفيديو الثالث: الوراثة (Inheritance)

---

## المقدمة (0:00 - 0:45)

السلام عليكم ورحمة الله وبركاته!

في الدروس السابقة تعلمنا عن الفئات والبنائيات. اليوم سوف نتعلم عن مفهوم مهم جداً في البرمجة الموجهة للكائنات: **الوراثة**.

الوراثة هي من أهم المميزات التي تسبب عدم تكرار الكود!

---

## ما هي الوراثة؟ (0:45 - 2:30)

**الوراثة = Inheritance**

تعني: فئة ترث خصائص وتوابع من فئة أخرى.

**مثال من الطبيعة:**
```
      الحيوان (الفئة الأساسية)
         ↙        ↘
      كلب       قطة
     (ترث)     (ترث)
```

كل الحيوانات عندها:
- اسم
- قدرة على الأكل
- قدرة على النوم

لكن:
- الكلب يعوي 🐕
- القطة تموء 🐱

**في البرمجة:**
```
      Person (الفئة الأساسية)
        ↙      ↘
    Student   Teacher
   (ترث)     (ترث)
```

كل الأشخاص عندهم:
- اسم
- عمر
- تحية

لكن:
- الطالب يدرس
- المعلم يشرح

---

## الفئة الأساسية (2:30 - 4:00)

```csharp
class Person
{
    private string name;
    private int age;
    
    public Person()
    {
        name = "";
        age = 0;
    }
    
    public string Name
    {
        get { return name; }
        set { name = value; }
    }
    
    public int Age
    {
        get { return age; }
    }
    
    public void Greet()
    {
        Console.WriteLine("Hej!");
    }
    
    public void SetAge(int age)
    {
        this.age = age;
    }
}
```

**شرح:**
- `private` - خاص، لا يمكن الوصول من خارج الفئة
- `public` - عام، يمكن الوصول من أي مكان
- `Name` و `Age` - خصائص
- `Greet()` و `SetAge()` - توابع

---

## الفئات الوارثة (4:00 - 5:30)

**Student - فئة ترث من Person**
```csharp
class Student : Person
{
    public void Study()
    {
        Console.WriteLine("Jag pluggar!");
    }
}
```

**Teacher - فئة ترث من Person**
```csharp
class Teacher : Person
{
    public void Explain()
    {
        Console.WriteLine("Jag förklarar");
    }
}
```

**شرح الكود:**
- `: Person` - علامة الوراثة
- `Student` ترث كل شيء من `Person`
- `Student` لها بالإضافة `Study()` الخاصة بها فقط
- `Teacher` لها بالإضافة `Explain()` الخاصة بها فقط

**ماذا ترث Student من Person؟**
- ✅ الخاصية `Name`
- ✅ الخاصية `Age`
- ✅ التابع `Greet()`
- ✅ التابع `SetAge()`
- ➕ التابع الإضافي `Study()`

---

## البرنامج الرئيسي (5:30 - 7:00)

```csharp
static void Main()
{
    // 1. إنشاء Person عادية
    Person p1 = new Person();
    p1.Greet();  // "Hej!"
    
    // 2. إنشاء Student
    Student s1 = new Student();
    s1.SetAge(21);
    s1.Greet();  // "Hej!"
    Console.WriteLine($"Jag är {s1.Age} år gammal");
    s1.Study();  // "Jag pluggar!"
    
    // 3. إنشاء Teacher
    Teacher t1 = new Teacher();
    t1.SetAge(40);
    t1.Greet();  // "Hej!"
    t1.Explain();  // "Jag förklarar"
}
```

**ماذا يحدث:**

**الخطوة 1:**
- ننشئ Person عادية
- نستدعي `Greet()` → تطبع "Hej!"

**الخطوة 2:**
- ننشئ Student (وهي ترث من Person)
- نعيّن العمر 21 باستخدام `SetAge()` (موروثة)
- نستدعي `Greet()` (موروثة) → "Hej!"
- نطبع العمر → "Jag är 21 år gammal"
- نستدعي `Study()` (خاصة) → "Jag pluggar!"

**الخطوة 3:**
- ننشئ Teacher (وهي ترث من Person)
- نعيّن العمر 40
- نستدعي `Greet()` (موروثة)
- نستدعي `Explain()` (خاصة)

---

## المخرجات (7:00 - 7:45)

```
Hej!
Hej!
Jag är 21 år gammal
Jag pluggar!
Hej!
Jag förklarar
```

**التطابق:**
- الخط 1: من Person (p1.Greet())
- الخط 2-4: من Student (s1 methods)
- الخط 5-6: من Teacher (t1 methods)

---

## فوائد الوراثة (7:45 - 9:00)

**❌ بدون وراثة (تكرار كود):**
```csharp
// Student بدون وراثة
class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public void Greet() { ... }
    public void SetAge(int age) { ... }
    public void Study() { ... }
}

// Teacher بدون وراثة
class Teacher
{
    public string Name { get; set; }  // تكرار!
    public int Age { get; set; }      // تكرار!
    public void Greet() { ... }        // تكرار!
    public void SetAge(int age) { ... } // تكرار!
    public void Explain() { ... }
}
```

**✅ مع وراثة (بدون تكرار):**
```csharp
// Person - الفئة الأساسية
class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
    public void Greet() { ... }
    public void SetAge(int age) { ... }
}

// Student - ترث من Person
class Student : Person
{
    public void Study() { ... }  // فقط الإضافة
}

// Teacher - ترث من Person
class Teacher : Person
{
    public void Explain() { ... }  // فقط الإضافة
}
```

**الفوائد:**
- ✅ لا تكرار كود
- ✅ سهولة الصيانة
- ✅ إذا غيرت Person، كل الفئات الوارثة تتأثر
- ✅ كود أنظف وأقل حجماً

---

## المصطلحات (9:00 - 9:45)

| المصطلح | الترجمة | المعنى |
|--------|--------|--------|
| Parent Class | الفئة الأساسية | الفئة التي يتم الوراثة منها (Person) |
| Child Class | الفئة الوارثة | الفئة التي ترث (Student, Teacher) |
| Inheritance | الوراثة | عملية الوراثة باستخدام : |
| Base | الأساس | الفئة الأساسية |
| Derived | المشتقة | الفئة الوارثة |

---

## الأخطاء الشائعة (9:45 - 10:45)

❌ **خطأ 1: نسيان : في الوراثة**
```csharp
// خطأ
class Student Person  // بدون :
{
}

// صحيح
class Student : Person  // مع :
{
}
```

❌ **خطأ 2: عدم الوصول للخصائص الخاصة**
```csharp
// خطأ - name خاصية private
class Student : Person
{
    public void PrintName()
    {
        Console.WriteLine(name);  // خطأ!
    }
}

// صحيح - استخدام الخاصية العامة
class Student : Person
{
    public void PrintName()
    {
        Console.WriteLine(Name);  // صحيح!
    }
}
```

❌ **خطأ 3: الوراثة من أكثر من فئة واحدة**
```csharp
// خطأ في C#
class Student : Person, Teacher  // خطأ!
{
}

// الحل: استخدام Interfaces (درس لاحق)
```

---

## تمرين عملي (10:45 - 11:15)

**جرب بنفسك:**
1. أضف خاصية جديدة في Person مثل `Email`
2. سوف ترثها Student و Teacher تلقائياً
3. جرب الوصول إليها من Student و Teacher

```csharp
// أضف في Person
public string Email { get; set; }

// سوف تعمل في Student
s1.Email = "student@example.com";
```

---

## الخلاصة (11:15 - 11:45)

✅ تعلمنا:
- ما هي الوراثة
- الفئة الأساسية والفئات الوارثة
- كيف نستخدم `:` للوراثة
- فوائد الوراثة في تقليل التكرار

⏭️ **الدرس القادم:**
سوف نتعلم عن الوراثة المتقدمة وكيفية استخدام Type Casting
وأيضاً سوف نتعرف على الواجهات (Interfaces)!

شكراً لمتابعتكم! 👋

---

**مدة الفيديو:** ~12 دقيقة  
**اللغة:** العربية  
**المستوى:** متوسط
