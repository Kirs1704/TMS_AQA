using System.Collections;

namespace HomeWork_Collections.Task1;

public class Book
{
    public string BookName { get; set; }
    public string AuthorName { get; set; }
    public int ProdYear { get; set; }
    public override string ToString()
    {
        return $"Название: {BookName}, Автор: {AuthorName}, Год: {ProdYear}";
    }

}