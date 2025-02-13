using System.Collections;

namespace HomeWork_Collections.Task1;

public  class Library
{
    private ArrayList _books;
    public Library()
    {
        _books = new ArrayList();
    }

    public void AddTheBook()
    {
        Book book = new Book();
        Console.WriteLine("Введите название книги:");
        book.BookName = Console.ReadLine();
        Console.WriteLine("Введите автора:");
        book.AuthorName = Console.ReadLine();
        Console.WriteLine("Введите год издания:");
        book.ProdYear = Convert.ToInt32(Console.ReadLine());


    }
}