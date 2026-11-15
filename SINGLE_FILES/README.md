# ملفات أحادية | Single File Assignments

## 📝 شرح | Description

هذا المجلد يحتوي على **جميع الواجبات التسعة في ملفات أحادية**.

كل واجب في **ملف واحد فقط** يحتوي على:
- الفئات (Classes)
- الواجهات (Interfaces)
- البرنامج الرئيسي (Main Program)

**لا حاجة لملفات منفصلة!** 🎉

---

## 📋 الملفات | Files

| # | الملف | الموضوع | التشغيل |
|---|--------|---------|---------|
| 1 | `Uppgift1_SingleFile.cs` | Classes & ToString | `dotnet run Uppgift1_SingleFile.cs` |
| 2 | `Uppgift2_SingleFile.cs` | Constructors | `dotnet run Uppgift2_SingleFile.cs` |
| 3 | `Uppgift3_SingleFile.cs` | Inheritance | `dotnet run Uppgift3_SingleFile.cs` |
| 4 | `Uppgift4_SingleFile.cs` | Photo Album | `dotnet run Uppgift4_SingleFile.cs` |
| 5 | `Uppgift5_SingleFile.cs` | Type Casting | `dotnet run Uppgift5_SingleFile.cs` |
| 6 | `Uppgift6_SingleFile.cs` | Interfaces | `dotnet run Uppgift6_SingleFile.cs` |
| 7 | `Uppgift7_SingleFile.cs` | Abstract | `dotnet run Uppgift7_SingleFile.cs` |
| 8 | `Uppgift8_SingleFile.cs` | Polymorphism | `dotnet run Uppgift8_SingleFile.cs` |
| 9 | `Uppgift9_SingleFile.cs` | Generics | `dotnet run Uppgift9_SingleFile.cs` |

---

## 🚀 كيفية التشغيل | How to Run

### الطريقة 1: تشغيل مباشر | Direct Run
```bash
# انتقل للمجلد
cd SINGLE_FILES

# شغّل أي واجب
dotnet run Uppgift1_SingleFile.cs

# أدخل البيانات حسب الواجب
```

### الطريقة 2: عبر .NET CLI
```bash
# بناء والتشغيل
dotnet run Uppgift1_SingleFile.cs <<EOF
Juan
Sara
Kalle
EOF
```

### الطريقة 3: VS Code
```
1. فتح الملف في VS Code
2. اضغط Ctrl+Shift+` (فتح Terminal)
3. اكتب: dotnet run Uppgift1_SingleFile.cs
4. أدخل البيانات
```

---

## ✅ مثال التشغيل | Example Run

```bash
$ cd SINGLE_FILES
$ dotnet run Uppgift1_SingleFile.cs
Juan
Sara
Kalle

Hej! Jag heter Juan
Hej! Jag heter Sara
Hej! Jag heter Kalle
```

---

## 💡 الفوائد | Benefits

✅ **ملف واحد** - أسهل للفهم  
✅ **بدون Projects** - لا حاجة لمجلدات معقدة  
✅ **سهل التشغيل** - تشغيل مباشر  
✅ **مناسب للتعلم** - يرى الكود كامل مرة واحدة  
✅ **بدون Dependencies** - فقط .NET SDK  

---

## 🎯 الفرق بين SINGLE_FILES والمشاريع الأصلية

| الميزة | Single Files | Original Projects |
|--------|--------------|-------------------|
| الملفات | 1 ملف | 3 ملفات (Program + Class + .csproj) |
| البساطة | أبسط كثير | أكثر تنظيماً |
| التشغيل | `dotnet run file.cs` | `dotnet run` |
| التعلم | أفضل للمبتدئين | أفضل للمشاريع الكبيرة |
| الكود | كامل في مكان واحد | موزع على ملفات |

---

## 📌 ملاحظات مهمة | Important Notes

1. **لا تحتاج .csproj** - فقط ملف .cs
2. **شغّل من نفس المجلد** - أو حدد المسار الكامل
3. **أدخل البيانات بنفس ترتيب الواجب** - انظر الشرح في كل ملف
4. **كل ملف مكتمل** - لا حاجة لملفات إضافية

---

## 🎓 الخطوات الموصى بها

```
1. اقرأ الملف (.cs)
2. فهم الكود
3. شغّل البرنامج
4. جرّب تعديلات
5. انتقل للواجب التالي
```

---

## ⚡ تشغيل سريع | Quick Run All

```bash
# في المجلد SINGLE_FILES:

echo "=== Task 1 ===" && dotnet run Uppgift1_SingleFile.cs <<EOF
Juan
Sara
Kalle
EOF

echo "=== Task 2 ===" && dotnet run Uppgift2_SingleFile.cs <<EOF
Juan
Sara
Kalle
EOF

# ... إلخ
```

---

**الآن لديك 9 ملفات أحادية جاهزة للاستخدام!** 🚀

---

**آخر تحديث:** 2026-11-15  
**الحالة:** ✅ كامل وجاهز  
**الملفات:** 9 ملفات C#
