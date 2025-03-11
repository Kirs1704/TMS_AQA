namespace HomeWork_Generics.Task3;

public class Car<T> where T:Engine
{
    private T _engine { get; }
    
    public Car(T engine)
    {
    }

    public virtual void Move()
    {
        Console.WriteLine("Машина движется...");
    }
}
