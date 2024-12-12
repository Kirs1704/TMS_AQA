namespace AbstractClasses.Game;

public class Warrior : Character // структура класса-наследника (поля, методы и т.д.) д.б. строго аналогична классу-шаблону
{
    public override void Move()
    {
        Console.WriteLine("Warrior is moving to..."); // переопределили метод класса-родителя (шаблона) Character
    }

    public override void Attack()
    {
        Console.WriteLine("Warrior is attacking to...");
    }

    public override void UseAbility()
    {
        Console.WriteLine("Warrior using abilities...");
    }

    public override string Clan { get; set; }
}