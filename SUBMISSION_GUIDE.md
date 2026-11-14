# دليل التسليم | Submission Guide

## قبل التسليم | Before Submission

### تنظيف المشروع | Clean the Project

قبل تحويل المشروع إلى ZIP، تأكد من تنظيفه لتقليل حجم الملف.

**Before converting to ZIP, clean the project to reduce file size.**

#### في Visual Studio | In Visual Studio
```
1. افتح Visual Studio
2. اذهب إلى Build → Clean Solution
3. انتظر حتى ينتهي
```

#### من سطر الأوامر | From Command Line
```bash
# نظف كل المشاريع
dotnet clean

# أو قم بحذف مجلدات bin و obj يدويا
# Linux/Mac:
find . -type d -name "bin" -o -name "obj" | xargs rm -rf

# Windows (PowerShell):
Get-ChildItem -Include bin,obj -Recurse | Remove-Item -Recurse
```

---

## إنشاء ZIP ملف | Create ZIP File

### الطريقة 1: من سطر الأوامر | Method 1: Command Line
```bash
# تأكد من أنك في مجلد OOP_Assignments
cd /Users/mustafa.elnagar/Documents/GitHub/Hefzi

# إنشاء ZIP (Mac/Linux)
zip -r OOP_Assignments.zip . -x "bin/*" "obj/*" ".vs/*" ".git/*" ".vscode/*"

# إنشاء ZIP (Windows PowerShell)
Compress-Archive -Path .\* -DestinationPath OOP_Assignments.zip
```

### الطريقة 2: من الواجهة الرسومية | Method 2: GUI
```
Windows:
1. انقر بزر الماوس الأيمن على مجلد OOP_Assignments
2. اختر Send to → Compressed (zipped) folder
3. أعد تسمية الملف إلى OOP_Assignments.zip

Mac:
1. انقر بزر الماوس الأيمن على مجلد OOP_Assignments
2. اختر Compress "OOP_Assignments"
```

---

## محتوى ZIP الصحيح | Correct ZIP Contents

ZIP يجب أن يحتوي على:

```
OOP_Assignments/
├── OOP_Assignments.sln              ✅
├── README.md                        ✅
├── SUBMISSION_GUIDE.md              ✅
├── .gitignore                       ✅
│
├── Uppgift1_ToString/
│   ├── Uppgift1_ToString.csproj     ✅
│   ├── Program.cs                   ✅
│   ├── Person.cs                    ✅
│   └── (NO bin/ or obj/ folders)    ✅
│
├── Uppgift2_Konstruktorer/
│   ├── Uppgift2_Konstruktorer.csproj
│   ├── Program.cs
│   └── Person.cs
│
... (جميع المشاريع الأخرى بنفس الهيكل)
... (all other projects with same structure)
```

---

## تحقق من الملف | Verify the File

### حجم الملف | File Size
```
قبل التنظيف | Before cleaning:  ~500 MB (مع bin و obj)
بعد التنظيف | After cleaning:   ~50 KB (بدون bin و obj)
```

### أعد فك الضغط واختبر | Extract and Test
```bash
# فك الضغط في مجلد جديد
unzip OOP_Assignments.zip -d test_extract

# تحقق من وجود ملفات .cs
find test_extract -name "*.cs" | head -20

# جرب فتح الحل
cd test_extract/OOP_Assignments
dotnet build
```

---

## خطوات التسليم النهائية | Final Submission Steps

### 1. تأكد من أن جميع المشاريع تعمل | Ensure All Projects Work
```bash
# بناء جميع المشاريع
dotnet build

# تشغيل كل مشروع
cd Uppgift1_ToString && dotnet run && cd ..
cd Uppgift2_Konstruktorer && dotnet run && cd ..
# ... إلخ
```

### 2. تحقق من المخرجات | Verify Output
- ✅ Uppgift1: 3 أسماء مع "Hej! Jag heter"
- ✅ Uppgift2: نفس Uppgift1 لكن مع constructor
- ✅ Uppgift3: Person، Student، Teacher مع الدوال
- ✅ Uppgift4: 16، 24، 64 (عدد الصفحات)
- ✅ Uppgift5: Undervisar، Pluggar، Pluggar
- ✅ Uppgift6: Kör (بعد إضافة الوقود)
- ✅ Uppgift7: اسم الكلب و "Äter"
- ✅ Uppgift8: الحسابات والآيس كريم
- ✅ Uppgift9: الرسالة والقيم العامة

### 3. أنشئ ZIP | Create ZIP
```bash
# نظف أولاً
dotnet clean

# إنشاء ZIP
zip -r OOP_Assignments.zip . -x "bin/*" "obj/*" ".vs/*" ".git/*" ".vscode/*"
```

### 4. رفع الملف | Upload File
- ارفع `OOP_Assignments.zip` على نظام التسليم
- تأكد من اسم الملف: `OOP_Assignments.zip`
- تأكد من حجم الملف < 100 KB

---

## قائمة التحقق | Checklist

قبل التسليم، تأكد من:

- [ ] جميع 9 مشاريع موجودة في الحل (Solution)
- [ ] كل مشروع له ملف .csproj صحيح
- [ ] كل مشروع يحتوي على Program.cs و classes المطلوبة
- [ ] جميع المشاريع تعمل وتنتج النتائج الصحيحة
- [ ] تم تنظيف المشروع (لا يوجد bin/ و obj/ folders)
- [ ] ملف README.md موجود مع شرح كامل
- [ ] ZIP ملف تم إنشاؤه بحجم صغير < 100 KB
- [ ] اختبرت ZIP بفك الضغط والبناء والتشغيل

---

## مثال على البناء الكامل | Full Build Example

```bash
# 1. انتقل إلى مجلس المشروع
cd /Users/mustafa.elnagar/Documents/GitHub/Hefzi

# 2. نظف المشروع
dotnet clean

# 3. بناء المشروع
dotnet build

# 4. اختبر مشروع واحد
cd Uppgift1_ToString
dotnet run
# Input: Juan
# Input: Sara
# Input: Kalle
# Expected Output:
# Hej! Jag heter Juan
# Hej! Jag heter Sara
# Hej! Jag heter Kalle

cd ..

# 5. أنشئ ZIP
zip -r OOP_Assignments.zip . -x "bin/*" "obj/*" ".vs/*" ".git/*" ".vscode/*"

# 6. تحقق من الحجم
ls -lh OOP_Assignments.zip
# يجب أن يكون الحجم حوالي 50 KB

# 7. اختبر ZIP
mkdir test_zip
unzip OOP_Assignments.zip -d test_zip
cd test_zip/OOP_Assignments
dotnet build
cd Uppgift1_ToString
dotnet run
```

---

## اسئلة شائعة | FAQ

### س: هل يجب أن أشمل ملفات .git؟ | Q: Should I include .git files?
**ج:** لا، استخدم `-x ".git/*"` عند إنشاء ZIP. | **A:** No, use `-x ".git/*"` when creating ZIP.

### س: حجم ZIP كبير جداً | Q: ZIP file is too large?
**ج:** تأكد من تنظيف المشروع مع `dotnet clean` و حذف bin/ و obj/ folders.
**A:** Make sure to clean with `dotnet clean` and remove bin/ and obj/ folders.

### س: كيف أختبر ZIP قبل التسليم؟ | Q: How to test ZIP before submission?
**ج:** فك الضغط في مجلد جديد، بناء وتشغيل المشاريع.
**A:** Extract in a new folder, build and run projects.

### س: هل أحتاج Visual Studio؟ | Q: Do I need Visual Studio?
**ج:** لا، يمكنك استخدام Visual Studio Code أو سطر الأوامر مع dotnet CLI.
**A:** No, you can use Visual Studio Code or command line with dotnet CLI.

---

## الدعم | Support

إذا واجهت مشكلة:

1. تحقق من README.md للتفاصيل الكاملة
2. جرب `dotnet clean` و `dotnet build` مرة أخرى
3. تأكد من تثبيت .NET 6.0 SDK أو أحدث
4. تحقق من أسماء الملفات والمجلدات (حساسة لحالة الأحرف على Linux/Mac)

If you encounter issues:

1. Check README.md for full details
2. Try `dotnet clean` and `dotnet build` again
3. Ensure .NET 6.0 SDK or higher is installed
4. Check file and folder names (case-sensitive on Linux/Mac)

---

**آخر تحديث | Last Updated: 2026-11-14**

**بالتوفيق! Good Luck! 🎉**
