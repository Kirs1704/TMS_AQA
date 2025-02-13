namespace HomeWork_Collections.Task1;

public class WrongBookNameException : Exception
{
    public WrongBookNameException(string message) : base(message)
    {
        if (string.IsNullOrEmpty(message) || string.IsNullOrWhiteSpace(message))
        {
            Console.WriteLine("Некорректное название книги");
        }
    }
}