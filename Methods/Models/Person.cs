namespace Methods.Models;

public class Person
{
    // блок полей (переменных)
    
    public string name = "Undefined"; // имя
    public int age;                   // возраст
    
    // блок методов и свойств

    public void Print()
    {
        Console.WriteLine($"Имя: {name} Возраст: {age}");
    }
    
}