namespace Interfaces.Explicitimpl;

public class BaseAction1 : IAction      // реализуем в классе BaseAction1 интерфейс IAction
{
    public virtual void Move() => Console.WriteLine("BaseAction");
}