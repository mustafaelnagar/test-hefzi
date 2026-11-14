# برنامج التشغيل والمخرجات | Program Run Demonstration

## تشغيل جميع المشاريع | Running All Projects

### ✅ Uppgift 1: ToString()

**الأمر | Command:**
```bash
cd Uppgift1_ToString
dotnet run
```

**Input (المدخلات):**
```
Juan
Sara
Kalle
```

**Output (المخرجات):**
```
Hej! Jag heter Juan
Hej! Jag heter Sara
Hej! Jag heter Kalle
```

**الشرح:**
- برنامج يقرأ 3 أسماء من المستخدم
- ينشئ كائنات Person من كل اسم
- يطبع كل شخص باستخدام ToString()

---

### ✅ Uppgift 2: Constructors و Destructors

**الأمر | Command:**
```bash
cd ../Uppgift2_Konstruktorer
dotnet run
```

**Input (المدخلات):**
```
Juan
Sara
Kalle
```

**Output (المخرجات):**
```
Hej! Jag heter Juan
Hej! Jag heter Sara
Hej! Jag heter Kalle
```

**الشرح:**
- نفس Task 1 لكن مع استخدام Constructor
- Constructor ينفذ عند إنشاء الكائن (يحفظ الاسم)
- Destructor ينفذ عند حذف الكائن (يحذف الاسم)

---

### ✅ Uppgift 3: Inheritance - Person, Student, Teacher

**الأمر | Command:**
```bash
cd ../Uppgift3_Arv
dotnet run
```

**Input (المدخلات):**
```
(بدون مدخلات - البرنامج ينشئ الكائنات مباشرة)
```

**Output (المخرجات):**
```
Hej!
Hej!
Jag är 21 år gammal
Jag pluggar!
Hej!
Jag förklarar
```

**الشرح:**
- ينشئ Person عادية → تقول "Hej!"
- ينشئ Student، تعيين عمر 21 → تقول "Hej!" و العمر و "Jag pluggar!"
- ينشئ Teacher → تقول "Hej!" و "Jag förklarar"

---

### ✅ Uppgift 4: Photo Album

**الأمر | Command:**
```bash
cd ../Uppgift4_Fotoalbum
dotnet run
```

**Input (المدخلات):**
```
(بدون مدخلات)
```

**Output (المخرجات):**
```
16
24
64
```

**الشرح:**
- PhotoBook افتراضية: 16 صفحة
- PhotoBook مخصصة: 24 صفحة
- BigPhotoBook: 64 صفحة
- يطبع عدد الصفحات لكل واحدة

---

### ✅ Uppgift 5: Inheritance مع Type Casting

**الأمر | Command:**
```bash
cd ../Uppgift5_Arv2
dotnet run
```

**Input (المدخلات):**
```
Juan
Sara
Kalle
```

**Output (المخرجات):**
```
Undervisar
Pluggar
Pluggar
```

**الشرح:**
- Juan → Teacher → طباعة "Undervisar"
- Sara → Student → طباعة "Pluggar"
- Kalle → Student → طباعة "Pluggar"

---

### ✅ Uppgift 6: Interface (IVehicle)

**الأمر | Command:**
```bash
cd ../Uppgift6_Interface
dotnet run
```

**Input (المدخلات):**
```
50
```

**Output (المخرجات):**
```
Kör
```

**الشرح:**
- ينشئ سيارة بـ 0 بنزين
- تضيف 50 لتر بنزين
- تركض السيارة (Kör) لأن عندها وقود

---

### ✅ Uppgift 7: Abstract Class (Animal, Dog)

**الأمر | Command:**
```bash
cd ../Uppgift7_AbstractKlasser
dotnet run
```

**Input (المدخلات):**
```
Lufsen
```

**Output (المخرجات):**
```
Lufsen
Äter
```

**الشرح:**
- تقرأ اسم الكلب: "Lufsen"
- تطبع الاسم: "Lufsen"
- تطبع أن الكلب يأكل: "Äter"

---

### ✅ Uppgift 8: Polymorphism

**الأمر | Command:**
```bash
cd ../Uppgift8_Polymorfism
dotnet run
```

**Input (المدخلات):**
```
(بدون مدخلات)
```

**Output (المخرجات):**
```
Summan av 5 och 4 är 9
Summan av 9,3 och 8,6 är 17,900002
Hej världen - är inte numeriskt
Class : Icecream
Class : Chocolate
IceCream Type : Chocolate
```

**الشرح:**
- Sum(int, int): 5 + 4 = 9
- Sum(float, float): 9.3 + 8.6 = 17.9
- Sum(string, string): خطأ، نص غير رقمي
- ينشئ Chocolate (يطبع أسماء الفئات)
- يطبع نوع الآيس كريم

---

### ✅ Uppgift 9: Generic Classes

**الأمر | Command:**
```bash
cd ../Uppgift9_Generiska
dotnet run
```

**Input (المدخلات):**
```
(بدون مدخلات)
```

**Output (المخرجات):**
```
Välkommen till ABF!
Name: Stina Persson
Location: Helsingborg
Param1: 1
Param2: 2
Param1: Gabriel Ruis
Param2: Säffle
```

**الشرح:**
- GenericClass<string> مع رسالة ترحيب
- طباعة الاسم والمقاطعة
- SampleClass مع معاملات int
- SampleClass مع معاملات string

---

## ملخص المخرجات | Summary of All Outputs

| # | المشروع | النوع | عدد الأسطر |
|---|---------|-------|---------|
| 1 | Uppgift1_ToString | Input → Output | 3 |
| 2 | Uppgift2_Konstruktorer | Input → Output | 3 |
| 3 | Uppgift3_Arv | No Input | 6 |
| 4 | Uppgift4_Fotoalbum | No Input | 3 |
| 5 | Uppgift5_Arv2 | Input → Output | 3 |
| 6 | Uppgift6_Interface | Input → Output | 1 |
| 7 | Uppgift7_AbstractKlasser | Input → Output | 2 |
| 8 | Uppgift8_Polymorfism | No Input | 6 |
| 9 | Uppgift9_Generiska | No Input | 7 |

**الإجمالي | Total:** 9 مشاريع | 34 سطر output

---

## اختبار سريع | Quick Test All

لتشغيل جميع المشاريع تلقائياً:

```bash
#!/bin/bash

cd /Users/mustafa.elnagar/Documents/GitHub/Hefzi

echo "=== Uppgift 1 ==="
cd Uppgift1_ToString && echo -e "Juan\nSara\nKalle" | dotnet run && cd ..

echo ""
echo "=== Uppgift 2 ==="
cd Uppgift2_Konstruktorer && echo -e "Juan\nSara\nKalle" | dotnet run && cd ..

echo ""
echo "=== Uppgift 3 ==="
cd Uppgift3_Arv && dotnet run && cd ..

echo ""
echo "=== Uppgift 4 ==="
cd Uppgift4_Fotoalbum && dotnet run && cd ..

echo ""
echo "=== Uppgift 5 ==="
cd Uppgift5_Arv2 && echo -e "Juan\nSara\nKalle" | dotnet run && cd ..

echo ""
echo "=== Uppgift 6 ==="
cd Uppgift6_Interface && echo "50" | dotnet run && cd ..

echo ""
echo "=== Uppgift 7 ==="
cd Uppgift7_AbstractKlasser && echo "Lufsen" | dotnet run && cd ..

echo ""
echo "=== Uppgift 8 ==="
cd Uppgift8_Polymorfism && dotnet run && cd ..

echo ""
echo "=== Uppgift 9 ==="
cd Uppgift9_Generiska && dotnet run && cd ..

echo ""
echo "✅ جميع المشاريع تمت! All projects complete!"
```

---

## التحقق من الصحة | Verification Checklist

✅ **Uppgift 1** - ToString() يعمل بشكل صحيح  
✅ **Uppgift 2** - Constructor و Destructor يعملان  
✅ **Uppgift 3** - الوراثة من Person تعمل بشكل صحيح  
✅ **Uppgift 4** - Photo Album مع أحجام مختلفة  
✅ **Uppgift 5** - Type Casting يعمل  
✅ **Uppgift 6** - Interface تطبق بشكل صحيح  
✅ **Uppgift 7** - Abstract Class يعمل  
✅ **Uppgift 8** - Polymorphism overloading و overriding  
✅ **Uppgift 9** - Generic Classes مع أنواع مختلفة  

**كل المشاريع جاهزة وتعمل بشكل صحيح!**

---

**آخر تحديث | Last Updated: 2026-11-14**
