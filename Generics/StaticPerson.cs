namespace Generics;

public class StaticPerson<T>
{
    public static T? code;      // знак вопроса тут нужен, чтобы обработать ситуацию, когда code == null
    public T Id { get; set; }
    public string Name { get; set; }

    public StaticPerson(T id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Print()
    {
        Console.WriteLine($"Id клиента: {Id}\nИмя клиента: {Name}");
    }
}