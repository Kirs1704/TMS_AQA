namespace Methods.Models;

public class PersonPrimaryConstructors(string name, int age)
{
    public PersonPrimaryConstructors(string name) : this(name, 18)
    {
    }

    public void Print() => Console.WriteLine($"Имя: {name}, Возраст: {age}");

}