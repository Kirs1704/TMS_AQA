namespace HomeWork_Collections.Task1;

public class WrongAuthorException : Exception
{
    public WrongAuthorException(Book book)
    {
        if (string.IsNullOrEmpty(book.AuthorName) || string.IsNullOrWhiteSpace(book.AuthorName))
        {
            Console.WriteLine("Некорректное имя автора");
        }
    }
}