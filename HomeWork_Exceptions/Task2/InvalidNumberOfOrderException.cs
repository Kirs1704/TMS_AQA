namespace HomeWork_Exceptions.Task2;

public class InvalidNumberOfOrderException : Exception
{
    public InvalidNumberOfOrderException(string message) : base(message)
    {
        Console.WriteLine("Номер заказа указан НЕВЕРНО!");
    }
    
}