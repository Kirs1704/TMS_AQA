using System.Collections;

namespace HomeWork_Collections.Task1;

public static class AddBookHelper
{
    public static string Name { get; set; }
    public static void AddBook(ArrayList newBook)
    {
        newBook.Add(typeof(Book));
    }
}