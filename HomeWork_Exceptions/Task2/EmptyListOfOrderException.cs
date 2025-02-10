using System.Runtime.Intrinsics.Arm;

namespace HomeWork_Exceptions.Task2;

public class EmptyListOfOrderException : Exception
{
    public EmptyListOfOrderException(string message) : base(message)
    {
        Console.WriteLine("Список товаров не может быть пустым");
    }
}