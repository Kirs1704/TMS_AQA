namespace Polymorphism;

public class individual : Client
{
    public string FirstName;
    public string LastName;

    public individual(int id) : base(id) // вызывает конструктор родителя (base)
    {
        Console.WriteLine("Individual base HashCode: " + base.GetHashCode());
    }

    protected individual()
    {
    }


    // В этом классе мы сначала вызываем реализацию данного метода из родительского класса (base.)
    // А потом переопределяем метод и пишем свою реализацию ("Дорогой клиент...")
    public override void SendNotification()
    {
        base.SendNotification();
        Console.WriteLine("Дорогой клиент....");
    }
}