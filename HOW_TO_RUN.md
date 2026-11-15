# كيفية تشغيل الواجبات | How to Run the Code

## 🚀 الطريقة الأولى: استخدام Visual Studio (الأسهل)
### Method 1: Visual Studio (Easiest)

### الخطوات | Steps:

#### 1️⃣ فتح الحل | Open the Solution
```
1. افتح Visual Studio
2. اذهب إلى: File → Open → Project/Solution
3. اختر: OOP_Assignments.sln
4. انتظر التحميل الكامل (قد يأخذ دقيقة)
```

#### 2️⃣ اختيار المشروع الأول | Select Project 1
```
في Solution Explorer (يمين الشاشة):
├─ Uppgift1_ToString
│  ├─ Program.cs
│  ├─ Person.cs
│  └─ Uppgift1_ToString.csproj
```

انقر بزر الماوس الأيمن على `Uppgift1_ToString` واختر:
```
Set as Startup Project
```

#### 3️⃣ تشغيل البرنامج | Run the Program
```
اضغط: F5  أو  Ctrl+F5

أو من القائمة:
Debug → Start Debugging
```

#### 4️⃣ إدخال البيانات | Enter Input
ستظهر نافذة terminal تطلب منك 3 أسماء:

```
اكتب: Juan
اضغط: Enter

اكتب: Sara
اضغط: Enter

اكتب: Kalle
اضغط: Enter
```

#### 5️⃣ النتيجة | Result
ستشاهد:
```
Hej! Jag heter Juan
Hej! Jag heter Sara
Hej! Jag heter Kalle
```

---

## 💻 الطريقة الثانية: سطر الأوامر (Command Line)
### Method 2: Command Line

### الخطوات | Steps:

#### 1️⃣ فتح Terminal/Command Prompt
**Windows:**
```
ابدأ → اكتب: cmd
اضغط: Enter
```

**Mac/Linux:**
```
⌘ + Space
اكتب: Terminal
اضغط: Enter
```

#### 2️⃣ الذهاب إلى المجلد الصحيح | Navigate to Folder
```bash
cd /Users/mustafa.elnagar/Documents/GitHub/Hefzi
```

أو
```bash
cd C:\Users\[YourUsername]\Documents\GitHub\Hefzi
```

#### 3️⃣ الانتقال إلى مشروع الأول | Go to Project 1
```bash
cd Uppgift1_ToString
```

#### 4️⃣ بناء المشروع | Build
```bash
dotnet build
```

#### 5️⃣ تشغيل البرنامج | Run
```bash
dotnet run
```

#### 6️⃣ إدخال البيانات | Input Data
```
Juan
Sara
Kalle
```

#### 7️⃣ النتيجة | Output
```
Hej! Jag heter Juan
Hej! Jag heter Sara
Hej! Jag heter Kalle
```

---

## 📝 الطريقة الثالثة: VS Code
### Method 3: VS Code

### الخطوات | Steps:

#### 1️⃣ فتح المجلد | Open Folder
```
1. افتح VS Code
2. File → Open Folder
3. اختر مجلد: Hefzi
```

#### 2️⃣ تثبيت الإضافات | Install Extensions
```
في VS Code:
1. اذهب إلى: Extensions (على اليسار)
2. ابحث عن: C#
3. ثبت: C# by Microsoft
4. انتظر التثبيت والتحميل
```

#### 3️⃣ فتح Terminal | Open Terminal
```
Ctrl + ~ (أو من: Terminal → New Terminal)
```

#### 4️⃣ الأوامر | Commands
```bash
# انتقل إلى المشروع الأول
cd Uppgift1_ToString

# بناء
dotnet build

# تشغيل
dotnet run
```

#### 5️⃣ أدخل البيانات | Enter Input
```
Juan
Sara
Kalle
```

#### 6️⃣ شاهد النتيجة | See Output
```
Hej! Jag heter Juan
Hej! Jag heter Sara
Hej! Jag heter Kalle
```

---

## ✅ التحقق من التثبيت | Verify Installation

قبل البدء، تأكد من تثبيت .NET SDK:

### Windows:
```bash
dotnet --version
```

يجب أن ترى شيئاً مثل:
```
6.0.xxx أو أعلى
```

### إذا لم يُثبت:
```
اذهب إلى: https://dotnet.microsoft.com/download
ثبت: .NET 6.0 SDK أو أحدث
```

---

## 🎯 أسرع طريقة | Quickest Way

**الأسرع = استخدام Visual Studio:**

```
1. فتح Visual Studio
2. File → Open → OOP_Assignments.sln
3. Solution Explorer → Uppgift1_ToString → Set as Startup
4. اضغط F5
5. أدخل: Juan, Sara, Kalle
6. خلاص!
```

---

## 🐛 استكشاف الأخطاء | Troubleshooting

### ❌ خطأ: "dotnet command not found"
```
✅ الحل:
- ثبت .NET SDK من:
  https://dotnet.microsoft.com/download
- أعد تشغيل Terminal بعد التثبيت
```

### ❌ خطأ: "Project file not found"
```
✅ الحل:
- تأكد أنك في المجلد الصحيح
- استخدم: ls (Mac/Linux) أو dir (Windows)
- يجب أن ترى ملف .csproj
```

### ❌ خطأ: "Build failed"
```
✅ الحل:
- جرب: dotnet clean
- ثم: dotnet build
- إذا فشل، اقرأ الأخطاء بعناية
```

### ❌ خطأ: "Input invalid"
```
✅ الحل:
- تأكد من إدخال نصوص (أسماء)
- ليس أرقام
- اضغط Enter بعد كل اسم
```

---

## 📚 الملفات المهمة | Important Files

**للواجب الأول:**
```
Uppgift1_ToString/
├── Program.cs          (البرنامج الرئيسي)
├── Person.cs           (فئة Person)
└── Uppgift1_ToString.csproj  (ملف المشروع)
```

**اقرأ الملفات:**
- `Person.cs` - الفئة البسيطة
- `Program.cs` - البرنامج الرئيسي

---

## 🎮 بعد التشغيل الأول | After First Run

### جرّب التعديلات | Try Modifications:

#### تعديل 1: غيّر الرسالة
في `Person.cs`:
```csharp
// من:
return $"Hej! Jag heter {Name}";

// إلى:
return $"Hello! My name is {Name}";
```

ثم شغّل مرة أخرى!

#### تعديل 2: أضف أسماء أكثر
في `Program.cs`:
```csharp
// من:
Person[] people = new Person[3];

// إلى:
Person[] people = new Person[5];
```

#### تعديل 3: استخدم مدخل مختلف
```
محاولة:
أحمد
فاطمة
محمود
```

---

## ✨ نصائح مهمة | Important Tips

```
✅ ابدأ بالواجب الأول دائماً
✅ تأكد من المجلد الصحيح
✅ اقرأ رسائل الأخطاء بعناية
✅ جرّب التعديلات بنفسك
✅ لا تستعجل في الفهم
✅ استمتع بالعملية!
```

---

## 📞 احصل على المساعدة | Get Help

### إذا واجهت مشكلة:

1. **اقرأ رسالة الخطأ** - تحتوي على معلومات قيمة
2. **ابحث عن الخطأ** - Google + رسالة الخطأ
3. **جرّب Solutions في StackOverflow**
4. **راجع الملفات الأساسية** - Person.cs و Program.cs

---

## 🎓 الخطوة التالية | Next Step

بعد تشغيل الواجب الأول بنجاح:

```
1. اقرأ الكود وافهمه تماماً
2. جرّب تعديلات صغيرة
3. انتقل للواجب الثاني
4. كرّر العملية
```

---

**تم الإنجاز!** ✅

الآن أنت جاهز لتشغيل أول برنامج OOP! 🚀

---

**آخر تحديث:** 2026-11-15  
**اللغة:** العربية والإنجليزية
