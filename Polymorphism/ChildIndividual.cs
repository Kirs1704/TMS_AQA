namespace Polymorphism;

public class ChildIndividual : individual
{
    public ChildIndividual(int id) : base(id)
    {
        
    }
    
    public override void SendNotification()
    {
        base.SendNotification();
        Console.WriteLine("Дорогой клиент....Версия 2");
    }
}