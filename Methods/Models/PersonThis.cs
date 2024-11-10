namespace Methods.Models;

public class PersonThis                   // создаем класс
{
    // блок полей
    public string name;
    public int age;
    
    // блок конструктора
    public PersonThis()                 // Коструктор № 1. Без параметров
    {
        name = "Неизвестно";
        age = 18;
    }

    public PersonThis(string name)     // Конструктор № 2. С параметром "name"
    {
        this.name = name;              // "this" говорит о том, что имеется в виду "name" из блока полей
        age = 18;
    }

    public PersonThis(string name, int age)   // Конструктор № 3. С параметрами "name" и "age"
    {
        this.name = name;                     // "this" говорит о том, что имеется в виду "name" из блока полей
        this.age = age;                       // "this" говорит о том, что имеется в виду "age" из блока полей
    }
    
    // блок методов и свойств
    public void Print() => Console.WriteLine($"Имя: {name}, Возраст: {age}");
}