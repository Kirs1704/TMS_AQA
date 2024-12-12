namespace AbstractClasses.Game;

public class Wizard : Character
{
    public override void Move()
    {
        Console.WriteLine("Wizard is moving to..."); // переопределили метод класса-родителя (шаблона) Character
    }

    public override void Attack()
    {
        Console.WriteLine("Wizard is attacking to...");
    }

    public override void UseAbility()
    {
        Console.WriteLine("Wizard using abilities...");
    }

    public override string Clan { get; set; }
}