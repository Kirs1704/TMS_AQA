namespace Generics;

public class MessengerStruct<T>  where T : struct
{
    public void SendMessage(T message)
    {
        Console.WriteLine($"Сообщение из мессенджера: {message.ToString()}");
    }
}