# نص الفيديو - الواجهات | Uppgift 6 Script

## الفيديو السادس: الواجهات (Interfaces)

---

## المقدمة (0:00 - 0:45)

السلام عليكم!

في الدروس السابقة تعلمنا عن الوراثة. اليوم سوف نتعلم عن شيء مختلف تماماً: **الواجهات (Interfaces)**.

الواجهات تحدد **العقد** - ما يجب أن تفعله الفئة دون أن تحدد **كيف** تفعله!

---

## الفرق بين Class و Interface (0:45 - 2:30)

### Class (الفئة)
- تحتوي على بيانات (خصائص)
- تحتوي على تطبيق كامل (توابع)
- يمكن إنشاء كائن منها مباشرة
- فئة واحدة فقط للوراثة

### Interface (الواجهة)
- **فقط** العقد (بدون تطبيق)
- فقط أسماء التوابع المطلوبة
- لا يمكن إنشاء كائن منها مباشرة
- يمكن تطبيق عدة واجهات معاً

**مثال من الحياة الواقعية:**
- Interface = العقد / الاتفاق
- Class = التطبيق الفعلي

```
العقد: "هذه السيارة يجب أن تقود وتضيف بنزين"
━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━━
التطبيق 1: Car - تقود عادي وتضيف بنزين عادي
التطبيق 2: Tesla - تقود كهربائي وتضيف كهرباء
```

---

## الواجهة (Interface) (2:30 - 4:00)

```csharp
interface IVehicle
{
    void Drive();
    bool Refuel(int amount);
}
```

**شرح:**
- `interface` - كلمة حجزية للواجهة
- `IVehicle` - اسم الواجهة (تقليد: تبدأ بـ I)
- `Drive()` - تابع بدون تطبيق
- `Refuel()` - تابع بدون تطبيق
- لا يوجد أجسام (bodies) للتوابع

**القاعدة:**
الواجهة تقول: "أي فئة تطبقني يجب أن تطبق هذه التوابع"

---

## الفئة التي تطبق الواجهة (4:00 - 6:00)

```csharp
class Car : IVehicle
{
    private int fuel;
    
    public Car(int initialFuel)
    {
        fuel = initialFuel;
    }
    
    // تطبيق Drive من IVehicle
    public void Drive()
    {
        if (fuel > 0)
        {
            Console.WriteLine("Kör");
            fuel--;
        }
        else
        {
            Console.WriteLine("Ingen bränsle!");
        }
    }
    
    // تطبيق Refuel من IVehicle
    public bool Refuel(int amount)
    {
        fuel += amount;
        return true;
    }
}
```

**شرح:**
- `class Car : IVehicle` - Car تطبق IVehicle
- `private int fuel` - متغير خاص للبنزين
- `public void Drive()` - تطبيق التابع من الواجهة
  - إذا كان عندها بنزين، تقود
  - إذا لا، تطبع "لا بنزين"
- `public bool Refuel(int amount)` - تطبيق التابع
  - تضيف البنزين
  - ترجع true

---

## البرنامج الرئيسي (6:00 - 7:30)

```csharp
static void Main()
{
    // 1. إنشاء سيارة بدون بنزين
    Car myCar = new Car(0);
    
    // 2. قراءة كمية البنزين من المستخدم
    int fuelAmount = int.Parse(Console.ReadLine());
    
    // 3. إضافة البنزين
    myCar.Refuel(fuelAmount);
    
    // 4. حاول القيادة
    myCar.Drive();
}
```

**خطوة بخطوة:**

**الخطوة 1:**
```csharp
Car myCar = new Car(0);
```
- ننشئ سيارة بـ 0 بنزين
- Constructor ينفذ
- fuel = 0

**الخطوة 2:**
```csharp
int fuelAmount = int.Parse(Console.ReadLine());
```
- نقرأ من المستخدم: 50
- fuelAmount = 50

**الخطوة 3:**
```csharp
myCar.Refuel(fuelAmount);
```
- نستدعي Refuel(50)
- fuel = 0 + 50 = 50
- ترجع true

**الخطوة 4:**
```csharp
myCar.Drive();
```
- نستدعي Drive()
- fuel > 0؟ نعم
- تطبع "Kör"
- fuel-- (الآن = 49)

---

## المثال (7:30 - 8:30)

**المدخلات:**
```
50
```

**ما يحدث:**
1. Car(0) - سيارة بدون بنزين
2. Refuel(50) - إضافة 50 لتر
3. Drive() - fuel = 50 > 0 ✓

**المخرجات:**
```
Kör
```

---

## فوائد الواجهات (8:30 - 10:00)

### 1. العقد (Contract)
```csharp
interface IAnimal
{
    void Eat();
    void Sleep();
}

// أي فئة تطبق IAnimal يجب أن تطبق Eat و Sleep
class Dog : IAnimal { /* يجب تطبيق كل التوابع */ }
class Cat : IAnimal { /* يجب تطبيق كل التوابع */ }
```

### 2. تطبيق عدة واجهات
```csharp
// في C# يمكن تطبيق عدة واجهات (عكس الوراثة)
class Dog : IAnimal, IFlyable, ISwimmable
{
    // تطبيق جميع التوابع من الثلاث واجهات
}
```

### 3. الاستخدام المرن
```csharp
IVehicle[] vehicles = new IVehicle[3];
vehicles[0] = new Car(50);
vehicles[1] = new Car(30);
vehicles[2] = new Car(20);

// معاملة جميعها بنفس الطريقة
foreach (IVehicle v in vehicles)
{
    v.Drive();
}
```

---

## مثال متقدم (10:00 - 11:15)

```csharp
// واجهة للأكل
interface IEdible
{
    void Eat();
}

// واجهة للقيادة
interface IDrivable
{
    void Drive();
}

// فئة تطبق الاثنين!
class Robot : IEdible, IDrivable
{
    public void Eat()
    {
        Console.WriteLine("الروبوت يشحن البطارية");
    }
    
    public void Drive()
    {
        Console.WriteLine("الروبوت يقود");
    }
}

// الاستخدام
Robot r = new Robot();
r.Eat();    // الروبوت يشحن البطارية
r.Drive();  // الروبوت يقود
```

---

## الفرق بين Class و Interface (11:15 - 12:15)

| الميزة | Class | Interface |
|--------|-------|-----------|
| يحتوي على بيانات | ✅ نعم | ❌ لا |
| يحتوي على تطبيق | ✅ نعم | ❌ فقط توقيع |
| إنشاء كائن | ✅ نعم | ❌ لا |
| وراثة واحدة فقط | ✅ نعم | ❌ عدة واجهات |
| الغرض | تطبيق | عقد |

---

## الأخطاء الشائعة (12:15 - 13:15)

❌ **خطأ 1: نسيان تطبيق تابع من الواجهة**
```csharp
interface IVehicle
{
    void Drive();
    void Refuel();
}

// خطأ - نسيان Refuel
class Car : IVehicle
{
    public void Drive() { }
    // نسيان Refuel!
}

// صحيح
class Car : IVehicle
{
    public void Drive() { }
    public void Refuel() { }  // تطبيق كامل
}
```

❌ **خطأ 2: محاولة إنشاء كائن من واجهة**
```csharp
// خطأ
IVehicle v = new IVehicle();  // لا يمكن!

// صحيح
IVehicle v = new Car();  // من فئة تطبق الواجهة
```

❌ **خطأ 3: الخلط بين الواجهة والفئة**
```csharp
// خطأ - الواجهة ليست فئة
interface IPerson { }
class Student : IPerson { }  // يعمل
class Teacher : Student, IPerson { }  // يعمل

// لكن
class A : B, C { }  // فقط إذا كانت B, C واجهات
```

---

## الخلاصة (13:15 - 13:45)

✅ تعلمنا:
- الفرق بين Class و Interface
- كيفية تعريف واجهة
- كيفية تطبيق واجهة
- فوائد الواجهات والعقود

⏭️ **الدرس القادم:**
سوف نتعلم عن الفئات المجردة (Abstract Classes)
وهي وسط بين Class و Interface!

شكراً لمتابعتكم! 👋

---

**مدة الفيديو:** ~14 دقيقة  
**اللغة:** العربية  
**المستوى:** متقدم
