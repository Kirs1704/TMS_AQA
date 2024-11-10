namespace Methods.Models;

public class PersonWithConstructor
{
    // блок полей (переменных)
    
    public string name;                // имя
    public int age;                   // возраст

    public PersonWithConstructor()
    {
        name = "Undefined";
        age = 1;
    }
    
    
    
    // блок методов и свойств

    public void Print()
    {
        Console.WriteLine($"Имя: {name} Возраст: {age}");
    }
    
}