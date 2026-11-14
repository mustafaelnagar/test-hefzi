# نص الفيديو - الفوتو ألبوم | Uppgift 4 Script

## الفيديو الرابع: الألبوم الفوتوغرافي (Photo Album)

---

## المقدمة (0:00 - 0:30)

السلام عليكم ورحمة الله وبركاته!

في هذا الدرس سوف نتعلم عن:
- البنائيات المتعددة (Multiple Constructors)
- الوراثة المتقدمة
- Base Constructor

---

## المشكلة (0:30 - 2:00)

تخيل أن معك ألبوم صور:
- بعض الألبومات فيها 16 صفحة
- بعضها فيها 24 صفحة
- الألبومات الكبيرة فيها 64 صفحة

**المتطلبات:**
- نريد فئة PhotoBook لحفظ أي عدد صفحات
- الافتراضي 16 صفحة
- فئة BigPhotoBook للألبومات الكبيرة 64 صفحة

**الحل: استخدام Constructors المتعددة**

---

## الفئة الأساسية (2:00 - 3:30)

```csharp
class PhotoBook
{
    private int numPages;
    
    // Constructor 1: بدون معاملات (الافتراضي)
    public PhotoBook()
    {
        numPages = 16;
    }
    
    // Constructor 2: مع معامل
    public PhotoBook(int pages)
    {
        numPages = pages;
    }
    
    // طريقة للحصول على عدد الصفحات
    public int GetNumberPages()
    {
        return numPages;
    }
}
```

**شرح:**
- **Constructor 1** بدون معاملات
  - يعيّن 16 صفحة افتراضياً
  - يُستخدم عند: `new PhotoBook()`

- **Constructor 2** مع معامل
  - يعيّن عدد الصفحات المُمرر
  - يُستخدم عند: `new PhotoBook(24)`

- **Overloading**
  - نفس الاسم (PhotoBook)
  - معاملات مختلفة (صفر / واحد)
  - البرنامج يختار الصحيح تلقائياً

---

## الفئة الوارثة (3:30 - 4:45)

```csharp
class BigPhotoBook : PhotoBook
{
    public BigPhotoBook() : base(64)
    {
    }
}
```

**شرح:**
- `BigPhotoBook` ترث من `PhotoBook`
- Constructor بدون معاملات
- `: base(64)` - استدعاء Constructor الأساسي مع 64
  - **Base = الفئة الأساسية**
  - يُمرر 64 إلى PhotoBook Constructor

**ماذا يحدث؟**
1. ننشئ `BigPhotoBook` جديد
2. تستدعي `base(64)` تلقائياً
3. يعمل `PhotoBook` Constructor مع 64
4. النتيجة: ألبوم بـ 64 صفحة

---

## البرنامج الرئيسي (4:45 - 6:00)

```csharp
static void Main()
{
    // Test 1: Constructors الافتراضي
    PhotoBook album1 = new PhotoBook();
    Console.WriteLine(album1.GetNumberPages());
    // Output: 16
    
    // Test 2: Constructor مع معامل
    PhotoBook album2 = new PhotoBook(24);
    Console.WriteLine(album2.GetNumberPages());
    // Output: 24
    
    // Test 3: BigPhotoBook
    BigPhotoBook album3 = new BigPhotoBook();
    Console.WriteLine(album3.GetNumberPages());
    // Output: 64
}
```

**التدفق:**

**الاختبار 1:**
```
new PhotoBook()
↓
استدعاء Constructor بدون معاملات
↓
numPages = 16
↓
GetNumberPages() → 16
```

**الاختبار 2:**
```
new PhotoBook(24)
↓
استدعاء Constructor مع معامل
↓
numPages = 24
↓
GetNumberPages() → 24
```

**الاختبار 3:**
```
new BigPhotoBook()
↓
استدعاء BigPhotoBook Constructor
↓
استدعاء base(64) تلقائياً
↓
استدعاء PhotoBook(64) Constructor
↓
numPages = 64
↓
GetNumberPages() → 64
```

---

## المخرجات (6:00 - 6:30)

```
16
24
64
```

بسيطة جداً! لكن الفكرة وراءها مهمة جداً.

---

## مفاهيم جديدة (6:30 - 8:00)

### 1. Constructors المتعددة (Overloading)
```csharp
public PhotoBook()           // Constructor 1
public PhotoBook(int pages)  // Constructor 2
```

- نفس الاسم
- معاملات مختلفة
- البرنامج يختار حسب المعاملات

### 2. Base Constructor
```csharp
public BigPhotoBook() : base(64)
```

- `:` متبوعة بـ `base`
- يستدعي Constructor الأساسي
- مهم جداً للوراثة

### 3. Default Value
```csharp
public PhotoBook()
{
    numPages = 16;  // القيمة الافتراضية
}
```

- عندما لا يُمرر معامل
- نستخدم قيمة افتراضية

---

## مثال متقدم (8:00 - 9:15)

تخيل نريد نسخة متوسطة أيضاً:

```csharp
class MediumPhotoBook : PhotoBook
{
    public MediumPhotoBook() : base(32)
    {
        Console.WriteLine("تم إنشاء ألبوم متوسط بـ 32 صفحة");
    }
}

// الاستخدام
MediumPhotoBook m = new MediumPhotoBook();
// Output: تم إنشاء ألبوم متوسط بـ 32 صفحة
Console.WriteLine(m.GetNumberPages());
// Output: 32
```

---

## الأخطاء الشائعة (9:15 - 10:15)

❌ **خطأ 1: نسيان Base Constructor**
```csharp
// خطأ
class BigPhotoBook : PhotoBook
{
    public BigPhotoBook()  // بدون : base
    {
        // لن يعرف كم صفحة!
    }
}

// صحيح
class BigPhotoBook : PhotoBook
{
    public BigPhotoBook() : base(64)  // مع : base
    {
    }
}
```

❌ **خطأ 2: أسماء Constructors مختلفة**
```csharp
// خطأ
public PhotoBook()
{
}

public void PhotoBook(int pages)  // void خطأ!
{
}

// صحيح
public PhotoBook()
{
}

public PhotoBook(int pages)  // بدون void
{
}
```

❌ **خطأ 3: عدم استخدام Base عند الوراثة**
```csharp
// قد يسبب مشاكل
class BigPhotoBook : PhotoBook
{
    public BigPhotoBook()
    {
        // لم نستدعي base!
        // قد لا يتم تهيئة الأساسي بشكل صحيح
    }
}
```

---

## حالات الاستخدام الحقيقية (10:15 - 11:00)

**أمثلة من الحياة الواقعية:**

1. **قاعدة بيانات:**
```csharp
class Database
{
    public Database()              // الافتراضي
    { }
    
    public Database(string server) // مع خادم
    { }
    
    public Database(string server, int port)  // مع خادم وميناء
    { }
}
```

2. **ملف:**
```csharp
class File
{
    public File()                       // ملف فارغ
    { }
    
    public File(string path)            // من مسار
    { }
}
```

---

## الخلاصة (11:00 - 11:30)

✅ تعلمنا:
- Constructors المتعددة
- استخدام Base للوراثة
- القيم الافتراضية
- Overloading في الـ Constructors

⏭️ **الدرس القادم:**
سوف نتعلم عن الواجهات (Interfaces)
وكيف تختلف عن الوراثة!

شكراً لكم! 👋

---

**مدة الفيديو:** ~11.5 دقيقة  
**اللغة:** العربية  
**المستوى:** متوسط
