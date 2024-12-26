using Interfaces.Example;

namespace Interfaces.BaseImpl;

public abstract class Device : IDysplayable
{
    public abstract void DisplayInformation(string information); // с помощью слова abstract мы делегируем дочерним классам имплементацию метода из IDisplayeble
}