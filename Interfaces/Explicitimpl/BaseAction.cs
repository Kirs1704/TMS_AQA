namespace Interfaces.Explicitimpl;

public class BaseAction : IAction      // реализуем в классе BaseAction интерфейс IAction
{
    void IAction.Move() => Console.WriteLine("This is BaseAction...");      // явная имплементация метода от интерфейса. При таком подходе методы интерфейса не являются частью класса-наследника
}