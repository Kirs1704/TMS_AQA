namespace HomeWork_Exceptions.Task1;

public class WrongLoginException : Exception
{
    public WrongLoginException()
    {
        
    }
    public WrongLoginException(string message) : base(message)
    {
        if (string.IsNullOrWhiteSpace(message) || message.Length > 20)
        {
            throw new Exception("Длина логина не может превышать 20 символов или состоять из пробелов");
        }
        else
        {
            Console.WriteLine("Логин задан успешно!");
        }
    }    
}