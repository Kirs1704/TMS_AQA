using System.Text.RegularExpressions;
namespace HomeWork_Exceptions.Task1;

public class WrongPasswordException : Exception
{
    public WrongPasswordException()
    {
        
    }

    public WrongPasswordException(string message) : base(message)
    {
        if (message.Length > 20 || string.IsNullOrWhiteSpace(message) || !Regex.IsMatch(message, @"\d"))
        {
            throw new Exception("Пароль не соответствует требованиям!");
        }
        else
        {
            Console.WriteLine("Пароль задан успешно!");
        }
    }
}