using System;

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

PhotoBook album1 = new PhotoBook();
Console.WriteLine(album1.GetNumberPages());

PhotoBook album2 = new PhotoBook(24);
Console.WriteLine(album2.GetNumberPages());

BigPhotoBook album3 = new BigPhotoBook();
Console.WriteLine(album3.GetNumberPages());
