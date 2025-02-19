namespace Generics;

public class GenericPerson<T>
{
    public T Id { get; set; }
    public string Name { get; set; }

    public GenericPerson(T id, string name)
    {
        Id = id;
        Name = name;
    }

    public void Print()
    {
        Console.WriteLine($"Id клиента: {Id}\nИмя клиента: {Name}");
    }
}