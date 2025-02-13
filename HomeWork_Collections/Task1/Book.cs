namespace HomeWork_Collections.Task1;

public class Book
{
    public string BookName { get; set; }
    public string AuthorName { get; set; }
    public int ProdYear { get; set; }

    public void AddBook()
    {
        try
        {
            Console.Write("Введите название книги: ");
            string? bookName = Console.ReadLine();
            BookName = bookName;
        }
        catch (WrongBookNameException ex)
        {
            if (string.IsNullOrEmpty(BookName) || string.IsNullOrWhiteSpace(BookName))
            {
                Console.WriteLine(ex);
            }   
        }
        Console.Write("Введите автора книги: ");
        string? authorName = Console.ReadLine();
        AuthorName = authorName;
        Console.Write("Введите год издания: ");
        int prodYear = Convert.ToInt32(Console.ReadLine());
        ProdYear = prodYear;
        
        Console.WriteLine($"Книга '{BookName}' автора '{AuthorName}' '{ProdYear}' года успешно добавлена в библиотеку");
    }
}