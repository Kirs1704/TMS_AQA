namespace Interfaces.Example;

public class Smartphone : IDysplayable
// Можно наследоваться одновременно от класса и от интерфейса или нескольких интерфейсов. Например: 
// public class Smartphone : Tablet, IDysplayable, IExample....... (тут Smartphone наследуется от класса Tablet и двух интерфейсов (IDysplayable, IExample)
{
    public int UUID;
    public void DisplayInformation(string information)
    {
        Console.WriteLine($"Smartphone dysplay: {information}"); // реализация отображения на экране смартфона
    }
}