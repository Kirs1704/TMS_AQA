namespace HomeWork_Collections.Task1;

public class WrongYearException : Exception
{
    public WrongYearException(string message) : base(message)
    {
        if (string.IsNullOrEmpty(message) || string.IsNullOrWhiteSpace(message))
        {
            Console.WriteLine("Некорректное название книги");
        }
    }
}