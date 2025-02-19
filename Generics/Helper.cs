namespace Generics;

public static class Helper
{
    public static void Swap<T>(ref T x, ref T y)
    {
        T tmp = x;
        x = y;
        y = tmp;
        // (x,y) = (y,x);
    }


    public static void SendMessage(Message message) // обычный метод
    {
        Console.WriteLine($"Отправляемое сообщение: {message.Text}");
    }

    /*
    public static void SendMessage<T>(T message) // типизированный метод
    {
        Console.WriteLine($"Отправляемое сообщение: {message.Text}"); // ошибка свойства text
    }
    */
    
    public static void SendMessage<T>(T message) where T: Message      // ограничение метода. Здесь T может быть только классом Message
    {
        Console.WriteLine($"Отправляемое сообщение: {message.Text}");
    }
}