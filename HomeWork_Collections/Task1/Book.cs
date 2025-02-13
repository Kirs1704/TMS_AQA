using System.Collections;

namespace HomeWork_Collections.Task1;

public class Book
{
    public string BookName { get; set; }
    public string AuthorName { get; set; }
    public int ProdYear { get; set; }

    public void NewBook()
    {

        Console.Write("Введите название книги: ");
        BookName = Console.ReadLine();
        Console.Write("Введите автора книги: ");
        AuthorName = Console.ReadLine();
        Console.Write("Введите год издания: ");
        ProdYear = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine($"Книга '{BookName}' автора '{AuthorName}' '{ProdYear}' года успешно добавлена в библиотеку!");
    }
    
}