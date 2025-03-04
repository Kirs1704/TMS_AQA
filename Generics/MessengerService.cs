namespace Generics;

public class MessengerService<T, P> // создаем класс с двумя обобщенными типами
    where T:Message                     // первый - может быть только классом Message
    where P: SimplePerson               // второй - может быть только классом SimplePerson 
{
    public void SendMessage(P sender, P receiver, T message)     // создаем метод, в котором аргументы: отправитель (SimplePerson), получатель (SimplePerson) и сообщение (Message)
    {
        Console.WriteLine($"Отправитель: {sender.Name}");
        Console.WriteLine($"Получатель: {receiver.Name}");
        Console.WriteLine($"Сообщение: {message.Text}");
    }
}