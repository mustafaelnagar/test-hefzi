# البدء السريع | Quick Start

## في 5 دقائق | In 5 Minutes

### الخطوة 1: تحقق من التثبيت | Step 1: Verify Installation
```bash
dotnet --version
# يجب أن تحصل على: 6.0.xxx أو أعلى
```

### الخطوة 2: انتقل إلى المشروع | Step 2: Navigate to Project
```bash
cd /Users/mustafa.elnagar/Documents/GitHub/Hefzi
```

### الخطوة 3: بناء المشروع | Step 3: Build Project
```bash
dotnet build
# يجب أن ترى: Build succeeded!
```

### الخطوة 4: شغل مشروع | Step 4: Run a Project
```bash
cd Uppgift1_ToString
dotnet run
# ادخل ثلاثة أسماء ثم انقر Enter بعد كل واحد
```

---

## تشغيل جميع المشاريع | Run All Projects

### تشغيل سريع | Quick Run
```bash
# الدليل: Uppgift[N]_[Name] → البناء والتشغيل

# Task 1
cd Uppgift1_ToString && dotnet run && cd ..

# Task 2
cd Uppgift2_Konstruktorer && dotnet run && cd ..

# Task 3
cd Uppgift3_Arv && dotnet run && cd ..

# Task 4
cd Uppgift4_Fotoalbum && dotnet run && cd ..

# Task 5
cd Uppgift5_Arv2 && echo -e "Juan\nSara\nKalle" | dotnet run && cd ..

# Task 6
cd Uppgift6_Interface && echo "50" | dotnet run && cd ..

# Task 7
cd Uppgift7_AbstractKlasser && echo "Lufsen" | dotnet run && cd ..

# Task 8
cd Uppgift8_Polymorfism && dotnet run && cd ..

# Task 9
cd Uppgift9_Generiska && dotnet run && cd ..
```

---

## أوامر مفيدة | Useful Commands

```bash
# بناء مشروع محدد فقط
dotnet build Uppgift1_ToString/Uppgift1_ToString.csproj

# إزالة جميع ملفات البناء
dotnet clean

# تنظيف + بناء جديد
dotnet clean && dotnet build

# نشر (Release) بدل Debug
dotnet build --configuration Release

# عرض معلومات المشروع
dotnet project-assets

# فحص الأخطاء دون التشغيل
dotnet build --no-build
```

---

## التحقق السريع | Quick Verification

```bash
# تحقق من أن جميع الملفات موجودة
ls -la Uppgift*/Uppgift*.csproj

# عد الملفات .cs
find . -name "*.cs" | wc -l
# يجب أن تكون حوالي 30+ ملف

# تحقق من الحل
cat OOP_Assignments.sln | grep "Project"
# يجب أن ترى 9 مشاريع
```

---

## استكشاف الأخطاء | Troubleshooting Quick

| المشكلة | الحل |
|--------|------|
| `dotnet: command not found` | ثبت .NET SDK من https://dotnet.microsoft.com |
| `Could not find project file` | تأكد من وجود .csproj في المجلد |
| `Build failed` | جرب `dotnet clean` ثم `dotnet build` |
| `Input invalid` | تأكد من نوع البيانات المدخلة |
| `Object reference not set` | تأكد من استخدام `new` عند الإنشاء |

---

## الملفات المهمة | Important Files

```
✅ README.md              - الشرح الكامل
✅ ARABIC_REFERENCE.md   - مرجع عربي
✅ SUBMISSION_GUIDE.md   - دليل التسليم
✅ QUICK_START.md        - هذا الملف
✅ OOP_Assignments.sln   - ملف الحل الرئيسي

لا تحتاج:
❌ bin/                  - ملفات البناء
❌ obj/                  - ملفات الـ Objects
❌ .vs/                  - إعدادات Visual Studio
```

---

## الاختبار النهائي | Final Test

```bash
# الأمر الذهبي - اختبر كل شيء
#!/bin/bash

cd /Users/mustafa.elnagar/Documents/GitHub/Hefzi

echo "🧹 تنظيف..."
dotnet clean

echo "🔨 بناء..."
dotnet build

if [ $? -eq 0 ]; then
    echo "✅ البناء نجح!"
    echo "🚀 جاهز للتسليم!"
else
    echo "❌ خطأ في البناء"
fi
```

---

## الملخص | Summary

1. ✅ يوجد 9 مشاريع OOP
2. ✅ كل مشروع فيه الكود المطلوب
3. ✅ جميع الملفات موثقة بالعربية والإنجليزية
4. ✅ جاهز للتسليم

---

**الآن أنت جاهز! Now You're Ready! 🎉**

اقرأ `README.md` للتفاصيل الكاملة | Read `README.md` for full details
