using System;

// ============================================
// الواجب الرابع: الألبوم الفوتوغرافي
// Assignment 4: Photo Album
// ============================================

class PhotoBook
{
    private int numPages;

    public PhotoBook()
    {
        numPages = 16;
    }

    public PhotoBook(int pages)
    {
        numPages = pages;
    }

    public int GetNumberPages()
    {
        return numPages;
    }
}

class BigPhotoBook : PhotoBook
{
    public BigPhotoBook() : base(64)
    {
    }
}

class Program
{
    static void Main()
    {
        // Test 1: Default album
        PhotoBook album1 = new PhotoBook();
        Console.WriteLine(album1.GetNumberPages());

        // Test 2: Album with 24 pages
        PhotoBook album2 = new PhotoBook(24);
        Console.WriteLine(album2.GetNumberPages());

        // Test 3: Big album
        BigPhotoBook album3 = new BigPhotoBook();
        Console.WriteLine(album3.GetNumberPages());
    }
}
