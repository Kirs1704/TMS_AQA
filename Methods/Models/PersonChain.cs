namespace Methods.Models;

public class PersonChain
{
    public string name;
    public int age;

    public PersonChain() : this("Неизвестно")          // Конструктор № 1
    {
    }

    public PersonChain(string name) : this(name, 18)     // Конструктор № 2
    {
    } 
    
    public PersonChain(string name, int age)                  // Конструктор № 3
    {
        this.name = name;
        this.age = age;
    }

    public void Print() => Console.WriteLine($"Имя: {name}, Возраст: {age}");
}