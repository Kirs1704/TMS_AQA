using System.Runtime.Serialization;

namespace HomeWork_Collections.Task1;

public class WrongBookNameException : Exception
{
    public WrongBookNameException(Book book)
    {
        if (string.IsNullOrEmpty(book.BookName) || string.IsNullOrWhiteSpace(book.BookName))
        {
            Console.WriteLine("Некорректное название книги");
        }
    }
}