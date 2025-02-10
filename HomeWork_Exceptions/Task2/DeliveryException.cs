namespace HomeWork_Exceptions.Task2;

public class DeliveryException : Exception
{
    public DeliveryException(string message) : base(message)
    {
        Console.WriteLine("Недостаточно информации по доставке");
    }
}