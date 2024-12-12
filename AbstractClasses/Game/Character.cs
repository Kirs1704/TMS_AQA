namespace AbstractClasses.Game;

public abstract class Character
{
    // блок переменных
    public int level;
    public string name;


    // блок метода
    public abstract void Move();  // когда метод абстрактный, предполагается, что у него не будет тела
    public abstract void Attack(); // все это шаблоны для классов - наследников
    public abstract void UseAbility();  // в каждом классе наследнике будет своя уникальная реализация таких методов
    
    // в классе - шаблоне можно реализовывать полноценные методы
    public void PrintInfo()
    {
        Console.WriteLine($"Имя: {name}, Уровень: {level}");
    }
    
    // абстрактный класс может иметь также автосвойства:
    
    public abstract string Clan { get; set; }
}